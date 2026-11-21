using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace ProjeYonetimi.Data
{
    /// <summary>
    /// Tüm veritabanı erişimi bu sınıftan geçer.
    /// Bağlantı cümlesi App.config içindeki "ProjeYonetimi" kaydından okunur;
    /// her çağrı kendi bağlantısını açar ve iş bitince kapatır.
    /// </summary>
    public static class Veritabani
    {
        public static string BaglantiCumlesi
        {
            get
            {
                var kayit = ConfigurationManager.ConnectionStrings["ProjeYonetimi"];
                if (kayit == null)
                    throw new InvalidOperationException("App.config içinde 'ProjeYonetimi' bağlantı cümlesi bulunamadı.");
                return kayit.ConnectionString;
            }
        }

        /// <summary>SELECT sorgusunu çalıştırır ve sonucu tablo olarak döndürür.</summary>
        public static DataTable Tablo(string sql, params SqlParameter[] parametreler)
        {
            using (var baglanti = new SqlConnection(BaglantiCumlesi))
            using (var komut = new SqlCommand(sql, baglanti))
            using (var adaptor = new SqlDataAdapter(komut))
            {
                komut.Parameters.AddRange(parametreler);
                var tablo = new DataTable();
                adaptor.Fill(tablo);
                return tablo;
            }
        }

        /// <summary>INSERT / UPDATE / DELETE çalıştırır, etkilenen satır sayısını döndürür.</summary>
        public static int Calistir(string sql, params SqlParameter[] parametreler)
        {
            using (var baglanti = new SqlConnection(BaglantiCumlesi))
            using (var komut = new SqlCommand(sql, baglanti))
            {
                komut.Parameters.AddRange(parametreler);
                baglanti.Open();
                return komut.ExecuteNonQuery();
            }
        }

        /// <summary>Tek bir değer döndüren sorguyu çalıştırır (COUNT, SUM vb.).</summary>
        public static object Deger(string sql, params SqlParameter[] parametreler)
        {
            using (var baglanti = new SqlConnection(BaglantiCumlesi))
            using (var komut = new SqlCommand(sql, baglanti))
            {
                komut.Parameters.AddRange(parametreler);
                baglanti.Open();
                return komut.ExecuteScalar();
            }
        }

        /// <summary>Kısa yazım: Veritabani.P("@ad", deger)</summary>
        public static SqlParameter P(string ad, object deger)
        {
            return new SqlParameter(ad, deger ?? DBNull.Value);
        }

        /// <summary>Şifreyi SHA-256 ile özetler (veritabanında düz metin şifre tutulmaz).</summary>
        public static string SifreOzeti(string sifre)
        {
            using (var sha = SHA256.Create())
            {
                var baytlar = sha.ComputeHash(Encoding.UTF8.GetBytes(sifre ?? string.Empty));
                var sb = new StringBuilder(baytlar.Length * 2);
                foreach (var b in baytlar)
                    sb.Append(b.ToString("X2"));
                return sb.ToString();
            }
        }
    }
}
