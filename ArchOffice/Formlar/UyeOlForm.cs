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
    public partial class UyeOlForm : Form
    {
        public UyeOlForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UyeOlForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string adSoyad = txtAdSoyad.Text.Trim();
            string kullanici = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            if (adSoyad == "" || kullanici == "" || sifre == "")
            {
                lblHata.Text = "Ad soyad, kullanıcı adı ve şifre zorunludur.";
                return;
            }
            if (sifre != txtSifreTekrar.Text)
            {
                lblHata.Text = "Şifreler aynı değil.";
                return;
            }

            var var = Veriler.Getir("SELECT Id FROM Kullanicilar WHERE KullaniciAdi = @k",
                new SQLiteParameter("@k", kullanici));
            if (var.Rows.Count > 0)
            {
                lblHata.Text = "Bu kullanıcı adı zaten alınmış.";
                return;
            }

            Veriler.Calistir("INSERT INTO Kullanicilar (KullaniciAdi, SifreHash, Rol, AdSoyad, Telefon, Email, Aktif) VALUES (@k, @s, 'Müşteri', @a, @t, @e, 1)",
                new SQLiteParameter("@k", kullanici),
                new SQLiteParameter("@s", Sifreleme.Hashle(sifre)),
                new SQLiteParameter("@a", adSoyad),
                new SQLiteParameter("@t", txtTelefon.Text.Trim()),
                new SQLiteParameter("@e", txtEmail.Text.Trim()));

            MessageBox.Show("Kayıt başarılı. Şimdi giriş yapabilirsiniz.");
            Close();
        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
