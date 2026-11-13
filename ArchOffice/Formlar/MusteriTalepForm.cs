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
    public partial class MusteriTalepForm : Form
    {
        public MusteriTalepForm()
        {
            InitializeComponent();
        }

        private void MusteriTalepForm_Load(object sender, EventArgs e)
        {
            cmbProje.DisplayMember = "Ad";
            cmbProje.ValueMember = "Id";
            cmbProje.DataSource = Veriler.Getir(
                "SELECT p.Id, p.Ad FROM Projeler p JOIN Musteriler m ON p.MusteriId = m.Id WHERE m.KullaniciId = @k ORDER BY p.Ad",
                new System.Data.SQLite.SQLiteParameter("@k", CurrentUser.Id));
        }

        private void btnGonder_Click(object sender, EventArgs e)
        {
            if (cmbProje.SelectedValue == null || txtBaslik.Text.Trim() == "")
            {
                MessageBox.Show("Proje seçin ve başlık yazın.");
                return;
            }
            Veriler.Calistir(
                "INSERT INTO Talepler (MusteriId, ProjeId, Baslik, Aciklama, Durum, Tarih) VALUES ((SELECT Id FROM Musteriler WHERE KullaniciId = @k), @p, @b, @a, 'Beklemede', @t)",
                new System.Data.SQLite.SQLiteParameter("@k", CurrentUser.Id),
                new System.Data.SQLite.SQLiteParameter("@p", Convert.ToInt32(cmbProje.SelectedValue)),
                new System.Data.SQLite.SQLiteParameter("@b", txtBaslik.Text.Trim()),
                new System.Data.SQLite.SQLiteParameter("@a", txtAciklama.Text.Trim()),
                new System.Data.SQLite.SQLiteParameter("@t", DateTime.Now.ToString("yyyy-MM-dd")));
            MessageBox.Show("Talebiniz gönderildi.");
            txtBaslik.Clear();
            txtAciklama.Clear();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
