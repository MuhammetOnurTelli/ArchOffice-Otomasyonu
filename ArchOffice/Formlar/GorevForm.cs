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
    public partial class GorevForm : Form
    {
        public GorevForm()
        {
            InitializeComponent();
            GorevleriYukle();
        }
        private int _projeId;

        public GorevForm(int projeId) : this()
        {
            _projeId = projeId;
        }

        private void GorevleriYukle()
        {
            dgvGorevler.DataSource = Veriler.Getir(
                @"SELECT Id, Baslik, Durum, SonTarih
          FROM Gorevler
          WHERE ProjeId = @p
          ORDER BY SonTarih",
                new SQLiteParameter("@p", _projeId));
        }

        private void GorevForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string baslik = txtGorevBaslik.Text.Trim();
            if (baslik == "")
            {
                MessageBox.Show("Görev adı boş olamaz.");
                return;
            }

            Veriler.Calistir(
                "INSERT INTO Gorevler (ProjeId, MimarId, Baslik, Durum, SonTarih) VALUES (@p, @m, @b, 'Bekliyor', @t)",
                new SQLiteParameter("@p", _projeId),
                new SQLiteParameter("@m", CurrentUser.Id),
                new SQLiteParameter("@b", baslik),
                new SQLiteParameter("@t", dtpSonTarih.Value.ToString("yyyy-MM-dd")));

            txtGorevBaslik.Text = "";
            GorevleriYukle();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (dgvGorevler.CurrentRow == null)
            {
                MessageBox.Show("Önce bir görev seçin.");
                return;
            }

            int gorevId = Convert.ToInt32(dgvGorevler.CurrentRow.Cells["Id"].Value);

            Veriler.Calistir(
                "UPDATE Gorevler SET Durum = 'Tamamlandı' WHERE Id = @id",
                new SQLiteParameter("@id", gorevId));

            GorevleriYukle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
