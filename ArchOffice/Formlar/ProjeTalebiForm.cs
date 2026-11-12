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
    public partial class ProjeTalebiForm : Form
    {
        public ProjeTalebiForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ProjeTalebiForm_Load(object sender, EventArgs e)
        {
            cmbTur.Items.AddRange(new object[] { "Konut", "Villa", "Ticari", "İç Mekan", "Restorasyon" });
            cmbTur.SelectedIndex = 0;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtAlan_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text.Trim();
            if (ad == "")
            {
                lblHata.Text = "Proje adı boş olamaz.";
                return;
            }
            if (!decimal.TryParse(txtAlan.Text, out decimal alan) || alan <= 0)
            {
                lblHata.Text = "Alan için geçerli bir sayı girin.";
                return;
            }
            if (!decimal.TryParse(txtButce.Text, out decimal butce) || butce < 0)
            {
                lblHata.Text = "Bütçe için geçerli bir sayı girin.";
                return;
            }

            var musteri = Veriler.Getir("SELECT Id FROM Musteriler WHERE KullaniciId = @k",
                new SQLiteParameter("@k", CurrentUser.Id));
            if (musteri.Rows.Count == 0)
            {
                lblHata.Text = "Müşteri kaydı bulunamadı.";
                return;
            }
            int musteriId = Convert.ToInt32(musteri.Rows[0]["Id"]);
            string bugun = DateTime.Now.ToString("yyyy-MM-dd");

            Veriler.Calistir("INSERT INTO Projeler (MusteriId, Ad, Tur, Alan_m2, Butce, Durum, BaslangicTarihi) VALUES (@m, @ad, @tur, @alan, @butce, 'Onay Bekliyor', @t)",
                new SQLiteParameter("@m", musteriId),
                new SQLiteParameter("@ad", ad),
                new SQLiteParameter("@tur", cmbTur.Text),
                new SQLiteParameter("@alan", alan),
                new SQLiteParameter("@butce", butce),
                new SQLiteParameter("@t", bugun));

            var proje = Veriler.Getir("SELECT MAX(Id) AS Id FROM Projeler WHERE MusteriId = @m",
                new SQLiteParameter("@m", musteriId));
            Veriler.Calistir("INSERT INTO Talepler (MusteriId, ProjeId, Baslik, Aciklama, Durum, Tarih) VALUES (@m, @p, @b, @a, 'Açık', @t)",
                new SQLiteParameter("@m", musteriId),
                new SQLiteParameter("@p", Convert.ToInt32(proje.Rows[0]["Id"])),
                new SQLiteParameter("@b", "Yeni proje talebi: " + ad),
                new SQLiteParameter("@a", txtAciklama.Text.Trim()),
                new SQLiteParameter("@t", bugun));

            MessageBox.Show("Talebiniz alındı. Yönetici onayından sonra projeniz başlayacak.");
            Close();
        }
    }
}
