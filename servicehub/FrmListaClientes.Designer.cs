namespace servicehub
{
    partial class FrmListaClientes
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
            textBox1 = new TextBox();
            label1 = new Label();
            dgvClientes = new DataGridView();
            CLMsec = new DataGridViewTextBoxColumn();
            CLMid = new DataGridViewTextBoxColumn();
            CLMnome = new DataGridViewTextBoxColumn();
            CLMcpf = new DataGridViewTextBoxColumn();
            CLMemail = new DataGridViewTextBoxColumn();
            CLMtelefone = new DataGridViewTextBoxColumn();
            CLMativo = new DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(85, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(674, 23);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(39, 42);
            label1.Name = "label1";
            label1.Size = new Size(42, 15);
            label1.TabIndex = 1;
            label1.Text = "Buscar";
            // 
            // dgvClientes
            // 
            dgvClientes.AllowUserToAddRows = false;
            dgvClientes.AllowUserToDeleteRows = false;
            dgvClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { CLMsec, CLMid, CLMnome, CLMcpf, CLMemail, CLMtelefone, CLMativo });
            dgvClientes.Location = new Point(39, 60);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.ReadOnly = true;
            dgvClientes.RowHeadersVisible = false;
            dgvClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvClientes.Size = new Size(722, 280);
            dgvClientes.TabIndex = 2;
            dgvClientes.CellClick += dgvClientes_CellClick;

            // 
            // CLMsec
            // 
            CLMsec.Frozen = true;
            CLMsec.HeaderText = "#";
            CLMsec.Name = "CLMsec";
            CLMsec.ReadOnly = true;
            CLMsec.Width = 30;
            // 
            // CLMid
            // 
            CLMid.Frozen = true;
            CLMid.HeaderText = "ID";
            CLMid.Name = "CLMid";
            CLMid.ReadOnly = true;
            CLMid.Width = 80;
            // 
            // CLMnome
            // 
            CLMnome.Frozen = true;
            CLMnome.HeaderText = "Nome";
            CLMnome.Name = "CLMnome";
            CLMnome.ReadOnly = true;
            CLMnome.Width = 200;
            // 
            // CLMcpf
            // 
            CLMcpf.Frozen = true;
            CLMcpf.HeaderText = "CPF";
            CLMcpf.Name = "CLMcpf";
            CLMcpf.ReadOnly = true;
            // 
            // CLMemail
            // 
            CLMemail.HeaderText = "Email";
            CLMemail.Name = "CLMemail";
            CLMemail.ReadOnly = true;
            CLMemail.Width = 168;
            // 
            // CLMtelefone
            // 
            CLMtelefone.HeaderText = "Telefone";
            CLMtelefone.Name = "CLMtelefone";
            CLMtelefone.ReadOnly = true;
            // 
            // CLMativo
            // 
            CLMativo.HeaderText = "ativo";
            CLMativo.Name = "CLMativo";
            CLMativo.ReadOnly = true;
            CLMativo.Width = 40;
            // 
            // FrmListaClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(768, 372);
            Controls.Add(dgvClientes);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "FrmListaClientes";
            Text = "FrmListaClientes";
            Load += FrmListaClientes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private DataGridView dgvClientes;
        private DataGridViewTextBoxColumn CLMsec;
        private DataGridViewTextBoxColumn CLMid;
        private DataGridViewTextBoxColumn CLMnome;
        private DataGridViewTextBoxColumn CLMcpf;
        private DataGridViewTextBoxColumn CLMemail;
        private DataGridViewTextBoxColumn CLMtelefone;
        private DataGridViewCheckBoxColumn CLMativo;
    }
}