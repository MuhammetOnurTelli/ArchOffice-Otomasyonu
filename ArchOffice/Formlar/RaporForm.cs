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
    public partial class RaporForm : Form
    {
        public RaporForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void RaporForm_Load(object sender, EventArgs e)
        {
            lblToplamProje.Text = Veriler.Getir("SELECT COUNT(*) AS S FROM Projeler").Rows[0]["S"].ToString();
            lblBekleyen.Text = Veriler.Getir("SELECT COUNT(*) AS S FROM Projeler WHERE Durum = 'Onay Bekliyor'").Rows[0]["S"].ToString();

            object butce = Veriler.Getir("SELECT SUM(Butce) AS T FROM Projeler").Rows[0]["T"];
            lblButce.Text = (butce == DBNull.Value ? 0m : Convert.ToDecimal(butce)).ToString("N0") + " TL";

            object odeme = Veriler.Getir("SELECT SUM(Tutar) AS T FROM Odemeler").Rows[0]["T"];
            lblOdeme.Text = (odeme == DBNull.Value ? 0m : Convert.ToDecimal(odeme)).ToString("N0") + " TL";
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnKapat_Click_1(object sender, EventArgs e)
        {
            Close();
        }
    }
}
