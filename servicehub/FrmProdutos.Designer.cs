namespace servicehub
{
    partial class FrmProdutos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProdutos));
            TXTcodBarras = new TextBox();
            TXTdescricao = new TextBox();
            CMDcategoria = new ComboBox();
            NudValorUnit = new NumericUpDown();
            NUDestoquemin = new NumericUpDown();
            TXTuniVendas = new TextBox();
            NUDclassedesc = new NumericUpDown();
            BTNcarregarimg = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            PICimagem = new PictureBox();
            CHKdescontinuado = new CheckBox();
            listBox1 = new ListBox();
            BTNcancelar = new Button();
            BTNpesquisar = new Button();
            button2 = new Button();
            BTNsalvar = new Button();
            ((System.ComponentModel.ISupportInitialize)NudValorUnit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDestoquemin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDclassedesc).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PICimagem).BeginInit();
            SuspendLayout();
            // 
            // TXTcodBarras
            // 
            TXTcodBarras.Location = new Point(108, 34);
            TXTcodBarras.Name = "TXTcodBarras";
            TXTcodBarras.PlaceholderText = "Código de Barras";
            TXTcodBarras.Size = new Size(282, 23);
            TXTcodBarras.TabIndex = 0;
            // 
            // TXTdescricao
            // 
            TXTdescricao.Location = new Point(108, 63);
            TXTdescricao.Name = "TXTdescricao";
            TXTdescricao.PlaceholderText = "Descrição";
            TXTdescricao.Size = new Size(489, 23);
            TXTdescricao.TabIndex = 1;
            // 
            // CMDcategoria
            // 
            CMDcategoria.FormattingEnabled = true;
            CMDcategoria.Items.AddRange(new object[] { "amortecedores", "arcondicionados", "motores" });
            CMDcategoria.Location = new Point(105, 124);
            CMDcategoria.Name = "CMDcategoria";
            CMDcategoria.Size = new Size(490, 23);
            CMDcategoria.TabIndex = 4;
            // 
            // NudValorUnit
            // 
            NudValorUnit.DecimalPlaces = 2;
            NudValorUnit.Location = new Point(105, 92);
            NudValorUnit.Name = "NudValorUnit";
            NudValorUnit.Size = new Size(120, 23);
            NudValorUnit.TabIndex = 5;
            // 
            // NUDestoquemin
            // 
            NUDestoquemin.DecimalPlaces = 3;
            NUDestoquemin.Location = new Point(141, 161);
            NUDestoquemin.Name = "NUDestoquemin";
            NUDestoquemin.Size = new Size(120, 23);
            NUDestoquemin.TabIndex = 6;
            // 
            // TXTuniVendas
            // 
            TXTuniVendas.Location = new Point(380, 92);
            TXTuniVendas.Name = "TXTuniVendas";
            TXTuniVendas.PlaceholderText = "Unid. Vendas";
            TXTuniVendas.Size = new Size(217, 23);
            TXTuniVendas.TabIndex = 7;
            // 
            // NUDclassedesc
            // 
            NUDclassedesc.DecimalPlaces = 3;
            NUDclassedesc.Location = new Point(416, 163);
            NUDclassedesc.Name = "NUDclassedesc";
            NUDclassedesc.Size = new Size(120, 23);
            NUDclassedesc.TabIndex = 8;
            // 
            // BTNcarregarimg
            // 
            BTNcarregarimg.Location = new Point(622, 175);
            BTNcarregarimg.Name = "BTNcarregarimg";
            BTNcarregarimg.Size = new Size(166, 32);
            BTNcarregarimg.TabIndex = 13;
            BTNcarregarimg.Text = "C&arregar Imagem";
            BTNcarregarimg.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 14;
            label1.Text = "CodBarras";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(41, 66);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 15;
            label2.Text = "Descrição";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 94);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 16;
            label3.Text = "Preço";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(288, 94);
            label4.Name = "label4";
            label4.Size = new Size(86, 15);
            label4.TabIndex = 17;
            label4.Text = "Unidade Venda";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 124);
            label5.Name = "label5";
            label5.Size = new Size(58, 15);
            label5.TabIndex = 18;
            label5.Text = "Categoria";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(301, 163);
            label6.Name = "label6";
            label6.Size = new Size(109, 15);
            label6.TabIndex = 19;
            label6.Text = "Classe de Desconto";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 163);
            label7.Name = "label7";
            label7.Size = new Size(94, 15);
            label7.TabIndex = 20;
            label7.Text = "Estoque minimo";
            label7.Click += label7_Click;
            // 
            // PICimagem
            // 
            PICimagem.Location = new Point(622, 12);
            PICimagem.Name = "PICimagem";
            PICimagem.Size = new Size(155, 145);
            PICimagem.TabIndex = 23;
            PICimagem.TabStop = false;
            // 
            // CHKdescontinuado
            // 
            CHKdescontinuado.AutoSize = true;
            CHKdescontinuado.Checked = true;
            CHKdescontinuado.CheckState = CheckState.Indeterminate;
            CHKdescontinuado.Location = new Point(365, 203);
            CHKdescontinuado.Name = "CHKdescontinuado";
            CHKdescontinuado.Size = new Size(106, 19);
            CHKdescontinuado.TabIndex = 24;
            CHKdescontinuado.Text = "Descontinuado";
            CHKdescontinuado.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(806, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(249, 274);
            listBox1.TabIndex = 25;
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
            BTNcancelar.Location = new Point(622, 233);
            BTNcancelar.Name = "BTNcancelar";
            BTNcancelar.Size = new Size(83, 57);
            BTNcancelar.TabIndex = 30;
            BTNcancelar.Text = "&Cancelar";
            BTNcancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNcancelar.UseVisualStyleBackColor = false;
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
            BTNpesquisar.Location = new Point(516, 5);
            BTNpesquisar.Name = "BTNpesquisar";
            BTNpesquisar.Size = new Size(81, 52);
            BTNpesquisar.TabIndex = 28;
            BTNpesquisar.Text = "&Buscar";
            BTNpesquisar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNpesquisar.UseVisualStyleBackColor = false;
            BTNpesquisar.Click += BTNpesquisar_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.Control;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.Gold;
            button2.FlatAppearance.MouseOverBackColor = Color.Khaki;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Verdana", 9F, FontStyle.Bold);
            button2.ForeColor = Color.Goldenrod;
            button2.Image = Properties.Resources.Edit;
            button2.Location = new Point(338, 233);
            button2.Name = "button2";
            button2.Size = new Size(83, 57);
            button2.TabIndex = 27;
            button2.Text = "&Editar";
            button2.TextImageRelation = TextImageRelation.ImageAboveText;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // BTNsalvar
            // 
            BTNsalvar.BackColor = SystemColors.Control;
            BTNsalvar.FlatAppearance.BorderSize = 0;
            BTNsalvar.FlatAppearance.MouseDownBackColor = Color.LimeGreen;
            BTNsalvar.FlatAppearance.MouseOverBackColor = Color.PaleGreen;
            BTNsalvar.FlatStyle = FlatStyle.Flat;
            BTNsalvar.Font = new Font("Verdana", 9F, FontStyle.Bold);
            BTNsalvar.ForeColor = Color.ForestGreen;
            BTNsalvar.Image = (Image)resources.GetObject("BTNsalvar.Image");
            BTNsalvar.Location = new Point(108, 233);
            BTNsalvar.Name = "BTNsalvar";
            BTNsalvar.Size = new Size(83, 57);
            BTNsalvar.TabIndex = 26;
            BTNsalvar.Text = "&Salvar";
            BTNsalvar.TextImageRelation = TextImageRelation.ImageAboveText;
            BTNsalvar.UseVisualStyleBackColor = false;
            // 
            // FrmProdutos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1225, 450);
            Controls.Add(BTNcancelar);
            Controls.Add(BTNpesquisar);
            Controls.Add(button2);
            Controls.Add(BTNsalvar);
            Controls.Add(listBox1);
            Controls.Add(CHKdescontinuado);
            Controls.Add(PICimagem);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BTNcarregarimg);
            Controls.Add(NUDclassedesc);
            Controls.Add(TXTuniVendas);
            Controls.Add(NUDestoquemin);
            Controls.Add(NudValorUnit);
            Controls.Add(CMDcategoria);
            Controls.Add(TXTdescricao);
            Controls.Add(TXTcodBarras);
            Name = "FrmProdutos";
            Text = "Cadastro de Produtos";
            ((System.ComponentModel.ISupportInitialize)NudValorUnit).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDestoquemin).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDclassedesc).EndInit();
            ((System.ComponentModel.ISupportInitialize)PICimagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TXTcodBarras;
        private TextBox TXTdescricao;
        private ComboBox CMDcategoria;
        private NumericUpDown NudValorUnit;
        private NumericUpDown NUDestoquemin;
        private TextBox TXTuniVendas;
        private NumericUpDown NUDclassedesc;
        private Button BTNcarregarimg;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private PictureBox PICimagem;
        private CheckBox CHKdescontinuado;
        private ListBox listBox1;
        private Button BTNpesquisar;
        private Button button2;
        private Button BTNsalvar;
        private Button BTNcancelar;
    }
}