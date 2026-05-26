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
    public partial class FrmListaClientes : Form
    {
        public FrmListaClientes()
        {
            InitializeComponent();
        }

        private void FrmListaClientes_Load(object sender, EventArgs e)
        {
            dgvClientes.Rows.Add();
            dgvClientes.Rows[0].Cells[0].Value = 1;
            dgvClientes.Rows[0].Cells[1].Value = 1015478;
            dgvClientes.Rows[0].Cells[2].Value = "Maria da silva";
            dgvClientes.Rows[0].Cells[3].Value = 12345678909;
            dgvClientes.Rows[0].Cells[4].Value = "mariadasilva@gmail.com";
            dgvClientes.Rows[0].Cells[5].Value = "11915528586";
            dgvClientes.Rows[0].Cells[6].Value = true;



            dgvClientes.Rows.Add();
            dgvClientes.Rows[1].Cells[0].Value = 2;
            dgvClientes.Rows[1].Cells[1].Value = 1015478;
            dgvClientes.Rows[1].Cells[2].Value = "Vinicius Siqueira Caetano";
            dgvClientes.Rows[1].Cells[3].Value = 12345678969;
            dgvClientes.Rows[1].Cells[4].Value = "vinisiqueira@gmail.com";
            dgvClientes.Rows[1].Cells[5].Value = "11515528586";
            dgvClientes.Rows[1].Cells[6].Value = false;

        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            string id = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            MessageBox.Show(id);
        }
    }
}
