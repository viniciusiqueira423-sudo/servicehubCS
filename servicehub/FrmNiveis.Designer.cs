namespace servicehub
{
    partial class FrmNiveis
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
            TXTsigla = new TextBox();
            TXTnome = new TextBox();
            TXTid = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            BTNcancelar = new Button();
            BTNexcluir = new Button();
            BTNpesquisar = new Button();
            BTNeditar = new Button();
            BTNadicionar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TXTsigla
            // 
            TXTsigla.Location = new Point(573, 131);
            TXTsigla.Name = "TXTsigla";
            TXTsigla.Size = new Size(97, 23);
            TXTsigla.TabIndex = 24;
            // 
            // TXTnome
            // 
            TXTnome.Cursor = Cursors.IBeam;
            TXTnome.Location = new Point(207, 131);
            TXTnome.Name = "TXTnome";
            TXTnome.Size = new Size(360, 23);
            TXTnome.TabIndex = 23;
            // 
            // TXTid
            // 
            TXTid.Location = new Point(101, 131);
            TXTid.Name = "TXTid";
            TXTid.ReadOnly = true;
            TXTid.Size = new Size(100, 23);
            TXTid.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(573, 113);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 25;
            label3.Text = "Sigla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(207, 113);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 26;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 113);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 27;
            label1.Text = "ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(110, 223);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(569, 215);
            dataGridView1.TabIndex = 29;
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
            BTNcancelar.Location = new Point(562, 160);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(83, 57);
            BTNcancelar.TabIndex = 34;
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
            BTNexcluir.Location = new Point(417, 160);
            BTNexcluir.Name = "BTNexcluir";
            BTNexcluir.Size = new Size(83, 57);
            BTNexcluir.TabIndex = 33;
            BTNexcluir.Text = "E&xcluir";
            BTNexcluir.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNexcluir.UseVisualStyleBackColor = false;
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
            BTNpesquisar.Location = new Point(676, 113);
            BTNpesquisar.Name = "BTNpesquisar";
            BTNpesquisar.Size = new Size(83, 57);
            BTNpesquisar.TabIndex = 32;
            BTNpesquisar.Text = "&Pesquisar";
            BTNpesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNpesquisar.UseVisualStyleBackColor = false;
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
            BTNeditar.Location = new Point(272, 160);
            BTNeditar.Name = "BTNeditar";
            BTNeditar.Size = new Size(83, 57);
            BTNeditar.TabIndex = 31;
            BTNeditar.Text = "&Editar";
            BTNeditar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNeditar.UseVisualStyleBackColor = false;
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
            BTNadicionar.Location = new Point(127, 160);
            BTNadicionar.Name = "BTNadicionar";
            BTNadicionar.Size = new Size(83, 57);
            BTNadicionar.TabIndex = 30;
            BTNadicionar.Text = "&Adicionar";
            BTNadicionar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNadicionar.UseVisualStyleBackColor = false;
            // 
            // FrmNiveis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(BTNcancelar);
            Controls.Add(BTNexcluir);
            Controls.Add(BTNpesquisar);
            Controls.Add(BTNeditar);
            Controls.Add(BTNadicionar);
            Controls.Add(dataGridView1);
            Controls.Add(TXTsigla);
            Controls.Add(TXTnome);
            Controls.Add(TXTid);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmNiveis";
            Text = "FrmNiveis";
            Load += FrmNiveis_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXTsigla;
        private TextBox TXTnome;
        private TextBox TXTid;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridView1;
        private Button BTNcancelar;
        private Button BTNexcluir;
        private Button BTNpesquisar;
        private Button BTNeditar;
        private Button BTNadicionar;
    }
}