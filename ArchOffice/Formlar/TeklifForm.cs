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
    public partial class TeklifForm : Form
    {
        public TeklifForm()
        {
            InitializeComponent();
        }
        private int _projeId;
        private int _teklifId;

        public TeklifForm(int projeId) : this()
        {
            _projeId = projeId;
        }

        private int TeklifIdBul()
        {
            string sql = "SELECT Id FROM Teklifler WHERE ProjeId = @p ORDER BY Id DESC LIMIT 1";
            DataTable dt = Veriler.Getir(sql, new SQLiteParameter("@p", _projeId));

            if (dt.Rows.Count == 0)
            {
                Veriler.Calistir(
                    "INSERT INTO Teklifler (ProjeId, Tarih, ToplamTutar, Durum) VALUES (@p, @t, 0, 'Taslak')",
                    new SQLiteParameter("@p", _projeId),
                    new SQLiteParameter("@t", DateTime.Now.ToString("yyyy-MM-dd")));
                dt = Veriler.Getir(sql, new SQLiteParameter("@p", _projeId));
            }
            return Convert.ToInt32(dt.Rows[0]["Id"]);
        }

        private void MalzemeleriYukle()
        {
            cmbMalzeme.DataSource = Veriler.Getir("SELECT Id, Ad FROM Malzemeler ORDER BY Ad");
            cmbMalzeme.DisplayMember = "Ad";
            cmbMalzeme.ValueMember = "Id";
        }

        private void KalemleriYukle()
        {
            dgvKalemler.DataSource = Veriler.Getir(
                @"SELECT k.Id, m.Ad AS Malzeme, m.Birim, k.Miktar, k.BirimFiyat, k.Tutar
          FROM TeklifKalemleri k
          JOIN Malzemeler m ON k.MalzemeId = m.Id
          WHERE k.TeklifId = @t",
                new SQLiteParameter("@t", _teklifId));

            DataTable dt = Veriler.Getir(
                "SELECT IFNULL(SUM(Tutar), 0) AS Toplam FROM TeklifKalemleri WHERE TeklifId = @t",
                new SQLiteParameter("@t", _teklifId));
            double toplam = Convert.ToDouble(dt.Rows[0]["Toplam"]);

            lblToplam.Text = "Toplam: " + toplam.ToString("N2") + " TL";

            Veriler.Calistir(
                "UPDATE Teklifler SET ToplamTutar = @tt WHERE Id = @id",
                new SQLiteParameter("@tt", toplam),
                new SQLiteParameter("@id", _teklifId));
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void TeklifForm_Load(object sender, EventArgs e)
        {
            _teklifId = TeklifIdBul();
            MalzemeleriYukle();
            KalemleriYukle();
        }

        private void btnKalemEkle_Click(object sender, EventArgs e)
        {
            if (cmbMalzeme.SelectedValue == null)
            {
                MessageBox.Show("Önce bir malzeme seçin.");
                return;
            }

            double miktar;
            if (!double.TryParse(txtMiktar.Text.Trim(), out miktar) || miktar <= 0)
            {
                MessageBox.Show("Geçerli bir miktar girin (örnek: 25 veya 2,5).");
                return;
            }

            int malzemeId = Convert.ToInt32(cmbMalzeme.SelectedValue);

            DataTable dt = Veriler.Getir(
                "SELECT BirimFiyat FROM Malzemeler WHERE Id = @id",
                new SQLiteParameter("@id", malzemeId));
            double birimFiyat = Convert.ToDouble(dt.Rows[0]["BirimFiyat"]);

            Veriler.Calistir(
                "INSERT INTO TeklifKalemleri (TeklifId, MalzemeId, Miktar, BirimFiyat, Tutar) VALUES (@t, @m, @mik, @bf, @tutar)",
                new SQLiteParameter("@t", _teklifId),
                new SQLiteParameter("@m", malzemeId),
                new SQLiteParameter("@mik", miktar),
                new SQLiteParameter("@bf", birimFiyat),
                new SQLiteParameter("@tutar", miktar * birimFiyat));

            txtMiktar.Text = "";
            KalemleriYukle();
        }

        private void btnKalemSil_Click(object sender, EventArgs e)
        {
            if (dgvKalemler.CurrentRow == null)
            {
                MessageBox.Show("Önce bir kalem seçin.");
                return;
            }

            int kalemId = Convert.ToInt32(dgvKalemler.CurrentRow.Cells["Id"].Value);

            Veriler.Calistir(
                "DELETE FROM TeklifKalemleri WHERE Id = @id",
                new SQLiteParameter("@id", kalemId));

            KalemleriYukle();
        }
    }
}
