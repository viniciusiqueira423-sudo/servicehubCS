using ServiceHubClass;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace servicehub
{
    public partial class FrmCliente : Form
    {
        private int clienteSelecionadoId = 0;
        private bool editando = false;

        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            DGVclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVclientes.MultiSelect = false;
            DGVclientes.ReadOnly = true;

            CarregarClientes();
        }

        private void CarregarClientes(string busca = "")
        {
            DGVclientes.Rows.Clear();

            List<Cliente> clientes = Cliente.ObterLista(busca);

            foreach (var cliente in clientes)
            {
                DGVclientes.Rows.Add(
                    cliente.Id,
                    cliente.Nome,
                    cliente.Cpf,
                    cliente.Email,
                    cliente.Telefone,
                    cliente.DataNascimento.ToString("dd/MM/yyyy"),
                    cliente.DataCadastro.ToString("dd/MM/yyyy"),
                    cliente.Ativo
                );
            }
        }

        private void LimparCampos()
        {
            TXTid.Clear();
            TXTnome.Clear();
            TXTcpf.Clear();
            TXTemail.Clear();
            TXTtelefone.Clear();
            TXTbuscar.Clear();

            DTPnascimento.Value = DateTime.Now;
            DTPcadastro.Value = DateTime.Now;

            CHKativo.Checked = false;

            clienteSelecionadoId = 0;
            editando = false;

            BTNeditar.Text = "Editar";

            TXTnome.Focus();
        }

        private void BTNadicionar_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
                TXTnome.Text,
                TXTcpf.Text,
                TXTemail.Text,
                TXTtelefone.Text,
                DateOnly.FromDateTime(DTPnascimento.Value),
                DTPcadastro.Value,
                CHKativo.Checked,
                null,
                null
            );

            string msg = Cliente.Cadastrar(cliente);

            MessageBox.Show(msg);

            if (cliente.Id > 0)
            {
                LimparCampos();
                CarregarClientes();
            }
        }

        private void BTNpesquisar_Click(object sender, EventArgs e)
        {
            CarregarClientes(TXTbuscar.Text);
        }

        private void BTNeditar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTid.Text))
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            Cliente cliente = new Cliente(
                Convert.ToInt32(TXTid.Text),
                TXTnome.Text,
                TXTcpf.Text,
                TXTemail.Text,
                TXTtelefone.Text,
                DateOnly.FromDateTime(DTPnascimento.Value),
                DTPcadastro.Value,
                CHKativo.Checked
            );

            if (cliente.Atualizar())
            {
                MessageBox.Show("Cliente atualizado com sucesso!");

                LimparCampos();
                CarregarClientes();
            }
            else
            {
                MessageBox.Show("Não foi possível atualizar o cliente.");
            }
        }

        private void BTNexcluir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TXTid.Text))
            {
                MessageBox.Show("Selecione um cliente.");
                return;
            }

            DialogResult resposta = MessageBox.Show(
                $"Deseja excluir o cliente {TXTnome.Text}?",
                "Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resposta == DialogResult.Yes)
            {
                if (Cliente.Excluir(Convert.ToInt32(TXTid.Text)))
                {
                    MessageBox.Show("Cliente excluído com sucesso!");

                    LimparCampos();
                    CarregarClientes();
                }
                else
                {
                    MessageBox.Show("Erro ao excluir cliente.");
                }
            }
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
            CarregarClientes();
        }

        private void DGVclientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            TXTid.Text = DGVclientes.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "";
            TXTnome.Text = DGVclientes.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
            TXTcpf.Text = DGVclientes.Rows[e.RowIndex].Cells[2].Value?.ToString() ?? "";
            TXTemail.Text = DGVclientes.Rows[e.RowIndex].Cells[3].Value?.ToString() ?? "";
            TXTtelefone.Text = DGVclientes.Rows[e.RowIndex].Cells[4].Value?.ToString() ?? "";

            DateTime nascimento;
            if (DateTime.TryParse(
                DGVclientes.Rows[e.RowIndex].Cells[5].Value?.ToString(),
                out nascimento))
            {
                DTPnascimento.Value = nascimento;
            }

            DateTime cadastro;
            if (DateTime.TryParse(
                DGVclientes.Rows[e.RowIndex].Cells[6].Value?.ToString(),
                out cadastro))
            {
                DTPcadastro.Value = cadastro;
            }

            CHKativo.Checked = Convert.ToBoolean(
                DGVclientes.Rows[e.RowIndex].Cells[7].Value
            );

            clienteSelecionadoId = Convert.ToInt32(TXTid.Text);
        }

        private void TXTbuscar_TextChanged(object sender, EventArgs e)
        {
            CarregarClientes(TXTbuscar.Text);
        }
    }
}