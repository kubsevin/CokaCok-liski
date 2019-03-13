namespace CokaCokİliski
{
    partial class FormEgitmen
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
            this.txtEgtSoyadi = new System.Windows.Forms.TextBox();
            this.lblSoyadi = new System.Windows.Forms.Label();
            this.lblAdi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.dgvEgitmen = new System.Windows.Forms.DataGridView();
            this.txtEgtAdi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgitmen)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEgtSoyadi
            // 
            this.txtEgtSoyadi.Location = new System.Drawing.Point(87, 71);
            this.txtEgtSoyadi.Name = "txtEgtSoyadi";
            this.txtEgtSoyadi.Size = new System.Drawing.Size(161, 20);
            this.txtEgtSoyadi.TabIndex = 8;
            // 
            // lblSoyadi
            // 
            this.lblSoyadi.AutoSize = true;
            this.lblSoyadi.Location = new System.Drawing.Point(12, 78);
            this.lblSoyadi.Name = "lblSoyadi";
            this.lblSoyadi.Size = new System.Drawing.Size(42, 13);
            this.lblSoyadi.TabIndex = 5;
            this.lblSoyadi.Text = "Soyadı:";
            // 
            // lblAdi
            // 
            this.lblAdi.AutoSize = true;
            this.lblAdi.Location = new System.Drawing.Point(12, 25);
            this.lblAdi.Name = "lblAdi";
            this.lblAdi.Size = new System.Drawing.Size(25, 13);
            this.lblAdi.TabIndex = 6;
            this.lblAdi.Text = "Adı:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(310, 25);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(112, 48);
            this.btnEkle.TabIndex = 10;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // dgvEgitmen
            // 
            this.dgvEgitmen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEgitmen.Location = new System.Drawing.Point(16, 119);
            this.dgvEgitmen.Name = "dgvEgitmen";
            this.dgvEgitmen.Size = new System.Drawing.Size(406, 204);
            this.dgvEgitmen.TabIndex = 4;
            // 
            // txtEgtAdi
            // 
            this.txtEgtAdi.Location = new System.Drawing.Point(87, 22);
            this.txtEgtAdi.Name = "txtEgtAdi";
            this.txtEgtAdi.Size = new System.Drawing.Size(161, 20);
            this.txtEgtAdi.TabIndex = 7;
            // 
            // FormEgitmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 332);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEgtAdi);
            this.Controls.Add(this.txtEgtSoyadi);
            this.Controls.Add(this.lblSoyadi);
            this.Controls.Add(this.lblAdi);
            this.Controls.Add(this.dgvEgitmen);
            this.Name = "FormEgitmen";
            this.Text = "FormEgitmen";
            this.Load += new System.EventHandler(this.FormEgitmen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEgitmen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtEgtSoyadi;
        private System.Windows.Forms.Label lblSoyadi;
        private System.Windows.Forms.Label lblAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.DataGridView dgvEgitmen;
        private System.Windows.Forms.TextBox txtEgtAdi;
    }
}