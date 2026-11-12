namespace ArchOffice
{
    public static class VeritabaniKurulum
    {
        public static void Hazirla()
        {
            string[] tablolar =
            {
                @"CREATE TABLE IF NOT EXISTS Kullanicilar (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    KullaniciAdi TEXT NOT NULL UNIQUE,
                    SifreHash TEXT NOT NULL,
                    Rol TEXT NOT NULL,
                    AdSoyad TEXT,
                    Telefon TEXT,
                    Email TEXT,
                    Aktif INTEGER NOT NULL DEFAULT 1)",

                @"CREATE TABLE IF NOT EXISTS Musteriler (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    KullaniciId INTEGER NOT NULL REFERENCES Kullanicilar(Id),
                    Adres TEXT,
                    CariBakiye REAL NOT NULL DEFAULT 0)",

                @"CREATE TABLE IF NOT EXISTS Projeler (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    MusteriId INTEGER NOT NULL REFERENCES Musteriler(Id),
                    MimarId INTEGER REFERENCES Kullanicilar(Id),
                    Ad TEXT NOT NULL,
                    Tur TEXT,
                    Alan_m2 REAL,
                    Butce REAL,
                    Durum TEXT NOT NULL DEFAULT 'Onay Bekliyor',
                    BaslangicTarihi TEXT,
                    TeslimTarihi TEXT)",

                @"CREATE TABLE IF NOT EXISTS ProjeAsamalari (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProjeId INTEGER NOT NULL REFERENCES Projeler(Id),
                    AsamaAdi TEXT NOT NULL,
                    Sira INTEGER NOT NULL,
                    PlanBitis TEXT,
                    GercekBitis TEXT,
                    Tamamlandi INTEGER NOT NULL DEFAULT 0)",

                @"CREATE TABLE IF NOT EXISTS Gorevler (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProjeId INTEGER NOT NULL REFERENCES Projeler(Id),
                    MimarId INTEGER REFERENCES Kullanicilar(Id),
                    Baslik TEXT NOT NULL,
                    Durum TEXT NOT NULL DEFAULT 'Bekliyor',
                    SonTarih TEXT)",

                @"CREATE TABLE IF NOT EXISTS Malzemeler (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Ad TEXT NOT NULL,
                    Kategori TEXT,
                    Birim TEXT,
                    BirimFiyat REAL NOT NULL DEFAULT 0)",

                @"CREATE TABLE IF NOT EXISTS Teklifler (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProjeId INTEGER NOT NULL REFERENCES Projeler(Id),
                    Tarih TEXT,
                    ToplamTutar REAL NOT NULL DEFAULT 0,
                    Durum TEXT NOT NULL DEFAULT 'Taslak')",

                @"CREATE TABLE IF NOT EXISTS TeklifKalemleri (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    TeklifId INTEGER NOT NULL REFERENCES Teklifler(Id),
                    MalzemeId INTEGER NOT NULL REFERENCES Malzemeler(Id),
                    Miktar REAL NOT NULL,
                    BirimFiyat REAL NOT NULL,
                    Tutar REAL NOT NULL)",

                @"CREATE TABLE IF NOT EXISTS Odemeler (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProjeId INTEGER NOT NULL REFERENCES Projeler(Id),
                    MusteriId INTEGER NOT NULL REFERENCES Musteriler(Id),
                    Tutar REAL NOT NULL,
                    Tarih TEXT,
                    Tur TEXT,
                    Aciklama TEXT)",

                @"CREATE TABLE IF NOT EXISTS Talepler (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    MusteriId INTEGER NOT NULL REFERENCES Musteriler(Id),
                    ProjeId INTEGER REFERENCES Projeler(Id),
                    Baslik TEXT NOT NULL,
                    Aciklama TEXT,
                    Durum TEXT NOT NULL DEFAULT 'Beklemede',
                    Tarih TEXT)"
            };

            foreach (string sql in tablolar)
                Veriler.Calistir(sql);
        }
    }
}