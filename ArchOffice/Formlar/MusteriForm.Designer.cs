namespace ArchOffice.Formlar
{
    partial class MusteriForm
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
            this.btnYeniProje = new System.Windows.Forms.Button();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTakip = new System.Windows.Forms.Button();
            this.btnTalep = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Location = new System.Drawing.Point(12, 12);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(35, 13);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "label1";
            this.lblHosgeldin.Click += new System.EventHandler(this.label1_Click);
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
            this.dgvProjeler.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // btnYeniProje
            // 
            this.btnYeniProje.Location = new System.Drawing.Point(12, 430);
            this.btnYeniProje.Name = "btnYeniProje";
            this.btnYeniProje.Size = new System.Drawing.Size(120, 30);
            this.btnYeniProje.TabIndex = 2;
            this.btnYeniProje.Text = "Yeni Proje Talebi";
            this.btnYeniProje.UseVisualStyleBackColor = true;
            this.btnYeniProje.Click += new System.EventHandler(this.btnYeniProje_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(152, 430);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(120, 30);
            this.btnYenile.TabIndex = 3;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(292, 430);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(120, 30);
            this.btnCikis.TabIndex = 4;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTakip
            // 
            this.btnTakip.Location = new System.Drawing.Point(432, 430);
            this.btnTakip.Name = "btnTakip";
            this.btnTakip.Size = new System.Drawing.Size(120, 30);
            this.btnTakip.TabIndex = 5;
            this.btnTakip.Text = "Proje Takip";
            this.btnTakip.UseVisualStyleBackColor = true;
            this.btnTakip.Click += new System.EventHandler(this.btnTakip_Click);
            // 
            // btnTalep
            // 
            this.btnTalep.Location = new System.Drawing.Point(572, 430);
            this.btnTalep.Name = "btnTalep";
            this.btnTalep.Size = new System.Drawing.Size(120, 30);
            this.btnTalep.TabIndex = 6;
            this.btnTalep.Text = "Revizyon Talebi";
            this.btnTalep.UseVisualStyleBackColor = true;
            this.btnTalep.Click += new System.EventHandler(this.btnTalep_Click);
            // 
            // MusteriForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 471);
            this.Controls.Add(this.btnTalep);
            this.Controls.Add(this.btnTakip);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.btnYeniProje);
            this.Controls.Add(this.dgvProjeler);
            this.Controls.Add(this.lblHosgeldin);
            this.Name = "MusteriForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Müşteri Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MusteriForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.DataGridView dgvProjeler;
        private System.Windows.Forms.Button btnYeniProje;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTakip;
        private System.Windows.Forms.Button btnTalep;
    }
}