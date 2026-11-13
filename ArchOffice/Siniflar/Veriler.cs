using System;
using System.Data;
using System.Data.SQLite;
using System.IO;
using System.Windows.Forms;

namespace ArchOffice
{
    public static class Veriler
    {
        private static readonly string DbYolu =
            Path.Combine(Application.StartupPath, "archoffice.db");

        private static readonly string BaglantiMetni =
            "Data Source=" + DbYolu + ";Version=3;";

        public static SQLiteConnection BaglantiAc()
        {
            if (!File.Exists(DbYolu))
                SQLiteConnection.CreateFile(DbYolu);

            var baglanti = new SQLiteConnection(BaglantiMetni);
            baglanti.Open();
            return baglanti;
        }

        // INSERT, UPDATE, DELETE için
        public static int Calistir(string sql, params SQLiteParameter[] parametreler)
        {
            using (var baglanti = BaglantiAc())
            using (var komut = new SQLiteCommand(sql, baglanti))
            {
                komut.Parameters.AddRange(parametreler);
                return komut.ExecuteNonQuery();
            }
        }

        // SELECT için
        public static DataTable Getir(string sql, params SQLiteParameter[] parametreler)
        {
            var tablo = new DataTable();
            using (var baglanti = BaglantiAc())
            using (var komut = new SQLiteCommand(sql, baglanti))
            {
                komut.Parameters.AddRange(parametreler);
                using (var adaptor = new SQLiteDataAdapter(komut))
                {
                    adaptor.Fill(tablo);
                }
            }
            return tablo;
        }
        public static void VarsayilanYoneticiEkle()
        {
            var var = Getir("SELECT Id FROM Kullanicilar WHERE Rol = @rol",
                new SQLiteParameter("@rol", "Yönetici"));
            if (var.Rows.Count > 0) return;

            Calistir("INSERT INTO Kullanicilar (KullaniciAdi, SifreHash, Rol, AdSoyad, Aktif) VALUES (@k, @s, @r, @a, 1)",
                new SQLiteParameter("@k", "admin"),
                new SQLiteParameter("@s", Sifreleme.Hashle("admin123")),
                new SQLiteParameter("@r", "Yönetici"),
                new SQLiteParameter("@a", "Sistem Yöneticisi"));
        }
        public static void EksikMusterileriEkle()
        {
            Calistir("INSERT INTO Musteriler (KullaniciId) SELECT Id FROM Kullanicilar WHERE Rol = 'Müşteri' AND Id NOT IN (SELECT KullaniciId FROM Musteriler)");
        }
        public static void VarsayilanMimarEkle()
        {
            DataTable dt = Getir(
                "SELECT Id FROM Kullanicilar WHERE KullaniciAdi = @k",
                new SQLiteParameter("@k", "mimar1"));

            if (dt.Rows.Count == 0)
            {
                Calistir(
                    "INSERT INTO Kullanicilar (KullaniciAdi, SifreHash, Rol, AdSoyad, Aktif) VALUES (@k, @s, 'Mimar', @a, 1)",
                    new SQLiteParameter("@k", "mimar1"),
                    new SQLiteParameter("@s", Sifreleme.Hashle("mimar123")),
                    new SQLiteParameter("@a", "Test Mimar"));
            }
        }
        public static void VarsayilanMalzemeleriEkle()
        {
            DataTable dt = Getir("SELECT COUNT(*) AS Sayi FROM Malzemeler");
            if (Convert.ToInt32(dt.Rows[0]["Sayi"]) > 0) return;

            string[,] liste =
            {
        { "Tuğla", "Yapı", "adet", "8" },
        { "Çimento (50 kg)", "Yapı", "torba", "250" },
        { "Seramik", "Kaplama", "m2", "450" },
        { "Boya (15 lt)", "Boya", "kova", "1800" },
        { "Parke", "Kaplama", "m2", "700" },
        { "Alçıpan", "Yapı", "m2", "180" }
    };

            for (int i = 0; i < liste.GetLength(0); i++)
            {
                Calistir(
                    "INSERT INTO Malzemeler (Ad, Kategori, Birim, BirimFiyat) VALUES (@a, @k, @b, @f)",
                    new SQLiteParameter("@a", liste[i, 0]),
                    new SQLiteParameter("@k", liste[i, 1]),
                    new SQLiteParameter("@b", liste[i, 2]),
                    new SQLiteParameter("@f", Convert.ToDouble(liste[i, 3])));
            }
        }
    }
}