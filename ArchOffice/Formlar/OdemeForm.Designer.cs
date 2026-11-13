namespace ArchOffice.Formlar
{
    partial class OdemeForm
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
            this.lblToplam = new System.Windows.Forms.Label();
            this.dgvOdemeler = new System.Windows.Forms.DataGridView();
            this.lblTutar = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(12, 12);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(52, 13);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Ödemeler";
            // 
            // lblToplam
            // 
            this.lblToplam.AutoSize = true;
            this.lblToplam.Location = new System.Drawing.Point(12, 335);
            this.lblToplam.Name = "lblToplam";
            this.lblToplam.Size = new System.Drawing.Size(92, 13);
            this.lblToplam.TabIndex = 1;
            this.lblToplam.Text = "Toplam ödeme : 0";
            // 
            // dgvOdemeler
            // 
            this.dgvOdemeler.AllowUserToAddRows = false;
            this.dgvOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeler.Location = new System.Drawing.Point(12, 45);
            this.dgvOdemeler.Name = "dgvOdemeler";
            this.dgvOdemeler.ReadOnly = true;
            this.dgvOdemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOdemeler.Size = new System.Drawing.Size(760, 280);
            this.dgvOdemeler.TabIndex = 2;
            // 
            // lblTutar
            // 
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(12, 375);
            this.lblTutar.Name = "lblTutar";
            this.lblTutar.Size = new System.Drawing.Size(38, 13);
            this.lblTutar.TabIndex = 3;
            this.lblTutar.Text = "Tutar :";
            this.lblTutar.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(150, 375);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(29, 13);
            this.lblTur.TabIndex = 4;
            this.lblTur.Text = "Tür :";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(290, 375);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(56, 13);
            this.lblAciklama.TabIndex = 5;
            this.lblAciklama.Text = "Açıklama :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(290, 395);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 20);
            this.txtAciklama.TabIndex = 6;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(12, 395);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(120, 20);
            this.txtTutar.TabIndex = 7;
            this.txtTutar.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(150, 395);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(120, 21);
            this.cmbTur.TabIndex = 8;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(510, 392);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 30);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ödeme Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(640, 392);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 30);
            this.btnKapat.TabIndex = 10;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.button2_Click);
            // 
            // OdemeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.dgvOdemeler);
            this.Controls.Add(this.lblToplam);
            this.Controls.Add(this.lblBaslik);
            this.Location = new System.Drawing.Point(800, 520);
            this.Name = "OdemeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Ödeme Takibi";
            this.Load += new System.EventHandler(this.OdemeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.DataGridView dgvOdemeler;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnKapat;
    }
}