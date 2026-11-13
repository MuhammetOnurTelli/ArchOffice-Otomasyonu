namespace ArchOffice.Formlar
{
    partial class MusteriTakipForm
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
            this.lblProjeBaslik = new System.Windows.Forms.Label();
            this.lblAsamalar = new System.Windows.Forms.Label();
            this.lblOdemeler = new System.Windows.Forms.Label();
            this.cmbProje = new System.Windows.Forms.ComboBox();
            this.dgvAsamalar = new System.Windows.Forms.DataGridView();
            this.dgvOdemeler = new System.Windows.Forms.DataGridView();
            this.lblToplamOdeme = new System.Windows.Forms.Label();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsamalar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProjeBaslik
            // 
            this.lblProjeBaslik.AutoSize = true;
            this.lblProjeBaslik.Location = new System.Drawing.Point(20, 15);
            this.lblProjeBaslik.Name = "lblProjeBaslik";
            this.lblProjeBaslik.Size = new System.Drawing.Size(39, 13);
            this.lblProjeBaslik.TabIndex = 0;
            this.lblProjeBaslik.Text = "Projem";
            // 
            // lblAsamalar
            // 
            this.lblAsamalar.AutoSize = true;
            this.lblAsamalar.Location = new System.Drawing.Point(20, 80);
            this.lblAsamalar.Name = "lblAsamalar";
            this.lblAsamalar.Size = new System.Drawing.Size(50, 13);
            this.lblAsamalar.TabIndex = 1;
            this.lblAsamalar.Text = "Aşamalar";
            this.lblAsamalar.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOdemeler
            // 
            this.lblOdemeler.AutoSize = true;
            this.lblOdemeler.Location = new System.Drawing.Point(20, 270);
            this.lblOdemeler.Name = "lblOdemeler";
            this.lblOdemeler.Size = new System.Drawing.Size(52, 13);
            this.lblOdemeler.TabIndex = 2;
            this.lblOdemeler.Text = "Ödemeler";
            this.lblOdemeler.Click += new System.EventHandler(this.lblOdemeler_Click);
            // 
            // cmbProje
            // 
            this.cmbProje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProje.FormattingEnabled = true;
            this.cmbProje.Location = new System.Drawing.Point(20, 40);
            this.cmbProje.Name = "cmbProje";
            this.cmbProje.Size = new System.Drawing.Size(300, 21);
            this.cmbProje.TabIndex = 3;
            this.cmbProje.SelectedIndexChanged += new System.EventHandler(this.cmbProje_SelectedIndexChanged);
            // 
            // dgvAsamalar
            // 
            this.dgvAsamalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsamalar.Location = new System.Drawing.Point(20, 105);
            this.dgvAsamalar.Name = "dgvAsamalar";
            this.dgvAsamalar.Size = new System.Drawing.Size(650, 150);
            this.dgvAsamalar.TabIndex = 4;
            this.dgvAsamalar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // dgvOdemeler
            // 
            this.dgvOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeler.Location = new System.Drawing.Point(20, 295);
            this.dgvOdemeler.Name = "dgvOdemeler";
            this.dgvOdemeler.Size = new System.Drawing.Size(650, 130);
            this.dgvOdemeler.TabIndex = 5;
            // 
            // lblToplamOdeme
            // 
            this.lblToplamOdeme.AutoSize = true;
            this.lblToplamOdeme.Location = new System.Drawing.Point(20, 435);
            this.lblToplamOdeme.Name = "lblToplamOdeme";
            this.lblToplamOdeme.Size = new System.Drawing.Size(110, 13);
            this.lblToplamOdeme.TabIndex = 6;
            this.lblToplamOdeme.Text = "Toplam Ödeme : 0 TL";
            // 
            // btnKapat
            // 
            this.btnKapat.Location = new System.Drawing.Point(570, 440);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 30);
            this.btnKapat.TabIndex = 7;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click_1);
            // 
            // MusteriTakipForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 481);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.lblToplamOdeme);
            this.Controls.Add(this.dgvOdemeler);
            this.Controls.Add(this.dgvAsamalar);
            this.Controls.Add(this.cmbProje);
            this.Controls.Add(this.lblOdemeler);
            this.Controls.Add(this.lblAsamalar);
            this.Controls.Add(this.lblProjeBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MinimizeBox = false;
            this.Name = "MusteriTakipForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ArchOffice - Proje Takip";
            this.Load += new System.EventHandler(this.MusteriTakipForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsamalar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProjeBaslik;
        private System.Windows.Forms.Label lblAsamalar;
        private System.Windows.Forms.Label lblOdemeler;
        private System.Windows.Forms.ComboBox cmbProje;
        private System.Windows.Forms.DataGridView dgvAsamalar;
        private System.Windows.Forms.DataGridView dgvOdemeler;
        private System.Windows.Forms.Label lblToplamOdeme;
        private System.Windows.Forms.Button btnKapat;
    }
}