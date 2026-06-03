namespace servicehub
{
    partial class FrmCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DGVcategorias = new DataGridView();
            ClnID = new DataGridViewTextBoxColumn();
            CLNnome = new DataGridViewTextBoxColumn();
            CLNsigla = new DataGridViewTextBoxColumn();
            TXTbuscar = new TextBox();
            BTNcancelar = new Button();
            BTNexcluir = new Button();
            BTNpesquisar = new Button();
            BTNeditar = new Button();
            BTNadicionar = new Button();
            TXTsigla = new TextBox();
            TXTnome = new TextBox();
            TXTid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)DGVcategorias).BeginInit();
            SuspendLayout();
            // 
            // DGVcategorias
            // 
            DGVcategorias.AllowUserToAddRows = false;
            DGVcategorias.AllowUserToDeleteRows = false;
            DGVcategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVcategorias.Columns.AddRange(new DataGridViewColumn[] { ClnID, CLNnome, CLNsigla });
            DGVcategorias.Location = new Point(74, 298);
            DGVcategorias.Name = "DGVcategorias";
            DGVcategorias.ReadOnly = true;
            DGVcategorias.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DGVcategorias.Size = new Size(615, 211);
            DGVcategorias.TabIndex = 0;
            DGVcategorias.CellClick += DGVcategorias_CellClick;
            DGVcategorias.CellContentClick += DGVcategorias_CellContentClick;
            DGVcategorias.SelectionChanged += DGVcategorias_SelectionChanged;
            // 
            // ClnID
            // 
            ClnID.HeaderText = "ID";
            ClnID.Name = "ClnID";
            ClnID.ReadOnly = true;
            // 
            // CLNnome
            // 
            CLNnome.HeaderText = "Nome";
            CLNnome.Name = "CLNnome";
            CLNnome.ReadOnly = true;
            CLNnome.Width = 370;
            // 
            // CLNsigla
            // 
            CLNsigla.HeaderText = "Sigla";
            CLNsigla.Name = "CLNsigla";
            CLNsigla.ReadOnly = true;
            // 
            // TXTbuscar
            // 
            TXTbuscar.Location = new Point(74, 260);
            TXTbuscar.Name = "TXTbuscar";
            TXTbuscar.PlaceholderText = "Buscar Categoria";
            TXTbuscar.Size = new Size(615, 23);
            TXTbuscar.TabIndex = 7;
            TXTbuscar.TextChanged += TXTbuscar_TextChanged;
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
            BTNcancelar.Location = new Point(553, 197);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(83, 57);
            BTNcancelar.TabIndex = 16;
            BTNcancelar.Text = "&Cancelar";
            BTNcancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNcancelar.UseVisualStyleBackColor = false;
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
            BTNexcluir.Location = new Point(440, 197);
            BTNexcluir.Name = "BTNexcluir";
            BTNexcluir.Size = new Size(83, 57);
            BTNexcluir.TabIndex = 15;
            BTNexcluir.Text = "E&xcluir";
            BTNexcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNexcluir.UseVisualStyleBackColor = false;
            BTNexcluir.Click += BTNexcluir_Click;
            // 
            // BTNpesquisar
            // 
            BTNpesquisar.BackColor = SystemColors.Control;
            BTNpesquisar.FlatAppearance.BorderSize = 0;
            BTNpesquisar.FlatAppearance.MouseDownBackColor = Color.FromArgb(0, 192, 192);
            BTNpesquisar.FlatAppearance.MouseOverBackColor = Color.LightBlue;
            BTNpesquisar.FlatStyle = FlatStyle.Flat;
            BTNpesquisar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            BTNpesquisar.ForeColor = Color.SteelBlue;
            BTNpesquisar.Image = Properties.Resources.Search;
            BTNpesquisar.Location = new Point(327, 197);
            BTNpesquisar.Name = "BTNpesquisar";
            BTNpesquisar.Size = new Size(83, 57);
            BTNpesquisar.TabIndex = 14;
            BTNpesquisar.Text = "&Pesquisar";
            BTNpesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNpesquisar.UseVisualStyleBackColor = false;
            BTNpesquisar.Click += BTNpesquisar_Click;
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
            BTNeditar.Location = new Point(215, 197);
            BTNeditar.Name = "BTNeditar";
            BTNeditar.Size = new Size(83, 57);
            BTNeditar.TabIndex = 13;
            BTNeditar.Text = "&Editar";
            BTNeditar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNeditar.UseVisualStyleBackColor = false;
            BTNeditar.Click += BTNeditar_Click;
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
            BTNadicionar.Location = new Point(103, 197);
            BTNadicionar.Name = "BTNadicionar";
            BTNadicionar.Size = new Size(83, 57);
            BTNadicionar.TabIndex = 12;
            BTNadicionar.Text = "&Adicionar";
            BTNadicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNadicionar.UseVisualStyleBackColor = false;
            BTNadicionar.Click += BTNadicionar_Click;
            // 
            // TXTsigla
            // 
            TXTsigla.Location = new Point(561, 155);
            TXTsigla.Name = "TXTsigla";
            TXTsigla.Size = new Size(97, 23);
            TXTsigla.TabIndex = 18;
            // 
            // TXTnome
            // 
            TXTnome.Cursor = Cursors.IBeam;
            TXTnome.Location = new Point(195, 155);
            TXTnome.Name = "TXTnome";
            TXTnome.Size = new Size(360, 23);
            TXTnome.TabIndex = 17;
            // 
            // TXTid
            // 
            TXTid.Location = new Point(89, 155);
            TXTid.Name = "TXTid";
            TXTid.ReadOnly = true;
            TXTid.Size = new Size(100, 23);
            TXTid.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(561, 137);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 19;
            label3.Text = "Sigla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(195, 137);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 20;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(89, 137);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 21;
            label1.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(220, 9);
            label4.Name = "label4";
            label4.Size = new Size(303, 40);
            label4.TabIndex = 23;
            label4.Text = "Cadastro de Categoria";
            // 
            // FrmCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(764, 521);
            Controls.Add(label4);
            Controls.Add(TXTsigla);
            Controls.Add(TXTnome);
            Controls.Add(TXTid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BTNcancelar);
            Controls.Add(BTNexcluir);
            Controls.Add(BTNpesquisar);
            Controls.Add(BTNeditar);
            Controls.Add(BTNadicionar);
            Controls.Add(TXTbuscar);
            Controls.Add(DGVcategorias);
            Name = "FrmCategoria";
            Text = "FrmCategoria";
            Load += FrmCategoria_Load;
            ((System.ComponentModel.ISupportInitialize)DGVcategorias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView DGVcategorias;
        private TextBox TXTbuscar;
        private Button BTNcancelar;
        private Button BTNexcluir;
        private Button BTNpesquisar;
        private Button BTNeditar;
        private Button BTNadicionar;
        private TextBox TXTsigla;
        private TextBox TXTnome;
        private TextBox TXTid;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private DataGridViewTextBoxColumn ClnID;
        private DataGridViewTextBoxColumn CLNnome;
        private DataGridViewTextBoxColumn CLNsigla;
    }
}