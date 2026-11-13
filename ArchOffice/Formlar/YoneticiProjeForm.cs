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
            MimarlariYukle();
        }

        private void ProjeleriYukle()
        {
            dgvProjeler.DataSource = Veriler.Getir(
                @"SELECT p.Id, p.Ad, u.AdSoyad AS Musteri, ma.AdSoyad AS Mimar,
                 p.Tur, p.Alan_m2, p.Butce, p.Durum
          FROM Projeler p
          JOIN Musteriler m ON p.MusteriId = m.Id
          JOIN Kullanicilar u ON m.KullaniciId = u.Id
          LEFT JOIN Kullanicilar ma ON p.MimarId = ma.Id
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
        private void MimarlariYukle()
        {
            DataTable dt = Veriler.Getir(
                "SELECT Id, AdSoyad FROM Kullanicilar WHERE Rol = 'Mimar' AND Aktif = 1");
            cmbMimar.DataSource = dt;
            cmbMimar.DisplayMember = "AdSoyad";
            cmbMimar.ValueMember = "Id";
        }

        private void btnMimarAta_Click(object sender, EventArgs e)
        {
            if (dgvProjeler.CurrentRow == null || cmbMimar.SelectedValue == null)
            {
                MessageBox.Show("Önce bir proje ve bir mimar seçin.");
                return;
            }

            int projeId = Convert.ToInt32(dgvProjeler.CurrentRow.Cells["Id"].Value);
            int mimarId = Convert.ToInt32(cmbMimar.SelectedValue);

            Veriler.Calistir(
                "UPDATE Projeler SET MimarId = @mimar WHERE Id = @id",
                new SQLiteParameter("@mimar", mimarId),
                new SQLiteParameter("@id", projeId));

            MessageBox.Show("Mimar atandı.");
            ProjeleriYukle();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            if (dgvProjeler.CurrentRow == null)
            {
                MessageBox.Show("Önce bir proje seçin.");
                return;
            }

            int projeId = Convert.ToInt32(dgvProjeler.CurrentRow.Cells["Id"].Value);
            new OdemeForm(projeId).ShowDialog();
        }
    }
    }

