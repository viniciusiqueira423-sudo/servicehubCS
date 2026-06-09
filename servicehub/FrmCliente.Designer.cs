namespace servicehub
{
    partial class FrmCliente
    {
        private System.ComponentModel.IContainer components = null;

        private Label lblId;
        private Label lblNome;
        private Label lblCpf;
        private Label lblEmail;
        private Label lblTelefone;
        private Label lblNascimento;
        private Label lblCadastro;

        private TextBox TXTid;
        private TextBox TXTnome;
        private TextBox TXTcpf;
        private TextBox TXTemail;
        private TextBox TXTtelefone;
        private TextBox TXTbuscar;

        private DateTimePicker DTPnascimento;
        private DateTimePicker DTPcadastro;

        private CheckBox CHKativo;

        private DataGridView DGVclientes;

        private Button BTNadicionar;
        private Button BTNeditar;
        private Button BTNexcluir;
        private Button BTNcancelar;
        private Button BTNpesquisar;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblId = new Label();
            lblNome = new Label();
            lblCpf = new Label();
            lblEmail = new Label();
            lblTelefone = new Label();
            lblNascimento = new Label();
            lblCadastro = new Label();
            TXTid = new TextBox();
            TXTnome = new TextBox();
            TXTcpf = new TextBox();
            TXTemail = new TextBox();
            TXTtelefone = new TextBox();
            TXTbuscar = new TextBox();
            DTPnascimento = new DateTimePicker();
            DTPcadastro = new DateTimePicker();
            CHKativo = new CheckBox();
            BTNadicionar = new Button();
            BTNeditar = new Button();
            BTNexcluir = new Button();
            BTNcancelar = new Button();
            BTNpesquisar = new Button();
            DGVclientes = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn7 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn8 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)DGVclientes).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.Location = new Point(20, 20);
            lblId.Name = "lblId";
            lblId.Size = new Size(100, 23);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.Location = new Point(20, 60);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(100, 23);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome";
            // 
            // lblCpf
            // 
            lblCpf.Location = new Point(20, 100);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(100, 23);
            lblCpf.TabIndex = 2;
            lblCpf.Text = "CPF";
            // 
            // lblEmail
            // 
            lblEmail.Location = new Point(20, 140);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(100, 23);
            lblEmail.TabIndex = 3;
            lblEmail.Text = "Email";
            // 
            // lblTelefone
            // 
            lblTelefone.Location = new Point(20, 180);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(100, 23);
            lblTelefone.TabIndex = 4;
            lblTelefone.Text = "Telefone";
            // 
            // lblNascimento
            // 
            lblNascimento.Location = new Point(20, 220);
            lblNascimento.Name = "lblNascimento";
            lblNascimento.Size = new Size(100, 23);
            lblNascimento.TabIndex = 5;
            lblNascimento.Text = "Nascimento";
            // 
            // lblCadastro
            // 
            lblCadastro.Location = new Point(20, 260);
            lblCadastro.Name = "lblCadastro";
            lblCadastro.Size = new Size(100, 23);
            lblCadastro.TabIndex = 6;
            lblCadastro.Text = "Cadastro";
            // 
            // TXTid
            // 
            TXTid.Enabled = false;
            TXTid.Location = new Point(120, 20);
            TXTid.Name = "TXTid";
            TXTid.Size = new Size(100, 23);
            TXTid.TabIndex = 7;
            // 
            // TXTnome
            // 
            TXTnome.Location = new Point(120, 60);
            TXTnome.Name = "TXTnome";
            TXTnome.Size = new Size(300, 23);
            TXTnome.TabIndex = 8;
            // 
            // TXTcpf
            // 
            TXTcpf.Location = new Point(120, 100);
            TXTcpf.Name = "TXTcpf";
            TXTcpf.Size = new Size(180, 23);
            TXTcpf.TabIndex = 9;
            // 
            // TXTemail
            // 
            TXTemail.Location = new Point(120, 140);
            TXTemail.Name = "TXTemail";
            TXTemail.Size = new Size(300, 23);
            TXTemail.TabIndex = 10;
            // 
            // TXTtelefone
            // 
            TXTtelefone.Location = new Point(120, 180);
            TXTtelefone.Name = "TXTtelefone";
            TXTtelefone.Size = new Size(180, 23);
            TXTtelefone.TabIndex = 11;
            // 
            // TXTbuscar
            // 
            TXTbuscar.Location = new Point(20, 360);
            TXTbuscar.Name = "TXTbuscar";
            TXTbuscar.PlaceholderText = "Buscar Cliente";
            TXTbuscar.Size = new Size(700, 23);
            TXTbuscar.TabIndex = 12;
            // 
            // DTPnascimento
            // 
            DTPnascimento.Format = DateTimePickerFormat.Short;
            DTPnascimento.Location = new Point(120, 220);
            DTPnascimento.Name = "DTPnascimento";
            DTPnascimento.Size = new Size(200, 23);
            DTPnascimento.TabIndex = 13;
            // 
            // DTPcadastro
            // 
            DTPcadastro.Format = DateTimePickerFormat.Short;
            DTPcadastro.Location = new Point(120, 260);
            DTPcadastro.Name = "DTPcadastro";
            DTPcadastro.Size = new Size(200, 23);
            DTPcadastro.TabIndex = 14;
            // 
            // CHKativo
            // 
            CHKativo.Location = new Point(120, 300);
            CHKativo.Name = "CHKativo";
            CHKativo.Size = new Size(104, 24);
            CHKativo.TabIndex = 15;
            CHKativo.Text = "Cliente Ativo";
            // 
            // BTNadicionar
            // 
            BTNadicionar.Location = new Point(20, 320);
            BTNadicionar.Name = "BTNadicionar";
            BTNadicionar.Size = new Size(90, 35);
            BTNadicionar.TabIndex = 16;
            BTNadicionar.Text = "Adicionar";
            // 
            // BTNeditar
            // 
            BTNeditar.Location = new Point(120, 320);
            BTNeditar.Name = "BTNeditar";
            BTNeditar.Size = new Size(90, 35);
            BTNeditar.TabIndex = 17;
            BTNeditar.Text = "Editar";
            // 
            // BTNexcluir
            // 
            BTNexcluir.Location = new Point(220, 320);
            BTNexcluir.Name = "BTNexcluir";
            BTNexcluir.Size = new Size(90, 35);
            BTNexcluir.TabIndex = 18;
            BTNexcluir.Text = "Excluir";
            // 
            // BTNcancelar
            // 
            BTNcancelar.Location = new Point(320, 320);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(90, 35);
            BTNcancelar.TabIndex = 19;
            BTNcancelar.Text = "Cancelar";
            // 
            // BTNpesquisar
            // 
            BTNpesquisar.Location = new Point(730, 360);
            BTNpesquisar.Name = "BTNpesquisar";
            BTNpesquisar.Size = new Size(100, 25);
            BTNpesquisar.TabIndex = 20;
            BTNpesquisar.Text = "Pesquisar";
            // 
            // DGVclientes
            // 
            DGVclientes.AllowUserToAddRows = false;
            DGVclientes.AllowUserToDeleteRows = false;
            DGVclientes.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, dataGridViewTextBoxColumn7, dataGridViewTextBoxColumn8 });
            DGVclientes.Location = new Point(20, 400);
            DGVclientes.MultiSelect = false;
            DGVclientes.Name = "DGVclientes";
            DGVclientes.ReadOnly = true;
            DGVclientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVclientes.Size = new Size(950, 250);
            DGVclientes.TabIndex = 21;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Nome";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "CPF";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Email";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Telefone";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Nascimento";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewTextBoxColumn7.HeaderText = "Cadastro";
            dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            dataGridViewTextBoxColumn8.HeaderText = "Ativo";
            dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // FrmCliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 700);
            Controls.Add(lblId);
            Controls.Add(lblNome);
            Controls.Add(lblCpf);
            Controls.Add(lblEmail);
            Controls.Add(lblTelefone);
            Controls.Add(lblNascimento);
            Controls.Add(lblCadastro);
            Controls.Add(TXTid);
            Controls.Add(TXTnome);
            Controls.Add(TXTcpf);
            Controls.Add(TXTemail);
            Controls.Add(TXTtelefone);
            Controls.Add(TXTbuscar);
            Controls.Add(DTPnascimento);
            Controls.Add(DTPcadastro);
            Controls.Add(CHKativo);
            Controls.Add(BTNadicionar);
            Controls.Add(BTNeditar);
            Controls.Add(BTNexcluir);
            Controls.Add(BTNcancelar);
            Controls.Add(BTNpesquisar);
            Controls.Add(DGVclientes);
            Name = "FrmCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Clientes";
            Load += FrmCliente_Load;
            ((System.ComponentModel.ISupportInitialize)DGVclientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}