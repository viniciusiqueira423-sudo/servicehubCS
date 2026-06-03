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
        private void CarregaGrid(string texto = "")
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
            if (TXTbuscar.Text.Length > 1)
            {
                CarregaGrid(TXTbuscar.Text);
            }
        }



        private void BTNeditar_Click(object sender, EventArgs e)
        {
            Categoria cat = new(int.Parse(TXTid.Text), TXTnome.Text, TXTsigla.Text);
            if (cat.Atualizar())
            {
                TXTid.Clear();
                TXTnome.Clear();
                TXTsigla.Clear();
                CarregaGrid();
                MessageBox.Show($"Categoria {cat.Id} alterada com sucesso! \n Lista Atualizada");
            }
        }

        private void BTNexcluir_Click(object sender, EventArgs e)
        {
            if (TXTid.Text != string.Empty)
            {
                var resposta = MessageBox.Show(
                    $"Deseja excluir a categoria {TXTid.Text}-{TXTnome.Text}?",
                    "Exclusão de Categoria",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2

                    );
                if (resposta == DialogResult.Yes)
                {
                    Categoria cat = new(int.Parse(TXTid.Text));
                    cat.Excluir();
                    CarregaGrid();
                }


            }
        }

        private void DGVcategorias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TXTid.Text = DGVcategorias.Rows[e.RowIndex].Cells[0].Value.ToString();
            TXTnome.Text = DGVcategorias.Rows[e.RowIndex].Cells[1].Value.ToString();
            TXTsigla.Text = DGVcategorias.Rows[e.RowIndex].Cells[2].Value.ToString();
        }
        private void DGVcategorias_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVcategorias.CurrentRow != null)
            {
                TXTid.Text = DGVcategorias.CurrentRow.Cells[0].Value?.ToString() ?? "";
                TXTnome.Text = DGVcategorias.CurrentRow.Cells[1].Value?.ToString() ?? "";
                TXTsigla.Text = DGVcategorias.CurrentRow.Cells[2].Value?.ToString() ?? "";
            }
        }

        private void DGVcategorias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BTNpesquisar_Click(object sender, EventArgs e)
        {

        }
    }

}
