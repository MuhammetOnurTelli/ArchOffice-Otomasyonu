namespace ArchOffice.Formlar
{
    partial class MimarForm
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
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.dgvProjeler = new System.Windows.Forms.DataGridView();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnAsamalar = new System.Windows.Forms.Button();
            this.btnGorevler = new System.Windows.Forms.Button();
            this.btnTeklif = new System.Windows.Forms.Button();
            this.btnTalepler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Location = new System.Drawing.Point(12, 12);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(64, 13);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "Hoş geldiniz";
            // 
            // dgvProjeler
            // 
            this.dgvProjeler.AllowUserToAddRows = false;
            this.dgvProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjeler.Location = new System.Drawing.Point(12, 45);
            this.dgvProjeler.Name = "dgvProjeler";
            this.dgvProjeler.ReadOnly = true;
            this.dgvProjeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProjeler.Size = new System.Drawing.Size(770, 350);
            this.dgvProjeler.TabIndex = 1;
            this.dgvProjeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjeler_CellContentClick);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(12, 410);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(120, 30);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(142, 410);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(120, 30);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAsamalar
            // 
            this.btnAsamalar.Location = new System.Drawing.Point(272, 410);
            this.btnAsamalar.Name = "btnAsamalar";
            this.btnAsamalar.Size = new System.Drawing.Size(120, 30);
            this.btnAsamalar.TabIndex = 4;
            this.btnAsamalar.Text = "Aşamaları Yönet";
            this.btnAsamalar.UseVisualStyleBackColor = true;
            this.btnAsamalar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGorevler
            // 
            this.btnGorevler.Location = new System.Drawing.Point(402, 410);
            this.btnGorevler.Name = "btnGorevler";
            this.btnGorevler.Size = new System.Drawing.Size(120, 30);
            this.btnGorevler.TabIndex = 5;
            this.btnGorevler.Text = "Görevler";
            this.btnGorevler.UseVisualStyleBackColor = true;
            this.btnGorevler.Click += new System.EventHandler(this.btnGorevler_Click);
            // 
            // btnTeklif
            // 
            this.btnTeklif.Location = new System.Drawing.Point(532, 410);
            this.btnTeklif.Name = "btnTeklif";
            this.btnTeklif.Size = new System.Drawing.Size(120, 30);
            this.btnTeklif.TabIndex = 6;
            this.btnTeklif.Text = "Teklif / Metraj";
            this.btnTeklif.UseVisualStyleBackColor = true;
            this.btnTeklif.Click += new System.EventHandler(this.btnTeklif_Click);
            // 
            // btnTalepler
            // 
            this.btnTalepler.Location = new System.Drawing.Point(662, 410);
            this.btnTalepler.Name = "btnTalepler";
            this.btnTalepler.Size = new System.Drawing.Size(120, 30);
            this.btnTalepler.TabIndex = 7;
            this.btnTalepler.Text = "Revizyon Talepleri";
            this.btnTalepler.UseVisualStyleBackColor = true;
            this.btnTalepler.Click += new System.EventHandler(this.btnTalepler_Click);
            // 
            // MimarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTalepler);
            this.Controls.Add(this.btnTeklif);
            this.Controls.Add(this.btnGorevler);
            this.Controls.Add(this.btnAsamalar);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.dgvProjeler);
            this.Controls.Add(this.lblHosgeldin);
            this.Name = "MimarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Mimar Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MimarForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.DataGridView dgvProjeler;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnAsamalar;
        private System.Windows.Forms.Button btnGorevler;
        private System.Windows.Forms.Button btnTeklif;
        private System.Windows.Forms.Button btnTalepler;
    }
}