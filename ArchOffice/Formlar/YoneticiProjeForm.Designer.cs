namespace ArchOffice.Formlar
{
    partial class YoneticiProjeForm
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
            this.dgvProjeler = new System.Windows.Forms.DataGridView();
            this.btnOnayla = new System.Windows.Forms.Button();
            this.btnReddet = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.cmbMimar = new System.Windows.Forms.ComboBox();
            this.btnMimarAta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Location = new System.Drawing.Point(12, 12);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(42, 13);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Projeler";
            this.lblBaslik.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvProjeler
            // 
            this.dgvProjeler.AllowUserToAddRows = false;
            this.dgvProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjeler.Location = new System.Drawing.Point(12, 40);
            this.dgvProjeler.MultiSelect = false;
            this.dgvProjeler.Name = "dgvProjeler";
            this.dgvProjeler.ReadOnly = true;
            this.dgvProjeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjeler.Size = new System.Drawing.Size(780, 380);
            this.dgvProjeler.TabIndex = 1;
            // 
            // btnOnayla
            // 
            this.btnOnayla.Location = new System.Drawing.Point(12, 430);
            this.btnOnayla.Name = "btnOnayla";
            this.btnOnayla.Size = new System.Drawing.Size(110, 30);
            this.btnOnayla.TabIndex = 2;
            this.btnOnayla.Text = "Onayla";
            this.btnOnayla.UseVisualStyleBackColor = true;
            this.btnOnayla.Click += new System.EventHandler(this.btnOnayla_Click);
            // 
            // btnReddet
            // 
            this.btnReddet.Location = new System.Drawing.Point(130, 430);
            this.btnReddet.Name = "btnReddet";
            this.btnReddet.Size = new System.Drawing.Size(110, 30);
            this.btnReddet.TabIndex = 3;
            this.btnReddet.Text = "Reddet";
            this.btnReddet.UseVisualStyleBackColor = true;
            this.btnReddet.Click += new System.EventHandler(this.btnReddet_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(250, 430);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(110, 30);
            this.btnYenile.TabIndex = 4;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // cmbMimar
            // 
            this.cmbMimar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMimar.FormattingEnabled = true;
            this.cmbMimar.Location = new System.Drawing.Point(380, 433);
            this.cmbMimar.Name = "cmbMimar";
            this.cmbMimar.Size = new System.Drawing.Size(180, 21);
            this.cmbMimar.TabIndex = 5;
            // 
            // btnMimarAta
            // 
            this.btnMimarAta.Location = new System.Drawing.Point(570, 430);
            this.btnMimarAta.Name = "btnMimarAta";
            this.btnMimarAta.Size = new System.Drawing.Size(110, 30);
            this.btnMimarAta.TabIndex = 6;
            this.btnMimarAta.Text = "Mimar Ata";
            this.btnMimarAta.UseVisualStyleBackColor = true;
            this.btnMimarAta.Click += new System.EventHandler(this.btnMimarAta_Click);
            // 
            // YoneticiProjeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 481);
            this.Controls.Add(this.btnMimarAta);
            this.Controls.Add(this.cmbMimar);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnReddet);
            this.Controls.Add(this.btnOnayla);
            this.Controls.Add(this.dgvProjeler);
            this.Controls.Add(this.lblBaslik);
            this.Name = "YoneticiProjeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Proje Onayı";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.YoneticiProjeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dgvProjeler;
        private System.Windows.Forms.Button btnOnayla;
        private System.Windows.Forms.Button btnReddet;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.ComboBox cmbMimar;
        private System.Windows.Forms.Button btnMimarAta;
    }
}