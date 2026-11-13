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
    public partial class YoneticiProjeForm : Form
    {
        public YoneticiProjeForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

            private void btnOnayla_Click(object sender, EventArgs e)

        {
            DurumDegistir("Onaylandı");
        }

        private void DurumDegistir(string yeniDurum)
        {
            if (dgvProjeler.CurrentRow == null)
            {
                MessageBox.Show("Önce bir proje seçin.");
                return;
            }

            int projeId = Convert.ToInt32(dgvProjeler.CurrentRow.Cells["Id"].Value);

            Veriler.Calistir(
                "UPDATE Projeler SET Durum = @durum WHERE Id = @id",
                new SQLiteParameter("@durum", yeniDurum),
                new SQLiteParameter("@id", projeId));

            ProjeleriYukle();
        }
        

        private void YoneticiProjeForm_Load(object sender, EventArgs e)
        {
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
          ORDER BY p.Id DESC");
        }

        private void btnReddet_Click(object sender, EventArgs e)
        {
            DurumDegistir("Reddedildi");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            ProjeleriYukle();
        }
    }
    }

