namespace ArchOffice.Formlar
{
    partial class RaporForm
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
            this.lblToplamProjeBaslik = new System.Windows.Forms.Label();
            this.lblToplamProje = new System.Windows.Forms.Label();
            this.lblBekleyenBaslik = new System.Windows.Forms.Label();
            this.lblBekleyen = new System.Windows.Forms.Label();
            this.lblButceBaslik = new System.Windows.Forms.Label();
            this.lblButce = new System.Windows.Forms.Label();
            this.lblOdemeBaslik = new System.Windows.Forms.Label();
            this.lblOdeme = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(30, 20);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(60, 13);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Genel Özet";
            this.lblBaslik.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblToplamProjeBaslik
            // 
            this.lblToplamProjeBaslik.AutoSize = true;
            this.lblToplamProjeBaslik.Location = new System.Drawing.Point(30, 70);
            this.lblToplamProjeBaslik.Name = "lblToplamProjeBaslik";
            this.lblToplamProjeBaslik.Size = new System.Drawing.Size(69, 13);
            this.lblToplamProjeBaslik.TabIndex = 1;
            this.lblToplamProjeBaslik.Text = "Toplam Proje";
            // 
            // lblToplamProje
            // 
            this.lblToplamProje.AutoSize = true;
            this.lblToplamProje.Location = new System.Drawing.Point(230, 70);
            this.lblToplamProje.Name = "lblToplamProje";
            this.lblToplamProje.Size = new System.Drawing.Size(13, 13);
            this.lblToplamProje.TabIndex = 2;
            this.lblToplamProje.Text = "0";
            // 
            // lblBekleyenBaslik
            // 
            this.lblBekleyenBaslik.AutoSize = true;
            this.lblBekleyenBaslik.Location = new System.Drawing.Point(30, 110);
            this.lblBekleyenBaslik.Name = "lblBekleyenBaslik";
            this.lblBekleyenBaslik.Size = new System.Drawing.Size(79, 13);
            this.lblBekleyenBaslik.TabIndex = 3;
            this.lblBekleyenBaslik.Text = "Onay Bekleyen";
            // 
            // lblBekleyen
            // 
            this.lblBekleyen.AutoSize = true;
            this.lblBekleyen.Location = new System.Drawing.Point(230, 110);
            this.lblBekleyen.Name = "lblBekleyen";
            this.lblBekleyen.Size = new System.Drawing.Size(13, 13);
            this.lblBekleyen.TabIndex = 4;
            this.lblBekleyen.Text = "0";
            // 
            // lblButceBaslik
            // 
            this.lblButceBaslik.AutoSize = true;
            this.lblButceBaslik.Location = new System.Drawing.Point(30, 150);
            this.lblButceBaslik.Name = "lblButceBaslik";
            this.lblButceBaslik.Size = new System.Drawing.Size(73, 13);
            this.lblButceBaslik.TabIndex = 5;
            this.lblButceBaslik.Text = "Toplam Bütçe";
            // 
            // lblButce
            // 
            this.lblButce.AutoSize = true;
            this.lblButce.Location = new System.Drawing.Point(230, 150);
            this.lblButce.Name = "lblButce";
            this.lblButce.Size = new System.Drawing.Size(13, 13);
            this.lblButce.TabIndex = 6;
            this.lblButce.Text = "0";
            // 
            // lblOdemeBaslik
            // 
            this.lblOdemeBaslik.AutoSize = true;
            this.lblOdemeBaslik.Location = new System.Drawing.Point(30, 190);
            this.lblOdemeBaslik.Name = "lblOdemeBaslik";
            this.lblOdemeBaslik.Size = new System.Drawing.Size(79, 13);
            this.lblOdemeBaslik.TabIndex = 7;
            this.lblOdemeBaslik.Text = "Toplam Ödeme";
            this.lblOdemeBaslik.Click += new System.EventHandler(this.label8_Click);
            // 
            // lblOdeme
            // 
            this.lblOdeme.AutoSize = true;
            this.lblOdeme.Location = new System.Drawing.Point(230, 190);
            this.lblOdeme.Name = "lblOdeme";
            this.lblOdeme.Size = new System.Drawing.Size(13, 13);
            this.lblOdeme.TabIndex = 8;
            this.lblOdeme.Text = "0";
            this.lblOdeme.Click += new System.EventHandler(this.label9_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(30, 250);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(110, 30);
            this.btnKapat.TabIndex = 9;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click_1);
            // 
            // RaporForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 321);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblOdeme);
            this.Controls.Add(this.lblOdemeBaslik);
            this.Controls.Add(this.lblButce);
            this.Controls.Add(this.lblButceBaslik);
            this.Controls.Add(this.lblBekleyen);
            this.Controls.Add(this.lblBekleyenBaslik);
            this.Controls.Add(this.lblToplamProje);
            this.Controls.Add(this.lblToplamProjeBaslik);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "RaporForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Raporlar";
            this.Load += new System.EventHandler(this.RaporForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Label lblToplamProjeBaslik;
        private System.Windows.Forms.Label lblToplamProje;
        private System.Windows.Forms.Label lblBekleyenBaslik;
        private System.Windows.Forms.Label lblBekleyen;
        private System.Windows.Forms.Label lblButceBaslik;
        private System.Windows.Forms.Label lblButce;
        private System.Windows.Forms.Label lblOdemeBaslik;
        private System.Windows.Forms.Label lblOdeme;
        private System.Windows.Forms.Button btnKapat;
    }
}