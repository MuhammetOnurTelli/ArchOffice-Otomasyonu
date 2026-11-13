namespace ArchOffice.Formlar
{
    partial class TalepListeForm
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
            this.dgvTalepler = new System.Windows.Forms.DataGridView();
            this.btnTamamla = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalepler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTalepler
            // 
            this.dgvTalepler.AllowUserToAddRows = false;
            this.dgvTalepler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTalepler.Location = new System.Drawing.Point(20, 20);
            this.dgvTalepler.MultiSelect = false;
            this.dgvTalepler.Name = "dgvTalepler";
            this.dgvTalepler.ReadOnly = true;
            this.dgvTalepler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTalepler.Size = new System.Drawing.Size(640, 300);
            this.dgvTalepler.TabIndex = 0;
            // 
            // btnTamamla
            // 
            this.btnTamamla.Location = new System.Drawing.Point(20, 335);
            this.btnTamamla.Name = "btnTamamla";
            this.btnTamamla.Size = new System.Drawing.Size(150, 30);
            this.btnTamamla.TabIndex = 1;
            this.btnTamamla.Text = "Tamamlandı İşarete";
            this.btnTamamla.UseVisualStyleBackColor = true;
            this.btnTamamla.Click += new System.EventHandler(this.btnTamamla_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(190, 335);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(100, 30);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(560, 335);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 30);
            this.btnKapat.TabIndex = 3;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // TalepListeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnTamamla);
            this.Controls.Add(this.dgvTalepler);
            this.Location = new System.Drawing.Point(700, 450);
            this.MinimizeBox = false;
            this.Name = "TalepListeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Revizyon Talepleri";
            this.Load += new System.EventHandler(this.TalepListeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTalepler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTalepler;
        private System.Windows.Forms.Button btnTamamla;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnKapat;
    }
}