namespace ArchOffice.Formlar
{
    partial class AsamaForm
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
            this.dgvAsamalar = new System.Windows.Forms.DataGridView();
            this.lblAsamaAdi = new System.Windows.Forms.Label();
            this.lblPlanBitis = new System.Windows.Forms.Label();
            this.txtAsamaAdi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.dtpPlanBitis = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsamalar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(12, 12);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(79, 13);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Proje Aşamaları";
            // 
            // dgvAsamalar
            // 
            this.dgvAsamalar.AllowUserToAddRows = false;
            this.dgvAsamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsamalar.Location = new System.Drawing.Point(12, 45);
            this.dgvAsamalar.Name = "dgvAsamalar";
            this.dgvAsamalar.ReadOnly = true;
            this.dgvAsamalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAsamalar.Size = new System.Drawing.Size(760, 300);
            this.dgvAsamalar.TabIndex = 1;
            this.dgvAsamalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lblAsamaAdi
            // 
            this.lblAsamaAdi.AutoSize = true;
            this.lblAsamaAdi.Location = new System.Drawing.Point(12, 365);
            this.lblAsamaAdi.Name = "lblAsamaAdi";
            this.lblAsamaAdi.Size = new System.Drawing.Size(59, 13);
            this.lblAsamaAdi.TabIndex = 2;
            this.lblAsamaAdi.Text = "Aşama adı:";
            // 
            // lblPlanBitis
            // 
            this.lblPlanBitis.AutoSize = true;
            this.lblPlanBitis.Location = new System.Drawing.Point(250, 365);
            this.lblPlanBitis.Name = "lblPlanBitis";
            this.lblPlanBitis.Size = new System.Drawing.Size(78, 13);
            this.lblPlanBitis.TabIndex = 3;
            this.lblPlanBitis.Text = "Planlanan bitiş:";
            // 
            // txtAsamaAdi
            // 
            this.txtAsamaAdi.Location = new System.Drawing.Point(12, 385);
            this.txtAsamaAdi.Name = "txtAsamaAdi";
            this.txtAsamaAdi.Size = new System.Drawing.Size(220, 20);
            this.txtAsamaAdi.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(410, 382);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(110, 30);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Aşama Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(530, 382);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(130, 30);
            this.btnTamamla.TabIndex = 6;
            this.btnTamamla.Text = "Tamamlandı Yap";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(670, 382);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 30);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // dtpPlanBitis
            // 
            this.dtpPlanBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpPlanBitis.Location = new System.Drawing.Point(250, 385);
            this.dtpPlanBitis.Name = "dtpPlanBitis";
            this.dtpPlanBitis.Size = new System.Drawing.Size(140, 20);
            this.dtpPlanBitis.TabIndex = 8;
            // 
            // AsamaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 481);
            this.Controls.Add(this.dtpPlanBitis);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtAsamaAdi);
            this.Controls.Add(this.lblPlanBitis);
            this.Controls.Add(this.lblAsamaAdi);
            this.Controls.Add(this.dgvAsamalar);
            this.Controls.Add(this.lblBaslik);
            this.Name = "AsamaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Proje Aşamaları";
            this.Load += new System.EventHandler(this.AsamaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsamalar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dgvAsamalar;
        private System.Windows.Forms.Label lblAsamaAdi;
        private System.Windows.Forms.Label lblPlanBitis;
        private System.Windows.Forms.TextBox txtAsamaAdi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.DateTimePicker dtpPlanBitis;
    }
}