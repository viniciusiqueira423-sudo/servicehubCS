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
        public FrmProdutos()
        {
            InitializeComponent();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CMDcategoria.DataSource = Categoria.ObterLista();
            CMDcategoria.DisplayMember = "Nome";
            CMDcategoria.ValueMember = "Id";
            DGVprodutos.DataSource = Produto.obterLista();
        }

        private void BTNsalvar_Click(object sender, EventArgs e)
        {
            Produto produto = new
                (
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
                MessageBox.Show($"Produto {produto.descricao} gravado com sucesso!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
