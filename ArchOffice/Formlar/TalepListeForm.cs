using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArchOffice.Formlar
{
    public partial class TalepListeForm : Form
    {
        public TalepListeForm()
        {
            InitializeComponent();
        }

        private void TalepListeForm_Load(object sender, EventArgs e)
        {
            TalepleriYukle();
        }
        private void TalepleriYukle()
        {
            dgvTalepler.DataSource = Veriler.Getir(
                "SELECT t.Id, p.Ad AS Proje, u.AdSoyad AS Musteri, t.Baslik, t.Aciklama, t.Durum, t.Tarih FROM Talepler t JOIN Projeler p ON t.ProjeId = p.Id JOIN Musteriler m ON t.MusteriId = m.Id JOIN Kullanicilar u ON m.KullaniciId = u.Id WHERE (@rol = 'Yönetici' OR p.MimarId = @k) ORDER BY t.Id DESC",
                new System.Data.SQLite.SQLiteParameter("@rol", CurrentUser.Rol),
                new System.Data.SQLite.SQLiteParameter("@k", CurrentUser.Id));
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (dgvTalepler.CurrentRow == null)
            {
                MessageBox.Show("Bir talep seçin.");
                return;
            }
            int id = Convert.ToInt32(dgvTalepler.CurrentRow.Cells["Id"].Value);
            Veriler.Calistir("UPDATE Talepler SET Durum = 'Tamamlandı' WHERE Id = @i",
                new System.Data.SQLite.SQLiteParameter("@i", id));
            TalepleriYukle();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            TalepleriYukle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
