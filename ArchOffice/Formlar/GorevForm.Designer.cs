namespace ArchOffice.Formlar
{
    partial class GorevForm
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
            this.dgvGorevler = new System.Windows.Forms.DataGridView();
            this.lblGörevBaslik = new System.Windows.Forms.Label();
            this.lblSonTarih = new System.Windows.Forms.Label();
            this.txtGorevBaslik = new System.Windows.Forms.TextBox();
            this.dtpSonTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(12, 12);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(76, 13);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Proje Görevleri";
            // 
            // dgvGorevler
            // 
            this.dgvGorevler.AllowUserToAddRows = false;
            this.dgvGorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGorevler.Location = new System.Drawing.Point(12, 45);
            this.dgvGorevler.Name = "dgvGorevler";
            this.dgvGorevler.ReadOnly = true;
            this.dgvGorevler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGorevler.Size = new System.Drawing.Size(760, 300);
            this.dgvGorevler.TabIndex = 1;
            // 
            // lblGörevBaslik
            // 
            this.lblGörevBaslik.AutoSize = true;
            this.lblGörevBaslik.Location = new System.Drawing.Point(12, 365);
            this.lblGörevBaslik.Name = "lblGörevBaslik";
            this.lblGörevBaslik.Size = new System.Drawing.Size(42, 13);
            this.lblGörevBaslik.TabIndex = 2;
            this.lblGörevBaslik.Text = "Görev :";
            // 
            // lblSonTarih
            // 
            this.lblSonTarih.AutoSize = true;
            this.lblSonTarih.Location = new System.Drawing.Point(250, 365);
            this.lblSonTarih.Name = "lblSonTarih";
            this.lblSonTarih.Size = new System.Drawing.Size(55, 13);
            this.lblSonTarih.TabIndex = 3;
            this.lblSonTarih.Text = "Son tarih :";
            // 
            // txtGorevBaslik
            // 
            this.txtGorevBaslik.Location = new System.Drawing.Point(12, 385);
            this.txtGorevBaslik.Name = "txtGorevBaslik";
            this.txtGorevBaslik.Size = new System.Drawing.Size(220, 20);
            this.txtGorevBaslik.TabIndex = 4;
            // 
            // dtpSonTarih
            // 
            this.dtpSonTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSonTarih.Location = new System.Drawing.Point(250, 385);
            this.dtpSonTarih.Name = "dtpSonTarih";
            this.dtpSonTarih.Size = new System.Drawing.Size(140, 20);
            this.dtpSonTarih.TabIndex = 5;
            this.dtpSonTarih.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(410, 382);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 30);
            this.btnEkle.TabIndex = 6;
            this.btnEkle.Text = "Görev Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(530, 382);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(130, 30);
            this.btnTamamla.TabIndex = 7;
            this.btnTamamla.Text = "Tamamlandı Yap";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(670, 382);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 30);
            this.btnKapat.TabIndex = 8;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // GorevForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtpSonTarih);
            this.Controls.Add(this.txtGorevBaslik);
            this.Controls.Add(this.lblSonTarih);
            this.Controls.Add(this.lblGörevBaslik);
            this.Controls.Add(this.dgvGorevler);
            this.Controls.Add(this.lblBaslik);
            this.Location = new System.Drawing.Point(800, 520);
            this.Name = "GorevForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Proje Görevleri";
            this.Load += new System.EventHandler(this.GorevForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dgvGorevler;
        private System.Windows.Forms.Label lblGörevBaslik;
        private System.Windows.Forms.Label lblSonTarih;
        private System.Windows.Forms.TextBox txtGorevBaslik;
        private System.Windows.Forms.DateTimePicker dtpSonTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnKapat;
    }
}