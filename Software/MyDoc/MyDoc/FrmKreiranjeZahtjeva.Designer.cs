namespace MyDoc
{
    partial class FrmKreiranjeZahtjeva
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKreiranjeZahtjeva));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtObrazlozenje = new System.Windows.Forms.RichTextBox();
            this.txtTermin = new System.Windows.Forms.TextBox();
            this.cboOdabir = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.nmbrid = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmbrid)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(72, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vrijeme termina";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Obrazloženje";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mogučnost videopoziva";
            // 
            // txtObrazlozenje
            // 
            this.txtObrazlozenje.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtObrazlozenje.Location = new System.Drawing.Point(252, 136);
            this.txtObrazlozenje.Name = "txtObrazlozenje";
            this.txtObrazlozenje.Size = new System.Drawing.Size(437, 96);
            this.txtObrazlozenje.TabIndex = 3;
            this.txtObrazlozenje.Text = "";
            // 
            // txtTermin
            // 
            this.txtTermin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtTermin.Location = new System.Drawing.Point(252, 76);
            this.txtTermin.Name = "txtTermin";
            this.txtTermin.Size = new System.Drawing.Size(227, 22);
            this.txtTermin.TabIndex = 4;
            // 
            // cboOdabir
            // 
            this.cboOdabir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.cboOdabir.FormattingEnabled = true;
            this.cboOdabir.Items.AddRange(new object[] {
            "Da",
            "Ne"});
            this.cboOdabir.Location = new System.Drawing.Point(252, 282);
            this.cboOdabir.Name = "cboOdabir";
            this.cboOdabir.Size = new System.Drawing.Size(227, 24);
            this.cboOdabir.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(625, 401);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(113, 37);
            this.button1.TabIndex = 6;
            this.button1.Text = "Spremi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnOdustani.Location = new System.Drawing.Point(75, 401);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(121, 37);
            this.btnOdustani.TabIndex = 7;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // nmbrid
            // 
            this.nmbrid.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nmbrid.Location = new System.Drawing.Point(252, 344);
            this.nmbrid.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nmbrid.Name = "nmbrid";
            this.nmbrid.Size = new System.Drawing.Size(227, 22);
            this.nmbrid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(72, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "ID Pacijenta";
            // 
            // FrmKreiranjeZahtjeva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmbrid);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cboOdabir);
            this.Controls.Add(this.txtTermin);
            this.Controls.Add(this.txtObrazlozenje);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmKreiranjeZahtjeva";
            this.Text = "Kreiranje novog zahtjeva";
            ((System.ComponentModel.ISupportInitialize)(this.nmbrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox txtObrazlozenje;
        private System.Windows.Forms.TextBox txtTermin;
        private System.Windows.Forms.ComboBox cboOdabir;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.NumericUpDown nmbrid;
        private System.Windows.Forms.Label label4;
    }
}