using System;
using System.Data.SQLite;
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
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        private void GirisForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            string kullanici = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            if (kullanici == "" || sifre == "")
            {
                lblHata.Text = "Kullanıcı adı ve şifre boş olamaz.";
                return;
            }

            var tablo = Veriler.Getir(
                "SELECT Id, Rol, AdSoyad FROM Kullanicilar WHERE KullaniciAdi = @k AND SifreHash = @s AND Aktif = 1",
                new SQLiteParameter("@k", kullanici),
                new SQLiteParameter("@s", Sifreleme.Hashle(sifre)));

            if (tablo.Rows.Count == 0)
            {
                lblHata.Text = "Kullanıcı adı veya şifre hatalı.";
                return;
            }

            lblHata.Text = "";
            string rol = tablo.Rows[0]["Rol"].ToString();
            CurrentUser.Id = Convert.ToInt32(tablo.Rows[0]["Id"]);
            CurrentUser.KullaniciAdi = kullanici;
            CurrentUser.AdSoyad = tablo.Rows[0]["AdSoyad"].ToString();
            CurrentUser.Rol = rol;
            if (rol == "Yönetici")
            {
                txtSifre.Text = "";
                Hide();
                new YoneticiForm().ShowDialog();
                Show();
            }
            else
            {
                                if (rol == "Müşteri")
                {
                    txtSifre.Text = "";
                    Hide();
                    new MusteriForm().ShowDialog();
                    Show();
                }
                else if (rol == "Mimar")
                {
                    txtSifre.Text = "";
                    Hide();
                    new MimarForm().ShowDialog();
                    Show();
                }
                else
                {
                    MessageBox.Show("Hoş geldiniz, " + CurrentUser.AdSoyad + " (" + rol + ")");
                }
            }
            
        }

        private void btnUyeOl_Click(object sender, EventArgs e)
        {
            new UyeOlForm().ShowDialog();
        }
    }
}
