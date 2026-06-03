using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ServiceHubClass;

namespace servicehub
{
    public partial class FrmUsuarios : Form
    {
        private int usuarioSelecionadoId = 0;
        private bool editando = false;

        public FrmUsuarios()
        {
            InitializeComponent();
        }


        private void FrmUsuarios_Load_1(object sender, EventArgs e)
        {
            // Configurações do Nível
            NUDnivel.Minimum = 1;       // Menor nível permitido (ex: 1)
            NUDnivel.Maximum = 5;       // Maior nível permitido (ex: 5 - ajuste se precisar)
            NUDnivel.Value = 1;         // Valor padrão inicial

            // Configurações visuais e de segurança do DataGridView
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.MultiSelect = false;
            dgvUsuarios.ReadOnly = true;

            // Carrega os dados na tabela pela primeira vez
            CarregaGrid();
        }

        private void CarregaGrid(string texto = "")
        {
            // Desconecta qualquer fonte de dados automática para não dar o erro do Rows.Clear()
            dgvUsuarios.DataSource = null;
            dgvUsuarios.Rows.Clear();

            List<Usuario> usuarios = Usuario.ObterLista(texto);

            foreach (var user in usuarios)
            {
                dgvUsuarios.Rows.Add();
                int rowIndex = dgvUsuarios.Rows.Count - 1;

                dgvUsuarios.Rows[rowIndex].Cells[0].Value = user.Id;
                dgvUsuarios.Rows[rowIndex].Cells[1].Value = user.Nome;
                dgvUsuarios.Rows[rowIndex].Cells[2].Value = user.Email;
                dgvUsuarios.Rows[rowIndex].Cells[3].Value = user.Senha;
                dgvUsuarios.Rows[rowIndex].Cells[4].Value = user.nivel?.Nome;
                dgvUsuarios.Rows[rowIndex].Cells[5].Value = user.Ativo;
            }
        }


        private void LimparCampos()
        {
            TXTid.Clear();
            TXTnome.Clear();
            TXTemail.Clear();
            TXTsenha.Clear();
            TXTbuscar.Clear();

            // Volta o NUD para o valor mínimo configurado
            NUDnivel.Value = NUDnivel.Minimum;
            CHKativo.Checked = true;

            usuarioSelecionadoId = 0;
            editando = false;

            BTNeditar.Text = "Editar";
            TXTnome.Focus();
        }


        private void BTNadicionar_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario(
                TXTnome.Text,
                TXTemail.Text,
                Nivel.ObterPorId(Convert.ToInt32(NUDnivel.Value)),
                TXTsenha.Text,
                CHKativo.Checked);

            user.Inserir();

            if (user.Id > 0)
            {
                MessageBox.Show($"Usuário {user.Id} inserido com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregaGrid();
            }
        }


        private void BTNeditar_Click(object sender, EventArgs e)
        {
            // Validações antes de editar
            if (string.IsNullOrWhiteSpace(TXTid.Text))
            {
                MessageBox.Show("Por favor, selecione um usuário na lista para editar.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (NUDnivel.Value <= 0)
            {
                MessageBox.Show("Por favor, selecione um Nível válido maior que zero!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Monta o usuário pegando as informações da tela
            Usuario user = new Usuario();
            user.Id = int.Parse(TXTid.Text);
            user.Nome = TXTnome.Text;
            user.Email = TXTemail.Text;
            user.Senha = TXTsenha.Text;
            user.nivel = Nivel.ObterPorId(Convert.ToInt32(NUDnivel.Value));
            user.Ativo = CHKativo.Checked;

            // Verifica se o nível retornou nulo (evita o erro do MySQL)
            if (user.nivel == null || user.nivel.Id == 0)
            {
                MessageBox.Show("O nível informado não existe no banco de dados!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Atualiza no banco
            if (user.Atualizar())
            {
                MessageBox.Show("Usuário alterado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimparCampos();
                CarregaGrid();
            }
        }


        private void BTNexcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTid.Text))
            {
                MessageBox.Show("Por favor, selecione um usuário na lista para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult resposta = MessageBox.Show(
                "Deseja realmente excluir este usuário?",
                "Confirmar exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                int idParaExcluir = int.Parse(TXTid.Text);

                if (Usuario.Excluir(idParaExcluir))
                {
                    MessageBox.Show("Usuário excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    CarregaGrid();
                }
                else
                {
                    MessageBox.Show("Não foi possível excluir o usuário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregaGrid();
        }


        private void dgvUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Evita erro se clicar no cabeçalho da tabela
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvUsuarios.Rows[e.RowIndex];

                TXTid.Text = row.Cells[0].Value?.ToString() ?? "";
                TXTnome.Text = row.Cells[1].Value?.ToString() ?? "";
                TXTemail.Text = row.Cells[2].Value?.ToString() ?? "";
                TXTsenha.Text = row.Cells[3].Value?.ToString() ?? "";

                // Atualizando variáveis de controle
                if (int.TryParse(TXTid.Text, out int id))
                {
                    usuarioSelecionadoId = id;
                    editando = true;
                }
            }
        }

        private void TXTbuscar_TextChanged(object sender, EventArgs e)
        {
            if (TXTbuscar.Text.Length > 1 || TXTbuscar.Text == "")
            {
                CarregaGrid(TXTbuscar.Text);
            }
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            {
                TXTnome.Clear();
                TXTemail.Clear();
                TXTsenha.Clear();
                TXTid.Clear();

            }
        }
    }
}