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
    public partial class YoneticiForm : Form
    {
        public YoneticiForm()
        {
            InitializeComponent();
        }

        private void YoneticiForm_Load(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = Veriler.Getir("SELECT Id, KullaniciAdi, AdSoyad, Rol, Telefon, Email, Aktif FROM Kullanicilar");
        }

        private void btnAktifPasif_Click(object sender, EventArgs e)
        {
            if (dgvKullanicilar.CurrentRow == null)
            {
                MessageBox.Show("Önce tablodan bir kullanıcı seçin.");
                return;
            }

            var satir = dgvKullanicilar.CurrentRow;
            if (satir.Cells["Rol"].Value.ToString() == "Yönetici")
            {
                MessageBox.Show("Yönetici hesabı pasif yapılamaz.");
                return;
            }

            int yeniDurum = Convert.ToInt32(satir.Cells["Aktif"].Value) == 1 ? 0 : 1;
            Veriler.Calistir("UPDATE Kullanicilar SET Aktif = @a WHERE Id = @id",
                new SQLiteParameter("@a", yeniDurum),
                new SQLiteParameter("@id", Convert.ToInt32(satir.Cells["Id"].Value)));

            dgvKullanicilar.DataSource = Veriler.Getir("SELECT Id, KullaniciAdi, AdSoyad, Rol, Telefon, Email, Aktif FROM Kullanicilar");
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            dgvKullanicilar.DataSource = Veriler.Getir("SELECT Id, KullaniciAdi, AdSoyad, Rol, Telefon, Email, Aktif FROM Kullanicilar");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new YoneticiProjeForm().ShowDialog();
        }
    }
}
