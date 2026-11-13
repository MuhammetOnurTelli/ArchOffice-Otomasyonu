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
    public partial class MimarForm : Form
    {
        public MimarForm()
        {
            InitializeComponent();
        }

        private void MimarForm_Load(object sender, EventArgs e)
        {
            lblHosgeldin.Text = "Hoş geldiniz, " + CurrentUser.AdSoyad;
            ProjeleriYukle();
        }
        private void ProjeleriYukle()
        {
            dgvProjeler.DataSource = Veriler.Getir(
                @"SELECT p.Id, p.Ad, u.AdSoyad AS Musteri, p.Tur,
                 p.Alan_m2, p.Butce, p.Durum
          FROM Projeler p
          JOIN Musteriler m ON p.MusteriId = m.Id
          JOIN Kullanicilar u ON m.KullaniciId = u.Id
          WHERE p.MimarId = @mimar
          ORDER BY p.Id DESC",
                new SQLiteParameter("@mimar", CurrentUser.Id));
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ProjeleriYukle();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvProjeler.CurrentRow == null)
            {
                MessageBox.Show("Önce bir proje seçin.");
                return;
            }

            int projeId = Convert.ToInt32(dgvProjeler.CurrentRow.Cells["Id"].Value);
            new AsamaForm(projeId).ShowDialog();
        }

        private void btnGorevler_Click(object sender, EventArgs e)
        {
            if (dgvProjeler.CurrentRow == null)
            {
                MessageBox.Show("Önce bir proje seçin.");
                return;
            }

            int projeId = Convert.ToInt32(dgvProjeler.CurrentRow.Cells["Id"].Value);
            new GorevForm(projeId).ShowDialog();
        }
    }
}
