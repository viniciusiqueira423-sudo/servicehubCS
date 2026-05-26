namespace servicehub
{
    partial class FrmServicos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmServicos));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            checkBox1 = new CheckBox();
            TXTid = new TextBox();
            TXTnome = new TextBox();
            TXTdescricao = new TextBox();
            NUDpreco = new NumericUpDown();
            BTNadicionar = new Button();
            BTNeditar = new Button();
            BTNpesquisar = new Button();
            BTNexcluir = new Button();
            BTNcancelar = new Button();
            ((System.ComponentModel.ISupportInitialize)NUDpreco).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(58, 24);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 12;
            label1.Text = "ID";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 77);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 5;
            label2.Text = "Nome";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 130);
            label3.Name = "label3";
            label3.Size = new Size(58, 15);
            label3.TabIndex = 4;
            label3.Text = "Descrição";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 183);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 3;
            label4.Text = "Preço";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(394, 182);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(106, 19);
            checkBox1.TabIndex = 6;
            checkBox1.Text = "Descontinuado";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // TXTid
            // 
            TXTid.Location = new Point(82, 21);
            TXTid.Name = "TXTid";
            TXTid.ReadOnly = true;
            TXTid.Size = new Size(100, 23);
            TXTid.TabIndex = 13;
            // 
            // TXTnome
            // 
            TXTnome.Cursor = Cursors.IBeam;
            TXTnome.Location = new Point(82, 75);
            TXTnome.Name = "TXTnome";
            TXTnome.Size = new Size(264, 23);
            TXTnome.TabIndex = 0;
            // 
            // TXTdescricao
            // 
            TXTdescricao.Location = new Point(82, 129);
            TXTdescricao.Name = "TXTdescricao";
            TXTdescricao.Size = new Size(418, 23);
            TXTdescricao.TabIndex = 1;
            // 
            // NUDpreco
            // 
            NUDpreco.DecimalPlaces = 1;
            NUDpreco.Location = new Point(82, 183);
            NUDpreco.Name = "NUDpreco";
            NUDpreco.Size = new Size(120, 23);
            NUDpreco.TabIndex = 2;
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
            BTNadicionar.Location = new Point(36, 245);
            BTNadicionar.Name = "BTNadicionar";
            BTNadicionar.Size = new Size(83, 57);
            BTNadicionar.TabIndex = 7;
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
            BTNeditar.Location = new Point(148, 245);
            BTNeditar.Name = "BTNeditar";
            BTNeditar.Size = new Size(83, 57);
            BTNeditar.TabIndex = 8;
            BTNeditar.Text = "&Editar";
            BTNeditar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNeditar.UseVisualStyleBackColor = false;
            BTNeditar.Click += BTNeditar_Click;
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
            BTNpesquisar.Location = new Point(260, 245);
            BTNpesquisar.Name = "BTNpesquisar";
            BTNpesquisar.Size = new Size(83, 57);
            BTNpesquisar.TabIndex = 9;
            BTNpesquisar.Text = "&Pesquisar";
            BTNpesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNpesquisar.UseVisualStyleBackColor = false;
            BTNpesquisar.Click += BTNpesquisar_Click;
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
            BTNexcluir.Location = new Point(373, 245);
            BTNexcluir.Name = "BTNexcluir";
            BTNexcluir.Size = new Size(83, 57);
            BTNexcluir.TabIndex = 10;
            BTNexcluir.Text = "E&xcluir";
            BTNexcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNexcluir.UseVisualStyleBackColor = false;
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
            BTNcancelar.Location = new Point(486, 245);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(83, 57);
            BTNcancelar.TabIndex = 11;
            BTNcancelar.Text = "&Cancelar";
            BTNcancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNcancelar.UseVisualStyleBackColor = false;
            BTNcancelar.Click += button1_Click;
            // 
            // FrmServicos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 450);
            Controls.Add(BTNcancelar);
            Controls.Add(BTNexcluir);
            Controls.Add(BTNpesquisar);
            Controls.Add(BTNeditar);
            Controls.Add(BTNadicionar);
            Controls.Add(NUDpreco);
            Controls.Add(TXTdescricao);
            Controls.Add(TXTnome);
            Controls.Add(TXTid);
            Controls.Add(checkBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmServicos";
            Text = "service hub servicos";
            Load += FrmServicos_Load;
            ((System.ComponentModel.ISupportInitialize)NUDpreco).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private CheckBox checkBox1;
        private TextBox TXTid;
        private TextBox TXTnome;
        private TextBox TXTdescricao;
        private NumericUpDown NUDpreco;
        private Button BTNadicionar;
        private Button BTNeditar;
        private Button BTNpesquisar;
        private Button BTNexcluir;
        private Button BTNcancelar;
    }
}