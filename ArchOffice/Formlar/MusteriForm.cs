using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchOffice.Formlar
{
    public partial class MusteriForm : Form
    {
        public MusteriForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void MusteriForm_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = "Hoş geldiniz, " + CurrentUser.AdSoyad;
            ProjeleriYukle();
        }
        private void ProjeleriYukle()
        {
            dgvProjeler.DataSource = Veriler.Getir(
                "SELECT p.Id, p.Ad, p.Tur, p.Alan_m2, p.Butce, p.Durum FROM Projeler p JOIN Musteriler m ON p.MusteriId = m.Id WHERE m.KullaniciId = @id",
                new SQLiteParameter("@id", CurrentUser.Id));
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ProjeleriYukle();
        }

        private void btnYeniProje_Click(object sender, EventArgs e)
        {
            new ProjeTalebiForm().ShowDialog();
            ProjeleriYukle();
        }

        private void btnTakip_Click(object sender, EventArgs e)
        {
            new MusteriTakipForm().ShowDialog();
        }

        private void btnTalep_Click(object sender, EventArgs e)
        {
            new MusteriTalepForm().ShowDialog();
        }
    }
}
