namespace ArchOffice.Formlar
{
    partial class MusteriTalepForm
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
            this.lblProje = new System.Windows.Forms.Label();
            this.cmbProje = new System.Windows.Forms.ComboBox();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtBaslik = new System.Windows.Forms.TextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProje
            // 
            this.lblProje.AutoSize = true;
            this.lblProje.Location = new System.Drawing.Point(20, 20);
            this.lblProje.Name = "lblProje";
            this.lblProje.Size = new System.Drawing.Size(31, 13);
            this.lblProje.TabIndex = 0;
            this.lblProje.Text = "Proje";
            // 
            // cmbProje
            // 
            this.cmbProje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProje.FormattingEnabled = true;
            this.cmbProje.Location = new System.Drawing.Point(20, 45);
            this.cmbProje.Name = "cmbProje";
            this.cmbProje.Size = new System.Drawing.Size(380, 21);
            this.cmbProje.TabIndex = 1;
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(20, 85);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(35, 13);
            this.lblBaslik.TabIndex = 2;
            this.lblBaslik.Text = "Başlık";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(20, 150);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 3;
            this.lblAciklama.Text = "Açıklama";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(20, 175);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(380, 120);
            this.txtAciklama.TabIndex = 4;
            // 
            // txtBaslik
            // 
            this.txtBaslik.Location = new System.Drawing.Point(20, 110);
            this.txtBaslik.Name = "txtBaslik";
            this.txtBaslik.Size = new System.Drawing.Size(380, 20);
            this.txtBaslik.TabIndex = 5;
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(20, 310);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(100, 30);
            this.btnGonder.TabIndex = 6;
            this.btnGonder.Text = "Gönder";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(300, 310);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 30);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // MusteriTalepForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 361);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.txtBaslik);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.cmbProje);
            this.Controls.Add(this.lblProje);
            this.MaximizeBox = false;
            this.Name = "MusteriTalepForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Revizyon Talebi";
            this.Load += new System.EventHandler(this.MusteriTalepForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProje;
        private System.Windows.Forms.ComboBox cmbProje;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtBaslik;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Button btnKapat;
    }
}