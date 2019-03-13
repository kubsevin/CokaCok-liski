namespace CokaCokİliski
{
    partial class Fomİliski
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
            this.lblEgitmen = new System.Windows.Forms.Label();
            this.cbEgitmen = new System.Windows.Forms.ComboBox();
            this.dgvİliski = new System.Windows.Forms.DataGridView();
            this.btnİliskilendir = new System.Windows.Forms.Button();
            this.lblOgrenci = new System.Windows.Forms.Label();
            this.lstİliski = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvİliski)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEgitmen
            // 
            this.lblEgitmen.AutoSize = true;
            this.lblEgitmen.Location = new System.Drawing.Point(12, 26);
            this.lblEgitmen.Name = "lblEgitmen";
            this.lblEgitmen.Size = new System.Drawing.Size(45, 13);
            this.lblEgitmen.TabIndex = 0;
            this.lblEgitmen.Text = "Eğitmen";
            // 
            // cbEgitmen
            // 
            this.cbEgitmen.FormattingEnabled = true;
            this.cbEgitmen.Location = new System.Drawing.Point(63, 26);
            this.cbEgitmen.Name = "cbEgitmen";
            this.cbEgitmen.Size = new System.Drawing.Size(121, 21);
            this.cbEgitmen.TabIndex = 1;
            this.cbEgitmen.SelectedIndexChanged += new System.EventHandler(this.cbEgitmen_SelectedIndexChanged);
            // 
            // dgvİliski
            // 
            this.dgvİliski.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvİliski.Location = new System.Drawing.Point(12, 82);
            this.dgvİliski.Name = "dgvİliski";
            this.dgvİliski.Size = new System.Drawing.Size(235, 204);
            this.dgvİliski.TabIndex = 2;
            this.dgvİliski.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvİliski_CellClick);
            // 
            // btnİliskilendir
            // 
            this.btnİliskilendir.Location = new System.Drawing.Point(12, 292);
            this.btnİliskilendir.Name = "btnİliskilendir";
            this.btnİliskilendir.Size = new System.Drawing.Size(107, 32);
            this.btnİliskilendir.TabIndex = 3;
            this.btnİliskilendir.Text = "İlişkilendir";
            this.btnİliskilendir.UseVisualStyleBackColor = true;
            this.btnİliskilendir.Click += new System.EventHandler(this.btnİliskilendir_Click);
            // 
            // lblOgrenci
            // 
            this.lblOgrenci.AutoSize = true;
            this.lblOgrenci.Location = new System.Drawing.Point(262, 82);
            this.lblOgrenci.Name = "lblOgrenci";
            this.lblOgrenci.Size = new System.Drawing.Size(44, 13);
            this.lblOgrenci.TabIndex = 0;
            this.lblOgrenci.Text = "Öğrenci";
            // 
            // lstİliski
            // 
            this.lstİliski.FormattingEnabled = true;
            this.lstİliski.Location = new System.Drawing.Point(312, 82);
            this.lstİliski.Name = "lstİliski";
            this.lstİliski.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstİliski.Size = new System.Drawing.Size(244, 212);
            this.lstİliski.TabIndex = 4;
            this.lstİliski.SelectedIndexChanged += new System.EventHandler(this.lstİliski_SelectedIndexChanged);
            // 
            // Fomİliski
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 329);
            this.Controls.Add(this.lstİliski);
            this.Controls.Add(this.btnİliskilendir);
            this.Controls.Add(this.dgvİliski);
            this.Controls.Add(this.cbEgitmen);
            this.Controls.Add(this.lblOgrenci);
            this.Controls.Add(this.lblEgitmen);
            this.Name = "Fomİliski";
            this.Load += new System.EventHandler(this.Fomİliski_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvİliski)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEgitmen;
        private System.Windows.Forms.ComboBox cbEgitmen;
        private System.Windows.Forms.DataGridView dgvİliski;
        private System.Windows.Forms.Button btnİliskilendir;
        private System.Windows.Forms.Label lblOgrenci;
        private System.Windows.Forms.ListBox lstİliski;
    }
}