namespace MyDoc
{
    partial class FrmPacijent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPacijent));
            this.dgvZahtjev = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.UrediOpis = new System.Windows.Forms.Button();
            this.txtPretraži = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPretraga = new System.Windows.Forms.TextBox();
            this.btnObriši = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjev)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahtjev
            // 
            this.dgvZahtjev.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvZahtjev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjev.Location = new System.Drawing.Point(12, 148);
            this.dgvZahtjev.Name = "dgvZahtjev";
            this.dgvZahtjev.RowHeadersWidth = 51;
            this.dgvZahtjev.RowTemplate.Height = 24;
            this.dgvZahtjev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvZahtjev.Size = new System.Drawing.Size(776, 193);
            this.dgvZahtjev.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(667, 406);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 32);
            this.button1.TabIndex = 1;
            this.button1.Text = "Novi zahtjev";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // UrediOpis
            // 
            this.UrediOpis.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.UrediOpis.Location = new System.Drawing.Point(326, 406);
            this.UrediOpis.Name = "UrediOpis";
            this.UrediOpis.Size = new System.Drawing.Size(121, 32);
            this.UrediOpis.TabIndex = 2;
            this.UrediOpis.Text = "Uredi ";
            this.UrediOpis.UseVisualStyleBackColor = true;
            this.UrediOpis.Click += new System.EventHandler(this.UrediOpis_Click);
            // 
            // txtPretraži
            // 
            this.txtPretraži.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPretraži.Location = new System.Drawing.Point(381, 29);
            this.txtPretraži.Name = "txtPretraži";
            this.txtPretraži.Size = new System.Drawing.Size(147, 22);
            this.txtPretraži.TabIndex = 3;
            this.txtPretraži.TextChanged += new System.EventHandler(this.txtPretraži_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(183, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pretraga po vremenu termina:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(143, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pretraga prema obrazloženju:";
            // 
            // txtPretraga
            // 
            this.txtPretraga.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPretraga.Location = new System.Drawing.Point(381, 97);
            this.txtPretraga.Name = "txtPretraga";
            this.txtPretraga.Size = new System.Drawing.Size(147, 22);
            this.txtPretraga.TabIndex = 6;
            this.txtPretraga.TextChanged += new System.EventHandler(this.txtPretraga_TextChanged);
            // 
            // btnObriši
            // 
            this.btnObriši.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnObriši.Location = new System.Drawing.Point(12, 406);
            this.btnObriši.Name = "btnObriši";
            this.btnObriši.Size = new System.Drawing.Size(106, 32);
            this.btnObriši.TabIndex = 7;
            this.btnObriši.Text = "Obriši";
            this.btnObriši.UseVisualStyleBackColor = true;
            this.btnObriši.Click += new System.EventHandler(this.btnObriši_Click);
            // 
            // FrmPacijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnObriši);
            this.Controls.Add(this.txtPretraga);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPretraži);
            this.Controls.Add(this.UrediOpis);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvZahtjev);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPacijent";
            this.Text = "Zahtjevi pacijenta";
            this.Load += new System.EventHandler(this.FrmPacijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZahtjev;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button UrediOpis;
        private System.Windows.Forms.TextBox txtPretraži;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPretraga;
        private System.Windows.Forms.Button btnObriši;
    }
}