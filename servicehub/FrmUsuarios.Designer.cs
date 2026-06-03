namespace servicehub
{
    partial class FrmUsuarios
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.Label lblSenha;

        private System.Windows.Forms.TextBox TXTid;
        private System.Windows.Forms.TextBox TXTnome;
        private System.Windows.Forms.TextBox TXTemail;
        private System.Windows.Forms.TextBox TXTsenha;

        private System.Windows.Forms.CheckBox CHKativo;

        private System.Windows.Forms.DataGridView dgvUsuarios;

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
            lblEmail = new Label();
            lblNivel = new Label();
            lblSenha = new Label();
            TXTid = new TextBox();
            TXTnome = new TextBox();
            TXTemail = new TextBox();
            TXTsenha = new TextBox();
            CHKativo = new CheckBox();
            dgvUsuarios = new DataGridView();
            CLNid = new DataGridViewTextBoxColumn();
            CLNnome = new DataGridViewTextBoxColumn();
            CLNemail = new DataGridViewTextBoxColumn();
            CLNSsenha = new DataGridViewTextBoxColumn();
            CLNnivel = new DataGridViewTextBoxColumn();
            CLNativo = new DataGridViewCheckBoxColumn();
            BTNcancelar = new Button();
            TXTbuscar = new TextBox();
            BTNadicionar = new Button();
            BTNeditar = new Button();
            NUDnivel = new NumericUpDown();
            BTNexcluir = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDnivel).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(20, 53);
            lblId.Name = "lblId";
            lblId.Size = new Size(18, 15);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(156, 53);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(40, 15);
            lblNome.TabIndex = 2;
            lblNome.Text = "Nome";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.Location = new Point(426, 53);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(36, 15);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblNivel
            // 
            lblNivel.AutoSize = true;
            lblNivel.Location = new Point(20, 156);
            lblNivel.Name = "lblNivel";
            lblNivel.Size = new Size(34, 15);
            lblNivel.TabIndex = 6;
            lblNivel.Text = "Nível";
            // 
            // lblSenha
            // 
            lblSenha.AutoSize = true;
            lblSenha.Location = new Point(218, 156);
            lblSenha.Name = "lblSenha";
            lblSenha.Size = new Size(39, 15);
            lblSenha.TabIndex = 8;
            lblSenha.Text = "Senha";
            // 
            // TXTid
            // 
            TXTid.BorderStyle = BorderStyle.FixedSingle;
            TXTid.Enabled = false;
            TXTid.Location = new Point(20, 71);
            TXTid.Name = "TXTid";
            TXTid.Size = new Size(80, 23);
            TXTid.TabIndex = 1;
            // 
            // TXTnome
            // 
            TXTnome.Location = new Point(156, 71);
            TXTnome.Name = "TXTnome";
            TXTnome.Size = new Size(242, 23);
            TXTnome.TabIndex = 3;
            // 
            // TXTemail
            // 
            TXTemail.Location = new Point(426, 71);
            TXTemail.Name = "TXTemail";
            TXTemail.Size = new Size(250, 23);
            TXTemail.TabIndex = 5;
            // 
            // TXTsenha
            // 
            TXTsenha.Location = new Point(218, 174);
            TXTsenha.Name = "TXTsenha";
            TXTsenha.PasswordChar = '*';
            TXTsenha.Size = new Size(180, 23);
            TXTsenha.TabIndex = 9;
            // 
            // CHKativo
            // 
            CHKativo.AutoSize = true;
            CHKativo.Location = new Point(426, 156);
            CHKativo.Name = "CHKativo";
            CHKativo.Size = new Size(97, 19);
            CHKativo.TabIndex = 10;
            CHKativo.Text = "Usuário Ativo";
            // 
            // dgvUsuarios
            // 
            dgvUsuarios.AllowUserToAddRows = false;
            dgvUsuarios.AllowUserToDeleteRows = false;
            dgvUsuarios.Columns.AddRange(new DataGridViewColumn[] { CLNid, CLNnome, CLNemail, CLNSsenha, CLNnivel, CLNativo });
            dgvUsuarios.Location = new Point(20, 328);
            dgvUsuarios.Name = "dgvUsuarios";
            dgvUsuarios.ReadOnly = true;
            dgvUsuarios.RowHeadersVisible = false;
            dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsuarios.Size = new Size(823, 217);
            dgvUsuarios.TabIndex = 14;
            dgvUsuarios.CellClick += dgvUsuarios_CellClick;
            // 
            // CLNid
            // 
            CLNid.HeaderText = "ID";
            CLNid.Name = "CLNid";
            CLNid.ReadOnly = true;
            CLNid.Width = 50;
            // 
            // CLNnome
            // 
            CLNnome.HeaderText = "Nome";
            CLNnome.Name = "CLNnome";
            CLNnome.ReadOnly = true;
            CLNnome.Width = 200;
            // 
            // CLNemail
            // 
            CLNemail.HeaderText = "Email";
            CLNemail.Name = "CLNemail";
            CLNemail.ReadOnly = true;
            CLNemail.Width = 250;
            // 
            // CLNSsenha
            // 
            CLNSsenha.HeaderText = "Senha";
            CLNSsenha.Name = "CLNSsenha";
            CLNSsenha.ReadOnly = true;
            CLNSsenha.Width = 150;
            // 
            // CLNnivel
            // 
            CLNnivel.HeaderText = "Nivel";
            CLNnivel.Name = "CLNnivel";
            CLNnivel.ReadOnly = true;
            // 
            // CLNativo
            // 
            CLNativo.HeaderText = "Ativo";
            CLNativo.Name = "CLNativo";
            CLNativo.ReadOnly = true;
            CLNativo.Resizable = DataGridViewTriState.True;
            CLNativo.SortMode = DataGridViewColumnSortMode.Automatic;
            CLNativo.Width = 50;
            // 
            // BTNcancelar
            // 
            BTNcancelar.BackColor = SystemColors.Control;
            BTNcancelar.FlatAppearance.BorderSize = 0;
            BTNcancelar.FlatAppearance.MouseDownBackColor = Color.OrangeRed;
            BTNcancelar.FlatAppearance.MouseOverBackColor = Color.Salmon;
            BTNcancelar.FlatStyle = FlatStyle.Flat;
            BTNcancelar.Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BTNcancelar.ForeColor = Color.Red;
            BTNcancelar.Image = Properties.Resources.Cancel;
            BTNcancelar.Location = new Point(333, 236);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(83, 57);
            BTNcancelar.TabIndex = 21;
            BTNcancelar.Text = "&Cancelar";
            BTNcancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNcancelar.UseVisualStyleBackColor = false;
            BTNcancelar.Click += BTNcancelar_Click;
            // 
            // TXTbuscar
            // 
            TXTbuscar.Location = new Point(20, 299);
            TXTbuscar.Name = "TXTbuscar";
            TXTbuscar.PlaceholderText = "Buscar Usuario";
            TXTbuscar.Size = new Size(823, 23);
            TXTbuscar.TabIndex = 22;
            TXTbuscar.TextChanged += TXTbuscar_TextChanged;
            // 
            // BTNadicionar
            // 
            BTNadicionar.BackColor = SystemColors.Control;
            BTNadicionar.FlatAppearance.BorderSize = 0;
            BTNadicionar.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            BTNadicionar.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            BTNadicionar.FlatStyle = FlatStyle.Flat;
            BTNadicionar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            BTNadicionar.ForeColor = Color.ForestGreen;
            BTNadicionar.Image = Properties.Resources.Add1;
            BTNadicionar.Location = new Point(24, 236);
            BTNadicionar.Name = "BTNadicionar";
            BTNadicionar.Size = new Size(83, 57);
            BTNadicionar.TabIndex = 17;
            BTNadicionar.Text = "&Adicionar";
            BTNadicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNadicionar.UseVisualStyleBackColor = false;
            BTNadicionar.Click += BTNadicionar_Click;
            // 
            // BTNeditar
            // 
            BTNeditar.BackColor = SystemColors.Control;
            BTNeditar.FlatAppearance.BorderSize = 0;
            BTNeditar.FlatAppearance.MouseDownBackColor = Color.Gold;
            BTNeditar.FlatAppearance.MouseOverBackColor = Color.Khaki;
            BTNeditar.FlatStyle = FlatStyle.Flat;
            BTNeditar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            BTNeditar.ForeColor = Color.Goldenrod;
            BTNeditar.Image = Properties.Resources.Edit;
            BTNeditar.Location = new Point(128, 236);
            BTNeditar.Name = "BTNeditar";
            BTNeditar.Size = new Size(83, 57);
            BTNeditar.TabIndex = 18;
            BTNeditar.Text = "&Editar";
            BTNeditar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNeditar.UseVisualStyleBackColor = false;
            BTNeditar.Click += BTNeditar_Click;
            // 
            // NUDnivel
            // 
            NUDnivel.Location = new Point(20, 174);
            NUDnivel.Name = "NUDnivel";
            NUDnivel.Size = new Size(120, 23);
            NUDnivel.TabIndex = 23;
            // 
            // BTNexcluir
            // 
            BTNexcluir.BackColor = SystemColors.Control;
            BTNexcluir.FlatAppearance.BorderSize = 0;
            BTNexcluir.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            BTNexcluir.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 192, 192);
            BTNexcluir.FlatStyle = FlatStyle.Flat;
            BTNexcluir.Font = new Font("Verdana", 9F, FontStyle.Bold);
            BTNexcluir.ForeColor = Color.Brown;
            BTNexcluir.Image = Properties.Resources.Delete;
            BTNexcluir.Location = new Point(231, 236);
            BTNexcluir.Name = "BTNexcluir";
            BTNexcluir.Size = new Size(83, 57);
            BTNexcluir.TabIndex = 24;
            BTNexcluir.Text = "E&xcluir";
            BTNexcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNexcluir.UseVisualStyleBackColor = false;
            BTNexcluir.Click += BTNexcluir_Click;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 600);
            Controls.Add(BTNexcluir);
            Controls.Add(NUDnivel);
            Controls.Add(TXTbuscar);
            Controls.Add(BTNcancelar);
            Controls.Add(BTNeditar);
            Controls.Add(BTNadicionar);
            Controls.Add(lblId);
            Controls.Add(TXTid);
            Controls.Add(lblNome);
            Controls.Add(TXTnome);
            Controls.Add(lblEmail);
            Controls.Add(TXTemail);
            Controls.Add(lblNivel);
            Controls.Add(lblSenha);
            Controls.Add(TXTsenha);
            Controls.Add(CHKativo);
            Controls.Add(dgvUsuarios);
            Name = "FrmUsuarios";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Usuários";
            Load += FrmUsuarios_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgvUsuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDnivel).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private Button BTNcancelar;
        private TextBox TXTbuscar;
        private Button BTNadicionar;
        private Button BTNeditar;
        private NumericUpDown NUDnivel;
        private DataGridViewTextBoxColumn CLNid;
        private DataGridViewTextBoxColumn CLNnome;
        private DataGridViewTextBoxColumn CLNemail;
        private DataGridViewTextBoxColumn CLNSsenha;
        private DataGridViewTextBoxColumn CLNnivel;
        private DataGridViewCheckBoxColumn CLNativo;
        private Button BTNexcluir;
    }
}