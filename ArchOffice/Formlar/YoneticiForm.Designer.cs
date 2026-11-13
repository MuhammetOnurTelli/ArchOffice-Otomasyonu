namespace ArchOffice.Formlar
{
    partial class YoneticiForm
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
            this.dgvKullanicilar = new System.Windows.Forms.DataGridView();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnAktifPasif = new System.Windows.Forms.Button();
            this.btnProjeler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvKullanicilar
            // 
            this.dgvKullanicilar.AllowUserToAddRows = false;
            this.dgvKullanicilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKullanicilar.Location = new System.Drawing.Point(12, 40);
            this.dgvKullanicilar.MultiSelect = false;
            this.dgvKullanicilar.Name = "dgvKullanicilar";
            this.dgvKullanicilar.ReadOnly = true;
            this.dgvKullanicilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvKullanicilar.Size = new System.Drawing.Size(780, 380);
            this.dgvKullanicilar.TabIndex = 0;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(12, 12);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(57, 13);
            this.lblBaslik.TabIndex = 1;
            this.lblBaslik.Text = "Kullanıcılar";
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(12, 430);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(75, 23);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnAktifPasif
            // 
            this.btnAktifPasif.Location = new System.Drawing.Point(130, 430);
            this.btnAktifPasif.Name = "btnAktifPasif";
            this.btnAktifPasif.Size = new System.Drawing.Size(140, 30);
            this.btnAktifPasif.TabIndex = 3;
            this.btnAktifPasif.Text = "Aktif / Pasif Yap";
            this.btnAktifPasif.UseVisualStyleBackColor = true;
            this.btnAktifPasif.Click += new System.EventHandler(this.btnAktifPasif_Click);
            // 
            // btnProjeler
            // 
            this.btnProjeler.Location = new System.Drawing.Point(280, 430);
            this.btnProjeler.Name = "btnProjeler";
            this.btnProjeler.Size = new System.Drawing.Size(140, 30);
            this.btnProjeler.TabIndex = 4;
            this.btnProjeler.Text = "Projeleri Yönet";
            this.btnProjeler.UseVisualStyleBackColor = true;
            this.btnProjeler.Click += new System.EventHandler(this.button1_Click);
            // 
            // YoneticiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.btnProjeler);
            this.Controls.Add(this.btnAktifPasif);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dgvKullanicilar);
            this.Name = "YoneticiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Yönetici Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YoneticiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvKullanicilar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvKullanicilar;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnAktifPasif;
        private System.Windows.Forms.Button btnProjeler;
    }
}