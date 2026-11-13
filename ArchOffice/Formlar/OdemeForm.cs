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
    public partial class OdemeForm : Form
    {
        public OdemeForm()
        {
            InitializeComponent();
        }
        private int _projeId;

        public OdemeForm(int projeId) : this()
        {
            _projeId = projeId;
        }

        private void OdemeleriYukle()
        {
            dgvOdemeler.DataSource = Veriler.Getir(
                @"SELECT Id, Tutar, Tarih, Tur, Aciklama
          FROM Odemeler
          WHERE ProjeId = @p
          ORDER BY Tarih DESC, Id DESC",
                new SQLiteParameter("@p", _projeId));

            DataTable dt = Veriler.Getir(
                "SELECT IFNULL(SUM(Tutar), 0) AS Toplam FROM Odemeler WHERE ProjeId = @p",
                new SQLiteParameter("@p", _projeId));
            double toplam = Convert.ToDouble(dt.Rows[0]["Toplam"]);

            lblToplam.Text = "Toplam ödeme: " + toplam.ToString("N2") + " TL";
        }

        private void dgvOdemeler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void OdemeForm_Load(object sender, EventArgs e)
        {
            cmbTur.Items.AddRange(new object[] { "Avans", "Taksit", "Final", "Diğer" });
            cmbTur.SelectedIndex = 0;
            OdemeleriYukle();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            double tutar;
            if (!double.TryParse(txtTutar.Text.Trim(), out tutar) || tutar <= 0)
            {
                MessageBox.Show("Geçerli bir tutar girin (örnek: 50000).");
                return;
            }

            DataTable dt = Veriler.Getir(
                "SELECT MusteriId FROM Projeler WHERE Id = @p",
                new SQLiteParameter("@p", _projeId));
            int musteriId = Convert.ToInt32(dt.Rows[0]["MusteriId"]);

            Veriler.Calistir(
                "INSERT INTO Odemeler (ProjeId, MusteriId, Tutar, Tarih, Tur, Aciklama) VALUES (@p, @m, @t, @d, @tur, @a)",
                new SQLiteParameter("@p", _projeId),
                new SQLiteParameter("@m", musteriId),
                new SQLiteParameter("@t", tutar),
                new SQLiteParameter("@d", DateTime.Now.ToString("yyyy-MM-dd")),
                new SQLiteParameter("@tur", cmbTur.SelectedItem.ToString()),
                new SQLiteParameter("@a", txtAciklama.Text.Trim()));

            txtTutar.Text = "";
            txtAciklama.Text = "";
            OdemeleriYukle();
        }
    }
}
