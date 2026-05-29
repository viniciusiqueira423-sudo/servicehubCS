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
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // TXTsigla
            // 
            TXTsigla.Location = new Point(565, 111);
            TXTsigla.Name = "TXTsigla";
            TXTsigla.Size = new Size(97, 23);
            TXTsigla.TabIndex = 24;
            // 
            // TXTnome
            // 
            TXTnome.Cursor = Cursors.IBeam;
            TXTnome.Location = new Point(199, 111);
            TXTnome.Name = "TXTnome";
            TXTnome.Size = new Size(360, 23);
            TXTnome.TabIndex = 23;
            // 
            // TXTid
            // 
            TXTid.Location = new Point(93, 111);
            TXTid.Name = "TXTid";
            TXTid.ReadOnly = true;
            TXTid.Size = new Size(100, 23);
            TXTid.TabIndex = 28;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(565, 93);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 25;
            label3.Text = "Sigla";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(199, 93);
            label2.Name = "label2";
            label2.Size = new Size(40, 15);
            label2.TabIndex = 26;
            label2.Text = "Nome";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 93);
            label1.Name = "label1";
            label1.Size = new Size(18, 15);
            label1.TabIndex = 27;
            label1.Text = "ID";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(93, 160);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(569, 215);
            dataGridView1.TabIndex = 29;
            // 
            // FrmNiveis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
    }
}