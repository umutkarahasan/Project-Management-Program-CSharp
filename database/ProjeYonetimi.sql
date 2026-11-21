/*
    Proje Yönetimi - veritabanı kurulum scripti (SQL Server)
    -----------------------------------------------------------
    SQL Server Management Studio'da açıp tamamını çalıştırın (F5).
    Veritabanını, tabloları ve örnek verileri oluşturur.

    Varsayılan giriş:  kullanıcı adı: admin   şifre: admin
*/

IF DB_ID(N'ProjeYonetimi') IS NULL
    CREATE DATABASE ProjeYonetimi;
GO

USE ProjeYonetimi;
GO

/* ---------- Seçenek tabloları ---------- */

CREATE TABLE oncelik (
    oncelik_id INT IDENTITY(1,1) PRIMARY KEY,
    oncelik    NVARCHAR(30) NOT NULL
);

CREATE TABLE durum (
    durum_id INT IDENTITY(1,1) PRIMARY KEY,
    durum    NVARCHAR(30) NOT NULL
);

CREATE TABLE unvan (
    unvan_id  INT IDENTITY(1,1) PRIMARY KEY,
    unvan_adi NVARCHAR(50) NOT NULL
);

CREATE TABLE tecrube (
    tecrube_id INT IDENTITY(1,1) PRIMARY KEY,
    tecrube    NVARCHAR(30) NOT NULL
);

CREATE TABLE kategori (
    kategori_id  INT IDENTITY(1,1) PRIMARY KEY,
    kategori_adi NVARCHAR(50) NOT NULL
);

/* ---------- Ana tablolar ---------- */

-- Uygulama kullanıcıları (şifreler SHA-256 özeti olarak tutulur)
CREATE TABLE kadi (
    kadi_id INT IDENTITY(1,1) PRIMARY KEY,
    kadi    NVARCHAR(50) NOT NULL UNIQUE,
    sifre   VARCHAR(64)  NOT NULL
);

CREATE TABLE calisan (
    calisanid     INT IDENTITY(1,1) PRIMARY KEY,
    calisanadi    NVARCHAR(50)  NOT NULL,
    calisansoyadi NVARCHAR(50)  NOT NULL,
    calisaneposta NVARCHAR(100) NULL,
    calisantel    NVARCHAR(20)  NULL,
    unvan_id      INT NULL REFERENCES unvan(unvan_id),
    tecrube_id    INT NULL REFERENCES tecrube(tecrube_id)
);

CREATE TABLE proje (
    projeid    INT IDENTITY(1,1) PRIMARY KEY,
    ProjeAdi   NVARCHAR(100) NOT NULL,
    Sahip      NVARCHAR(100) NULL,
    oncelik_id INT NOT NULL REFERENCES oncelik(oncelik_id),
    durum_id   INT NOT NULL REFERENCES durum(durum_id),
    pbaslangic DATE NOT NULL,
    pbitis     DATE NOT NULL,
    butce      DECIMAL(18,2) NOT NULL DEFAULT 0
);

CREATE TABLE gorev (
    gorevid     INT IDENTITY(1,1) PRIMARY KEY,
    projeid     INT NOT NULL REFERENCES proje(projeid),
    kategori_id INT NULL REFERENCES kategori(kategori_id),
    gorevadi    NVARCHAR(100) NOT NULL,
    calisanid   INT NULL REFERENCES calisan(calisanid),
    gbaslangic  DATE NOT NULL,
    gbitis      DATE NOT NULL,
    oncelik_id  INT NOT NULL REFERENCES oncelik(oncelik_id),
    durum_id    INT NOT NULL REFERENCES durum(durum_id),
    gmaaliyet   DECIMAL(18,2) NOT NULL DEFAULT 0,
    grvaciklama NVARCHAR(MAX) NULL
);
GO

/* ---------- Başlangıç verileri ---------- */

-- Not: Uygulama proje durumlarını bu isimlere göre filtreler, değiştirmeyin.
INSERT INTO durum (durum) VALUES (N'Yeni'), (N'Güncel'), (N'Tamamlanmış');
INSERT INTO oncelik (oncelik) VALUES (N'Düşük'), (N'Orta'), (N'Yüksek'), (N'Acil');
INSERT INTO unvan (unvan_adi) VALUES (N'Proje Yöneticisi'), (N'Yazılım Geliştirici'), (N'Tasarımcı'), (N'Test Uzmanı'), (N'Analist');
INSERT INTO tecrube (tecrube) VALUES (N'0-1 yıl'), (N'1-3 yıl'), (N'3-5 yıl'), (N'5+ yıl');
INSERT INTO kategori (kategori_adi) VALUES (N'Analiz'), (N'Tasarım'), (N'Geliştirme'), (N'Test'), (N'Dokümantasyon');

-- Kullanıcı: admin / admin
INSERT INTO kadi (kadi, sifre)
VALUES (N'admin', CONVERT(VARCHAR(64), HASHBYTES('SHA2_256', 'admin'), 2));

/* ---------- Örnek veriler (istemiyorsanız bu bölümü silebilirsiniz) ---------- */

INSERT INTO calisan (calisanadi, calisansoyadi, calisaneposta, calisantel, unvan_id, tecrube_id) VALUES
(N'Ayşe',  N'Yılmaz', N'ayse@ornek.com',  N'5550000001', 1, 4),
(N'Mehmet', N'Demir', N'mehmet@ornek.com', N'5550000002', 2, 3),
(N'Zeynep', N'Kaya',  N'zeynep@ornek.com', N'5550000003', 3, 2);

INSERT INTO proje (ProjeAdi, Sahip, oncelik_id, durum_id, pbaslangic, pbitis, butce) VALUES
(N'Web Sitesi Yenileme', N'Ayşe Yılmaz',  3, 2, '2026-01-10', '2026-04-30', 85000),
(N'Mobil Uygulama',      N'Mehmet Demir', 4, 1, '2026-03-01', '2026-09-01', 150000),
(N'Stok Takip Sistemi',  N'Ayşe Yılmaz',  2, 3, '2025-06-01', '2025-12-15', 60000);

INSERT INTO gorev (projeid, kategori_id, gorevadi, calisanid, gbaslangic, gbitis, oncelik_id, durum_id, gmaaliyet, grvaciklama) VALUES
(1, 2, N'Ana sayfa tasarımı',     3, '2026-01-10', '2026-02-01', 3, 3, 12000, N'Yeni renk paleti ile'),
(1, 3, N'Yönetim paneli',         2, '2026-02-01', '2026-03-20', 3, 2, 30000, NULL),
(2, 1, N'Gereksinim analizi',     1, '2026-03-01', '2026-03-15', 2, 1,  8000, NULL),
(3, 4, N'Kabul testleri',         2, '2025-11-01', '2025-12-10', 2, 3,  6000, NULL);
GO
