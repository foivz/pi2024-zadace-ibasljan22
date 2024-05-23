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
            this.dgvZahtjev = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjev)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvZahtjev
            // 
            this.dgvZahtjev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvZahtjev.Location = new System.Drawing.Point(12, 12);
            this.dgvZahtjev.Name = "dgvZahtjev";
            this.dgvZahtjev.RowHeadersWidth = 51;
            this.dgvZahtjev.RowTemplate.Height = 24;
            this.dgvZahtjev.Size = new System.Drawing.Size(776, 426);
            this.dgvZahtjev.TabIndex = 0;
            // 
            // FrmPacijent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvZahtjev);
            this.Name = "FrmPacijent";
            this.Text = "FrmPacijent";
            this.Load += new System.EventHandler(this.FrmPacijent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvZahtjev)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvZahtjev;
    }
}