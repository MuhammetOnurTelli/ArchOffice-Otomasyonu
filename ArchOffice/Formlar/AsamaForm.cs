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
    public partial class AsamaForm : Form
    {
        public AsamaForm()
        {
            InitializeComponent();

        }
        private int _projeId;

        public AsamaForm(int projeId) : this()
        {
            _projeId = projeId;
        }

        private void AsamalariYukle()
        {
            dgvAsamalar.DataSource = Veriler.Getir(
                @"SELECT Id, AsamaAdi, Sira, PlanBitis, GercekBitis, Tamamlandi
          FROM ProjeAsamalari
          WHERE ProjeId = @p
          ORDER BY Sira",
                new SQLiteParameter("@p", _projeId));
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAsamaAdi.Text.Trim();
            if (ad == "")
            {
                MessageBox.Show("Aşama adı boş olamaz.");
                return;
            }

            DataTable dt = Veriler.Getir(
                "SELECT IFNULL(MAX(Sira), 0) + 1 AS Sonraki FROM ProjeAsamalari WHERE ProjeId = @p",
                new SQLiteParameter("@p", _projeId));
            int sira = Convert.ToInt32(dt.Rows[0]["Sonraki"]);

            Veriler.Calistir(
                "INSERT INTO ProjeAsamalari (ProjeId, AsamaAdi, Sira, PlanBitis, Tamamlandi) VALUES (@p, @a, @s, @t, 0)",
                new SQLiteParameter("@p", _projeId),
                new SQLiteParameter("@a", ad),
                new SQLiteParameter("@s", sira),
                new SQLiteParameter("@t", dtpPlanBitis.Value.ToString("yyyy-MM-dd")));

            txtAsamaAdi.Text = "";
            AsamalariYukle();
        }

        private void AsamaForm_Load(object sender, EventArgs e)
        {
            AsamalariYukle();
        }

        private void btnTamamla_Click(object sender, EventArgs e)
        {
            if (dgvAsamalar.CurrentRow == null)
            {
                MessageBox.Show("Önce bir aşama seçin.");
                return;
            }

            int asamaId = Convert.ToInt32(dgvAsamalar.CurrentRow.Cells["Id"].Value);

            Veriler.Calistir(
                "UPDATE ProjeAsamalari SET Tamamlandi = 1, GercekBitis = @g WHERE Id = @id",
                new SQLiteParameter("@g", DateTime.Now.ToString("yyyy-MM-dd")),
                new SQLiteParameter("@id", asamaId));

            AsamalariYukle();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
