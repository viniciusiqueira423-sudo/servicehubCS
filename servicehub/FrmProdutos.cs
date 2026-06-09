using ServiceHubClass;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace servicehub
{
    public partial class FrmProdutos : Form
    {
        private bool edicao = false;
        private int idProdutoSelecionado = 0;

        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CMDcategoria.DataSource = Categoria.ObterLista();
            CMDcategoria.DisplayMember = "Nome";
            CMDcategoria.ValueMember = "Id";
            CarregarGrid();
            ConfigurarGrid();
        }

        private void CarregarGrid()
        {
            DGVprodutos.DataSource = Produto.obterLista();
        }

        private void ConfigurarGrid()
        {
            DGVprodutos.ReadOnly = true;
            DGVprodutos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVprodutos.MultiSelect = false;
            DGVprodutos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LimparCampos()
        {
            TXTcodBarras.Text = string.Empty;
            TXTdescricao.Text = string.Empty;
            NudValorUnit.Value = 0;
            TXTuniVendas.Text = string.Empty;
            NUDestoquemin.Value = 0;
            NUDclassedesc.Value = 0;
            PICimagem.Image = null;
            CHKdescontinuado.CheckState = CheckState.Indeterminate;
            CMDcategoria.SelectedIndex = 0;
            edicao = false;
            idProdutoSelecionado = 0;
            BTNsalvar.Text = "&Salvar";
        }

        private void BTNsalvar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TXTdescricao.Text))
            {
                MessageBox.Show("Informe a descrição do produto.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TXTdescricao.Focus();
                return;
            }

            if (edicao)
            {
                Produto produto = Produto.obterPorId(idProdutoSelecionado);
                produto.codBarras = TXTcodBarras.Text;
                produto.descricao = TXTdescricao.Text;
                produto.valorUnit = (double)NudValorUnit.Value;
                produto.unidadeVenda = TXTuniVendas.Text;
                produto.Categoria = Categoria.ObterPorId(Convert.ToInt32(CMDcategoria.SelectedValue));
                produto.estoqueMin = (double)NUDestoquemin.Value;
                produto.ClasseDesconto = (double)NUDclassedesc.Value;
                produto.descotinuado = CHKdescontinuado.Checked;

                bool atualizado = produto.Atualizar();
                if (atualizado)
                {
                    MessageBox.Show($"Produto '{produto.descricao}' atualizado com sucesso!",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show("Não foi possível atualizar o produto.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                // MODO INSERÇÃO
                Produto produto = new(
                    TXTcodBarras.Text,
                    TXTdescricao.Text,
                    (double)NudValorUnit.Value,
                    TXTuniVendas.Text,
                    Categoria.ObterPorId(Convert.ToInt32(CMDcategoria.SelectedValue)),
                    (double)NUDestoquemin.Value,
                    (double)NUDclassedesc.Value
                );
                produto.Inserir();

                if (produto.id > 0)
                {
                    MessageBox.Show($"Produto '{produto.descricao}' gravado com sucesso!",
                        "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                    CarregarGrid();
                }
                else
                {
                    MessageBox.Show("Erro ao gravar o produto.", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verifica se alguma linha está selecionada no grid
            if (DGVprodutos.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um produto na lista para editar.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtém o id da linha selecionada
            int id = Convert.ToInt32(DGVprodutos.SelectedRows[0].Cells["id"].Value);
            Produto produto = Produto.obterPorId(id);

            if (produto == null || produto.id == 0)
            {
                MessageBox.Show("Produto não encontrado.", "Erro",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Carrega os dados nos campos
            idProdutoSelecionado = produto.id;
            TXTcodBarras.Text = produto.codBarras;
            TXTdescricao.Text = produto.descricao;
            NudValorUnit.Value = (decimal)produto.valorUnit;
            TXTuniVendas.Text = produto.unidadeVenda;
            NUDestoquemin.Value = (decimal)produto.estoqueMin;
            NUDclassedesc.Value = (decimal)produto.ClasseDesconto;
            CHKdescontinuado.Checked = produto.descotinuado;

            // Seleciona a categoria correta no ComboBox
            if (produto.Categoria != null)
                CMDcategoria.SelectedValue = produto.Categoria.Id;

            // Carrega imagem se existir
            if (produto.imagem != null && produto.imagem.Length > 0)
            {
                using MemoryStream ms = new(produto.imagem);
                PICimagem.Image = Image.FromStream(ms);
            }

            // Muda o botão salvar para "Atualizar"
            edicao = true;
            BTNsalvar.Text = "&Atualizar";
            TXTcodBarras.Focus();
        }

        private void BTNcancelar_Click(object sender, EventArgs e)
        {
            LimparCampos();
        }

        private void BTNpesquisar_Click(object sender, EventArgs e)
        {
            string termoBusca = TXTdescricao.Text.Trim().ToLower();

            if (string.IsNullOrWhiteSpace(termoBusca))
            {
                // Se vazio, recarrega tudo
                CarregarGrid();
                return;
            }

            List<Produto> todos = Produto.obterLista();
            List<Produto> filtrados = todos
                .Where(p => p.descricao != null &&
                            p.descricao.ToLower().Contains(termoBusca))
                .ToList();

            if (filtrados.Count == 0)
            {
                MessageBox.Show("Nenhum produto encontrado.", "Busca",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            DGVprodutos.DataSource = filtrados;
        }
    }
}
