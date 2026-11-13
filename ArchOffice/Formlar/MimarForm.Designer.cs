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
            this.dgvProjeler.Size = new System.Drawing.Size(700, 350);
            this.dgvProjeler.TabIndex = 1;
            // 
            // btnYenile
            // 
            this.btnYenile.Location = new System.Drawing.Point(12, 410);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(110, 30);
            this.btnYenile.TabIndex = 2;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(132, 410);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(110, 30);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnAsamalar
            // 
            this.btnAsamalar.Location = new System.Drawing.Point(252, 410);
            this.btnAsamalar.Name = "btnAsamalar";
            this.btnAsamalar.Size = new System.Drawing.Size(140, 30);
            this.btnAsamalar.TabIndex = 4;
            this.btnAsamalar.Text = "Aşamaları Yönet";
            this.btnAsamalar.UseVisualStyleBackColor = true;
            this.btnAsamalar.Click += new System.EventHandler(this.button1_Click);
            // 
            // MimarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}