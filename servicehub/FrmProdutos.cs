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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void BTNsalvar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (TXTcodBarras.Text != string.Empty)
                listBox1.Items.Add($"Código de Barras: {TXTcodBarras.Text}");

            if (TXTdescricao.Text != string.Empty)
                listBox1.Items.Add($"Descrição: {TXTdescricao.Text}");

            if (TXTuniVendas.Text != string.Empty)
                listBox1.Items.Add($"Unidade de Venda: {TXTuniVendas.Text}");

            if (NudValorUnit.Value > 0)
                listBox1.Items.Add($"Valor Unitário: R$ {NudValorUnit.Value:F2}");

            if (NUDestoquemin.Value > 0)
                listBox1.Items.Add($"Estoque minimo do produto: {NUDestoquemin.Value:F3}");

            if (NUDclassedesc.Value > 0)
                listBox1.Items.Add($"Classe de desconto: R{NUDclassedesc.Value:F3}%");




            switch (CMDcategoria.SelectedIndex)
            {
                case 0:
                    listBox1.Items.Add($"Classe do Produto: {CMDcategoria.SelectedItem}");
                    break;

                case 1:
                    listBox1.Items.Add($"Classe do Produto: {CMDcategoria.SelectedItem}");
                    break;

                case 2:
                    listBox1.Items.Add($"Classe do Produto: {CMDcategoria.SelectedItem}");
                    break;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BTNpesquisar_Click(object sender, EventArgs e)
        {

        }
    }
}
