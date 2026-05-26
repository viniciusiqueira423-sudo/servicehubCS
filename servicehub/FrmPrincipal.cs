namespace servicehub
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void listarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListaClientes listaClientes = new();

            //associando o form listar clientes como filho do principal
            listaClientes.MdiParent = this;
            //chamar o form clientes
            listaClientes.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmNovoCliente novoCliente = new();
            novoCliente.MdiParent = this;
            novoCliente.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}
