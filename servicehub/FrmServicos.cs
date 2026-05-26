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
    public partial class FrmServicos : Form
    {
        public FrmServicos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void FrmServicos_Load(object sender, EventArgs e)
        {
            TXTnome.Focus();
        }

        private void BTNadicionar_Click(object sender, EventArgs e)
        {
            string nome = TXTnome.Text;
            string descricao = TXTdescricao.Text;
            double preco = (double)NUDpreco.Value;

            var cmd = Banco.Abrir();
            cmd.CommandText = $"insert servicos (nome, descricao, preco)" +
                $"values('{nome}','{descricao}',{preco})";
            if (cmd.ExecuteNonQuery() > 0)
            {
                cmd.CommandText = "select last_insert_id()";
                TXTid.Text = cmd.ExecuteScalar().ToString();
                BTNadicionar.Enabled = false;
            }
        }

        private void BTNpesquisar_Click(object sender, EventArgs e)
        {
            if (BTNpesquisar.Text == "&Pesquisar")
            {
                TXTid.ReadOnly = false;
                TXTnome.ReadOnly = true;
                TXTdescricao.ReadOnly = true;
                NUDpreco.ReadOnly = true;
                checkBox1.Enabled = false;
                TXTid.Focus();
                BTNpesquisar.Text = "Buscar";
            }
            else if (BTNpesquisar.Text == "Buscar")
            {
                var cmd = Banco.Abrir();
                cmd.CommandText = $"select * from servicos where id = {TXTid.Text}";
                var dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TXTnome.Text = dr.GetString(1);
                    TXTdescricao.Text = dr.GetString(2);
                    NUDpreco.Value = dr.GetDecimal(3);
                    checkBox1.Checked = dr.GetBoolean(4);
                }
                BTNpesquisar.Text = "&Pesquisar";
                TXTid.ReadOnly = true;
            }
        }

        private void BTNeditar_Click(object sender, EventArgs e)
        {
            if(BTNeditar.Text == "&Editar")
            {
                TXTdescricao.ReadOnly=false;
                TXTnome.ReadOnly = false;
                NUDpreco.ReadOnly = false;
                checkBox1.Enabled = true;
                BTNeditar.Text = "Salvar";


            }
            else
            {
                string descont = checkBox1.Checked ? "1 ": "0";
                var cmd = Banco.Abrir();
                cmd.CommandText = $"update servicos set nome = '{TXTnome.Text}'," +
                    $"descricao = '{TXTdescricao.Text}', preco ={NUDpreco.Value}," +
                    $"descontinuado = {descont} where id = {TXTid.Text}";
                if(cmd.ExecuteNonQuery() > 0)
                {
                    BTNeditar.Text = "&Editar";
                }
            }
        }
    }
}
