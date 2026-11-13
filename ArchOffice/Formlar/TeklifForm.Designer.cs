namespace ArchOffice.Formlar
{
    partial class TeklifForm
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.dgvKalemler = new System.Windows.Forms.DataGridView();
            this.lblToplam = new System.Windows.Forms.Label();
            this.lblMalzeme = new System.Windows.Forms.Label();
            this.cmbMalzeme = new System.Windows.Forms.ComboBox();
            this.txtMiktar = new System.Windows.Forms.TextBox();
            this.btnKalemEkle = new System.Windows.Forms.Button();
            this.btnKalemSil = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblMiktar = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKalemler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(12, 12);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(78, 13);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Teklif Kalemleri";
            // 
            // dgvKalemler
            // 
            this.dgvKalemler.AllowUserToAddRows = false;
            this.dgvKalemler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKalemler.Location = new System.Drawing.Point(12, 45);
            this.dgvKalemler.Name = "dgvKalemler";
            this.dgvKalemler.ReadOnly = true;
            this.dgvKalemler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKalemler.Size = new System.Drawing.Size(760, 280);
            this.dgvKalemler.TabIndex = 1;
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(12, 335);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(54, 13);
            this.lblToplam.TabIndex = 3;
            this.lblToplam.Text = "Toplam: 0";
            // 
            // lblMalzeme
            // 
            this.lblMalzeme.AutoSize = true;
            this.lblMalzeme.Location = new System.Drawing.Point(12, 375);
            this.lblMalzeme.Name = "lblMalzeme";
            this.lblMalzeme.Size = new System.Drawing.Size(55, 13);
            this.lblMalzeme.TabIndex = 4;
            this.lblMalzeme.Text = "Malzeme :";
            // 
            // cmbMalzeme
            // 
            this.cmbMalzeme.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMalzeme.FormattingEnabled = true;
            this.cmbMalzeme.Location = new System.Drawing.Point(12, 395);
            this.cmbMalzeme.Name = "cmbMalzeme";
            this.cmbMalzeme.Size = new System.Drawing.Size(200, 21);
            this.cmbMalzeme.TabIndex = 6;
            // 
            // txtMiktar
            // 
            this.txtMiktar.Location = new System.Drawing.Point(250, 395);
            this.txtMiktar.Name = "txtMiktar";
            this.txtMiktar.Size = new System.Drawing.Size(100, 20);
            this.txtMiktar.TabIndex = 7;
            this.txtMiktar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnKalemEkle
            // 
            this.btnKalemEkle.Location = new System.Drawing.Point(370, 392);
            this.btnKalemEkle.Name = "btnKalemEkle";
            this.btnKalemEkle.Size = new System.Drawing.Size(110, 30);
            this.btnKalemEkle.TabIndex = 8;
            this.btnKalemEkle.Text = "Kalem Ekle";
            this.btnKalemEkle.UseVisualStyleBackColor = true;
            this.btnKalemEkle.Click += new System.EventHandler(this.btnKalemEkle_Click);
            // 
            // btnKalemSil
            // 
            this.btnKalemSil.Location = new System.Drawing.Point(490, 392);
            this.btnKalemSil.Name = "btnKalemSil";
            this.btnKalemSil.Size = new System.Drawing.Size(140, 30);
            this.btnKalemSil.TabIndex = 9;
            this.btnKalemSil.Text = "Seçili Kalemi Sil";
            this.btnKalemSil.UseVisualStyleBackColor = true;
            this.btnKalemSil.Click += new System.EventHandler(this.btnKalemSil_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(650, 392);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 30);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.button3_Click);
            // 
            // lblMiktar
            // 
            this.lblMiktar.AutoSize = true;
            this.lblMiktar.Location = new System.Drawing.Point(250, 375);
            this.lblMiktar.Name = "lblMiktar";
            this.lblMiktar.Size = new System.Drawing.Size(42, 13);
            this.lblMiktar.TabIndex = 11;
            this.lblMiktar.Text = "Miktar :";
            // 
            // TeklifForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnKalemSil);
            this.Controls.Add(this.btnKalemEkle);
            this.Controls.Add(this.txtMiktar);
            this.Controls.Add(this.cmbMalzeme);
            this.Controls.Add(this.lblMalzeme);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.dgvKalemler);
            this.Controls.Add(this.lblBaslik);
            this.Location = new System.Drawing.Point(800, 520);
            this.Name = "TeklifForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Teklif / Metraj";
            this.Load += new System.EventHandler(this.TeklifForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKalemler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dgvKalemler;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Label lblMalzeme;
        private System.Windows.Forms.ComboBox cmbMalzeme;
        private System.Windows.Forms.TextBox txtMiktar;
        private System.Windows.Forms.Button btnKalemEkle;
        private System.Windows.Forms.Button btnKalemSil;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblMiktar;
    }
}