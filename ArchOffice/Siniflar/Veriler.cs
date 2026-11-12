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
    }
}