namespace servicehub
{
    partial class Frmcomponente
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
            label1 = new Label();
            textBox1 = new TextBox();
            listBox1 = new ListBox();
            button1 = new Button();
            button2 = new Button();
            label2 = new Label();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            DGVservicos = new DataGridView();
            clnid = new DataGridViewTextBoxColumn();
            clnnome = new DataGridViewTextBoxColumn();
            clndescricao = new DataGridViewTextBoxColumn();
            clnpreco = new DataGridViewTextBoxColumn();
            clndescontinuado = new DataGridViewCheckBoxColumn();
            DGVusuarios = new DataGridView();
            clid = new DataGridViewTextBoxColumn();
            clnome = new DataGridViewTextBoxColumn();
            clemail = new DataGridViewTextBoxColumn();
            DGVsolicitacao = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            btnsolicitacao = new Button();
            ((System.ComponentModel.ISupportInitialize)DGVservicos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVusuarios).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DGVsolicitacao).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 124);
            label1.Name = "label1";
            label1.Size = new Size(103, 15);
            label1.TabIndex = 0;
            label1.Text = "Digite os numeros";
            label1.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 142);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(75, 23);
            textBox1.TabIndex = 1;
            textBox1.Visible = false;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(256, 71);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(195, 229);
            listBox1.TabIndex = 2;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(12, 171);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(108, 171);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 4;
            button2.Text = "cancelar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(108, 15);
            label2.TabIndex = 6;
            label2.Text = "Escolha a operação";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Multiplicação", "Divisão", "Adição", "Subtração", "Exponenciação", "Tabuada", "Radiciação" });
            comboBox1.Location = new Point(12, 89);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(156, 23);
            comboBox1.TabIndex = 7;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(108, 142);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(84, 23);
            textBox2.TabIndex = 8;
            textBox2.Visible = false;
            // 
            // DGVservicos
            // 
            DGVservicos.AllowUserToAddRows = false;
            DGVservicos.AllowUserToDeleteRows = false;
            DGVservicos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVservicos.Columns.AddRange(new DataGridViewColumn[] { clnid, clnnome, clndescricao, clnpreco, clndescontinuado });
            DGVservicos.Location = new Point(41, 297);
            DGVservicos.Name = "DGVservicos";
            DGVservicos.ReadOnly = true;
            DGVservicos.RowHeadersVisible = false;
            DGVservicos.Size = new Size(845, 215);
            DGVservicos.TabIndex = 9;
            // 
            // clnid
            // 
            clnid.Frozen = true;
            clnid.HeaderText = "ID";
            clnid.Name = "clnid";
            clnid.ReadOnly = true;
            clnid.Width = 40;
            // 
            // clnnome
            // 
            clnnome.Frozen = true;
            clnnome.HeaderText = "Nome";
            clnnome.Name = "clnnome";
            clnnome.ReadOnly = true;
            clnnome.Width = 200;
            // 
            // clndescricao
            // 
            clndescricao.Frozen = true;
            clndescricao.HeaderText = "Descrição";
            clndescricao.Name = "clndescricao";
            clndescricao.ReadOnly = true;
            clndescricao.Width = 400;
            // 
            // clnpreco
            // 
            clnpreco.Frozen = true;
            clnpreco.HeaderText = "Preço";
            clnpreco.Name = "clnpreco";
            clnpreco.ReadOnly = true;
            // 
            // clndescontinuado
            // 
            clndescontinuado.HeaderText = "Descontinuado";
            clndescontinuado.IndeterminateValue = "true";
            clndescontinuado.Name = "clndescontinuado";
            clndescontinuado.ReadOnly = true;
            // 
            // DGVusuarios
            // 
            DGVusuarios.AllowUserToAddRows = false;
            DGVusuarios.AllowUserToDeleteRows = false;
            DGVusuarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVusuarios.Columns.AddRange(new DataGridViewColumn[] { clid, clnome, clemail });
            DGVusuarios.Location = new Point(41, 552);
            DGVusuarios.Name = "DGVusuarios";
            DGVusuarios.ReadOnly = true;
            DGVusuarios.RowHeadersVisible = false;
            DGVusuarios.Size = new Size(585, 194);
            DGVusuarios.TabIndex = 10;
            DGVusuarios.CellContentClick += DGVusuarios_CellContentClick;
            // 
            // clid
            // 
            clid.HeaderText = "ID";
            clid.Name = "clid";
            clid.ReadOnly = true;
            clid.Width = 40;
            // 
            // clnome
            // 
            clnome.HeaderText = "Nome";
            clnome.Name = "clnome";
            clnome.ReadOnly = true;
            clnome.Width = 200;
            // 
            // clemail
            // 
            clemail.HeaderText = "Email";
            clemail.Name = "clemail";
            clemail.ReadOnly = true;
            clemail.Width = 390;
            // 
            // DGVsolicitacao
            // 
            DGVsolicitacao.AllowUserToAddRows = false;
            DGVsolicitacao.AllowUserToDeleteRows = false;
            DGVsolicitacao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DGVsolicitacao.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2 });
            DGVsolicitacao.Location = new Point(41, 789);
            DGVsolicitacao.Name = "DGVsolicitacao";
            DGVsolicitacao.ReadOnly = true;
            DGVsolicitacao.RowHeadersVisible = false;
            DGVsolicitacao.Size = new Size(557, 194);
            DGVsolicitacao.TabIndex = 11;
            DGVsolicitacao.CellContentClick += DGVsolicitacao_CellContentClick;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "ID";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Descrição do Problema";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            dataGridViewTextBoxColumn2.Width = 500;
            // 
            // btnsolicitacao
            // 
            btnsolicitacao.Location = new Point(604, 960);
            btnsolicitacao.Name = "btnsolicitacao";
            btnsolicitacao.Size = new Size(75, 23);
            btnsolicitacao.TabIndex = 12;
            btnsolicitacao.Text = "Solicitação";
            btnsolicitacao.UseVisualStyleBackColor = true;
            btnsolicitacao.Click += btnsolicitacao_Click;
            // 
            // Frmcomponente
            // 
            AcceptButton = button1;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = button2;
            ClientSize = new Size(1133, 1061);
            Controls.Add(btnsolicitacao);
            Controls.Add(DGVsolicitacao);
            Controls.Add(DGVusuarios);
            Controls.Add(DGVservicos);
            Controls.Add(textBox2);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Frmcomponente";
            Text = "Frmcomponente";
            Load += Frmcomponente_Load;
            ((System.ComponentModel.ISupportInitialize)DGVservicos).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVusuarios).EndInit();
            ((System.ComponentModel.ISupportInitialize)DGVsolicitacao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private ListBox listBox1;
        private Button button1;
        private Button button2;
        private Label label2;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private DataGridView DGVservicos;
        private DataGridView DGVusuarios;
        private DataGridViewTextBoxColumn clid;
        private DataGridViewTextBoxColumn clnome;
        private DataGridViewTextBoxColumn clemail;
        private DataGridView DGVsolicitacao;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private Button btnsolicitacao;
        private DataGridViewTextBoxColumn clnid;
        private DataGridViewTextBoxColumn clnnome;
        private DataGridViewTextBoxColumn clndescricao;
        private DataGridViewTextBoxColumn clnpreco;
        private DataGridViewCheckBoxColumn clndescontinuado;
    }
}