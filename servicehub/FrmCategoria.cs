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
    public partial class FrmCategoria : Form
    {
        public FrmCategoria()
        {
            InitializeComponent();
        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void BTNadicionar_Click(object sender, EventArgs e)
        {
            Categoria cat = new(TXTnome.Text, TXTsigla.Text);
            cat.Inserir();
            if (cat.Id > 0)
            {
                MessageBox.Show($"Categoria {cat.Id} inserida com sucesso!");
                CarregaGrid();
            }
        }
        private void CarregaGrid(string texto="")
        {
            DGVcategorias.Rows.Clear();

            List<Categoria> categorias = Categoria.ObterLista(texto);
            foreach (var categoria in categorias)
            {
                DGVcategorias.Rows.Add();
                DGVcategorias.Rows[DGVcategorias.Rows.Count - 1].Cells[0].Value = categoria.Id;
                DGVcategorias.Rows[DGVcategorias.Rows.Count - 1].Cells[1].Value = categoria.Nome;
                DGVcategorias.Rows[DGVcategorias.Rows.Count - 1].Cells[2].Value = categoria.Sigla;
            }
        }

        private void TXTbuscar_TextChanged(object sender, EventArgs e)
        {
            if(TXTbuscar.Text.Length > 1)
            {
                CarregaGrid(TXTbuscar.Text);
            }
        }
    }

}
