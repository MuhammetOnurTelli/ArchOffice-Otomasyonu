namespace ArchOffice.Formlar
{
    partial class ProjeTalebiForm
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
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblAlan = new System.Windows.Forms.Label();
            this.lblButce = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.lblHata = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtAlan = new System.Windows.Forms.TextBox();
            this.txtButce = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(30, 30);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(49, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Proje Adı";
            this.lblAd.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(30, 70);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(56, 13);
            this.lblTur.TabIndex = 1;
            this.lblTur.Text = "Proje Türü";
            // 
            // lblAlan
            // 
            this.lblAlan.AutoSize = true;
            this.lblAlan.Location = new System.Drawing.Point(30, 110);
            this.lblAlan.Name = "lblAlan";
            this.lblAlan.Size = new System.Drawing.Size(48, 13);
            this.lblAlan.TabIndex = 2;
            this.lblAlan.Text = "Alan (m²)";
            this.lblAlan.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblButce
            // 
            this.lblButce.AutoSize = true;
            this.lblButce.Location = new System.Drawing.Point(30, 150);
            this.lblButce.Name = "lblButce";
            this.lblButce.Size = new System.Drawing.Size(57, 13);
            this.lblButce.TabIndex = 3;
            this.lblButce.Text = "Bütçe (TL)";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(30, 190);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 4;
            this.lblAciklama.Text = "Açıklama";
            // 
            // lblHata
            // 
            this.lblHata.AutoSize = true;
            this.lblHata.ForeColor = System.Drawing.Color.Red;
            this.lblHata.Location = new System.Drawing.Point(30, 300);
            this.lblHata.Name = "lblHata";
            this.lblHata.Size = new System.Drawing.Size(0, 13);
            this.lblHata.TabIndex = 5;
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(140, 27);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(220, 20);
            this.txtAd.TabIndex = 6;
            this.txtAd.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtAlan
            // 
            this.txtAlan.Location = new System.Drawing.Point(140, 107);
            this.txtAlan.Name = "txtAlan";
            this.txtAlan.Size = new System.Drawing.Size(220, 20);
            this.txtAlan.TabIndex = 7;
            this.txtAlan.TextChanged += new System.EventHandler(this.txtAlan_TextChanged);
            // 
            // txtButce
            // 
            this.txtButce.Location = new System.Drawing.Point(140, 147);
            this.txtButce.Name = "txtButce";
            this.txtButce.Size = new System.Drawing.Size(220, 20);
            this.txtButce.TabIndex = 8;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(140, 187);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 80);
            this.txtAciklama.TabIndex = 9;
            // 
            // cmbTur
            // 
            this.cmbTur.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(140, 67);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(220, 21);
            this.cmbTur.TabIndex = 10;
            this.cmbTur.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(140, 290);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(120, 30);
            this.btnGonder.TabIndex = 11;
            this.btnGonder.Text = "Talebi Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(270, 290);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(90, 30);
            this.btnIptal.TabIndex = 12;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.button2_Click);
            // 
            // ProjeTalebiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 381);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtButce);
            this.Controls.Add(this.txtAlan);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblHata);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblButce);
            this.Controls.Add(this.lblAlan);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblAd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "ProjeTalebiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Yeni Proje Talebi";
            this.Load += new System.EventHandler(this.ProjeTalebiForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblAlan;
        private System.Windows.Forms.Label lblButce;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Label lblHata;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtAlan;
        private System.Windows.Forms.TextBox txtButce;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnIptal;
    }
}