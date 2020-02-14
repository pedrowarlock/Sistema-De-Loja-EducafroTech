namespace WindowsFormsApp2
{
    partial class AfroArt
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AfroArt));
            this.CodQuantidade = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.lbl_initvenda = new System.Windows.Forms.Label();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblProduto = new System.Windows.Forms.Label();
            this.lblEstoque = new System.Windows.Forms.Label();
            this.lblUnit = new System.Windows.Forms.Label();
            this.pictureBox_Demo = new System.Windows.Forms.PictureBox();
            this.CodText = new System.Windows.Forms.TextBox();
            this.lblUnitario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CodQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Demo)).BeginInit();
            this.SuspendLayout();
            // 
            // CodQuantidade
            // 
            resources.ApplyResources(this.CodQuantidade, "CodQuantidade");
            this.CodQuantidade.BackColor = System.Drawing.Color.Gainsboro;
            this.CodQuantidade.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodQuantidade.Name = "CodQuantidade";
            this.CodQuantidade.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.CodQuantidade.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            this.CodQuantidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox2_KeyDown);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.Bisque;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            resources.ApplyResources(this.richTextBox1, "richTextBox1");
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            this.richTextBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lbl_initvenda
            // 
            this.lbl_initvenda.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.lbl_initvenda, "lbl_initvenda");
            this.lbl_initvenda.ForeColor = System.Drawing.Color.Transparent;
            this.lbl_initvenda.Name = "lbl_initvenda";
            this.lbl_initvenda.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbltotal
            // 
            this.lbltotal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            resources.ApplyResources(this.lbltotal, "lbltotal");
            this.lbltotal.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblProduto
            // 
            resources.ApplyResources(this.lblProduto, "lblProduto");
            this.lblProduto.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Click += new System.EventHandler(this.lblProduto_Click);
            // 
            // lblEstoque
            // 
            resources.ApplyResources(this.lblEstoque, "lblEstoque");
            this.lblEstoque.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblEstoque.Name = "lblEstoque";
            // 
            // lblUnit
            // 
            resources.ApplyResources(this.lblUnit, "lblUnit");
            this.lblUnit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Click += new System.EventHandler(this.lblUnit_Click);
            // 
            // pictureBox_Demo
            // 
            resources.ApplyResources(this.pictureBox_Demo, "pictureBox_Demo");
            this.pictureBox_Demo.Name = "pictureBox_Demo";
            this.pictureBox_Demo.TabStop = false;
            // 
            // CodText
            // 
            this.CodText.BackColor = System.Drawing.Color.Gainsboro;
            this.CodText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.CodText, "CodText");
            this.CodText.Name = "CodText";
            this.CodText.TextChanged += new System.EventHandler(this.label1_Click);
            this.CodText.Enter += new System.EventHandler(this.CodText_Enter);
            this.CodText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // lblUnitario
            // 
            resources.ApplyResources(this.lblUnitario, "lblUnitario");
            this.lblUnitario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUnitario.Name = "lblUnitario";
            // 
            // AfroArt
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lblUnitario);
            this.Controls.Add(this.pictureBox_Demo);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.lblEstoque);
            this.Controls.Add(this.lblProduto);
            this.Controls.Add(this.lbltotal);
            this.Controls.Add(this.lbl_initvenda);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.CodQuantidade);
            this.Controls.Add(this.CodText);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AfroArt";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CodQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Demo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown CodQuantidade;
        private System.Windows.Forms.Label lbl_initvenda;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.Label lblEstoque;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.PictureBox pictureBox_Demo;
        private System.Windows.Forms.TextBox CodText;
        private System.Windows.Forms.Label lblUnitario;
        public System.Windows.Forms.RichTextBox richTextBox1;
    }
}

