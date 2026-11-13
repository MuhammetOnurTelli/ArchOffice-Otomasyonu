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
    public partial class MusteriTakipForm : Form
    {
        public MusteriTakipForm()
        {
            InitializeComponent();
        }
        private void label2_Click(object sender, EventArgs e)
        {
        }
        private void MusteriTakipForm_Load(object sender, EventArgs e)
        {
            DataTable dt = Veriler.Getir(
                "SELECT p.Id, p.Ad FROM Projeler p " +
                "JOIN Musteriler m ON m.Id = p.MusteriId " +
                "WHERE m.KullaniciId = @k",
                new System.Data.SQLite.SQLiteParameter("@k", CurrentUser.Id));

            cmbProje.DisplayMember = "Ad";
            cmbProje.ValueMember = "Id";
            cmbProje.DataSource = dt;
            ProjeDetayYukle();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblOdemeler_Click(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
        private void ProjeDetayYukle()
        {
            if (cmbProje.SelectedValue == null) return;
            int projeId = Convert.ToInt32(cmbProje.SelectedValue);

            dgvAsamalar.DataSource = Veriler.Getir(
                "SELECT AsamaAdi, Sira, PlanBitis, GercekBitis, Tamamlandi FROM ProjeAsamalari WHERE ProjeId = @p ORDER BY Sira",
                new System.Data.SQLite.SQLiteParameter("@p", projeId));

            dgvOdemeler.DataSource = Veriler.Getir(
                "SELECT Tur, Tutar, Tarih, Aciklama FROM Odemeler WHERE ProjeId = @p ORDER BY Tarih",
                new System.Data.SQLite.SQLiteParameter("@p", projeId));

            object top = Veriler.Getir(
                "SELECT SUM(Tutar) AS T FROM Odemeler WHERE ProjeId = @p",
                new System.Data.SQLite.SQLiteParameter("@p", projeId)).Rows[0]["T"];
            lblToplamOdeme.Text = "Toplam ödeme: " + (top == DBNull.Value ? 0m : Convert.ToDecimal(top)).ToString("N0") + " TL";
        }

        private void cmbProje_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProjeDetayYukle();
        }
    }
}
