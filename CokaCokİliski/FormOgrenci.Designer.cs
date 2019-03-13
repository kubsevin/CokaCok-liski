namespace CokaCokİliski
{
    partial class FormOgrenci
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
            this.dgvOgrenci = new System.Windows.Forms.DataGridView();
            this.lblAdi = new System.Windows.Forms.Label();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.txtOgrSoyadi = new System.Windows.Forms.TextBox();
            this.txtOgrAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvOgrenci
            // 
            this.dgvOgrenci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOgrenci.Location = new System.Drawing.Point(12, 131);
            this.dgvOgrenci.Name = "dgvOgrenci";
            this.dgvOgrenci.Size = new System.Drawing.Size(406, 204);
            this.dgvOgrenci.TabIndex = 0;
            this.dgvOgrenci.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOgrenci_CellContentClick);
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(29, 39);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(25, 13);
            this.lblAdi.TabIndex = 1;
            this.lblAdi.Text = "Adı:";
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(12, 99);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(42, 13);
            this.lblSoyadi.TabIndex = 1;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // txtOgrSoyadi
            // 
            this.txtOgrSoyadi.Location = new System.Drawing.Point(82, 92);
            this.txtOgrSoyadi.Name = "txtOgrSoyadi";
            this.txtOgrSoyadi.Size = new System.Drawing.Size(161, 20);
            this.txtOgrSoyadi.TabIndex = 2;
            // 
            // txtOgrAdi
            // 
            this.txtOgrAdi.Location = new System.Drawing.Point(82, 36);
            this.txtOgrAdi.Name = "txtOgrAdi";
            this.txtOgrAdi.Size = new System.Drawing.Size(161, 20);
            this.txtOgrAdi.TabIndex = 2;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(304, 49);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(114, 48);
            this.btnEkle.TabIndex = 3;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // FormOgrenci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 343);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtOgrAdi);
            this.Controls.Add(this.txtOgrSoyadi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.dgvOgrenci);
            this.Name = "FormOgrenci";
            this.Text = "FormOgrenci";
            this.Load += new System.EventHandler(this.FormOgrenci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOgrenci)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvOgrenci;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.TextBox txtOgrSoyadi;
        private System.Windows.Forms.TextBox txtOgrAdi;
        private System.Windows.Forms.Button btnEkle;
    }
}