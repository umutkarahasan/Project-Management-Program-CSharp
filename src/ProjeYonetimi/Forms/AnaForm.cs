using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ProjeYonetimi.Data;
using ReaLTaiizor.Forms;
using static ProjeYonetimi.Data.Veritabani;

namespace ProjeYonetimi.Forms
{
    /// <summary>
    /// Ana ekran. Sekmeler: Anasayfa (özet + bütçe grafiği), Projeler, Çalışanlar, Görevler.
    /// Kod, sekmelere göre bölgelere (#region) ayrılmıştır.
    /// </summary>
    public partial class AnaForm : MaterialForm
    {
        private static readonly CultureInfo Tr = new CultureInfo("tr-TR");

        // Açılışta combobox'lar doldurulurken SelectedIndexChanged olaylarının boşuna çalışmasını engeller
        private bool yukleniyor;

        // Proje Güncelle sekmesi: tablo üzerinde doğrudan düzenleme için
        private SqlDataAdapter projeGuncelleAdaptor;
        private DataTable projeGuncelleTablo;

        public AnaForm()
        {
            InitializeComponent();
            ArayuzuHazirla();
        }

        private void AnaForm_Load(object sender, EventArgs e)
        {
            Guvenli(TumunuYukle);
        }

        private void TumunuYukle()
        {
            yukleniyor = true;
            try
            {
                SecenekleriYukle();
                KategorileriYukle();
                CalisanlariYukle();
                ProjeleriYukle();
                GorevleriYukle();
                AnasayfayiYukle();
            }
            finally
            {
                yukleniyor = false;
            }

            ProjeGorevleriniGoster();
            CalisanGorevleriniGoster();
            GuncellenecekCalisaniGoster();
        }

        private void Sekme_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcAna.SelectedTab == tpAnasayfa)
                Guvenli(AnasayfayiYukle);
        }

        private void tmrSaat_Tick(object sender, EventArgs e)
        {
            lblSaat.Text = DateTime.Now.ToString("HH:mm:ss", Tr);
        }

        #region Anasayfa

        private void AnasayfayiYukle()
        {
            DataTable butceler = Tablo("SELECT ProjeAdi, butce FROM proje WHERE butce > 0 ORDER BY butce DESC");

            chartButce.DataSource = butceler;
            chartButce.Series[0].XValueMember = "ProjeAdi";
            chartButce.Series[0].YValueMembers = "butce";
            chartButce.Series[0].IsValueShownAsLabel = false;
            chartButce.DataBind();

            OzetKartlariniYukle();
        }

        #endregion

        #region Seçenekler (öncelik, durum, unvan, tecrübe)

        private void SecenekleriYukle()
        {
            DataTable oncelikler = Tablo("SELECT oncelik_id, oncelik FROM oncelik ORDER BY oncelik_id");
            DataTable durumlar = Tablo("SELECT durum_id, durum FROM durum ORDER BY durum_id");
            DataTable unvanlar = Tablo("SELECT unvan_id, unvan_adi FROM unvan ORDER BY unvan_adi");
            DataTable tecrubeler = Tablo("SELECT tecrube_id, tecrube FROM tecrube ORDER BY tecrube_id");

            // Her combobox kendi kopyasını alır; aksi halde birinde yapılan seçim diğerini de değiştirir
            Bagla(cbProjeOncelik, oncelikler.Copy(), "oncelik", "oncelik_id");
            Bagla(cbGorevOncelik, oncelikler.Copy(), "oncelik", "oncelik_id");
            Bagla(cbProjeDurum, durumlar.Copy(), "durum", "durum_id");
            Bagla(cbGorevDurum, durumlar.Copy(), "durum", "durum_id");
            Bagla(cbCalisanUnvan, unvanlar.Copy(), "unvan_adi", "unvan_id");
            Bagla(cbGuncelUnvan, unvanlar.Copy(), "unvan_adi", "unvan_id");
            Bagla(cbCalisanTecrube, tecrubeler.Copy(), "tecrube", "tecrube_id");
            Bagla(cbGuncelTecrube, tecrubeler.Copy(), "tecrube", "tecrube_id");
        }

        #endregion

        #region Projeler

        private const string ProjeSorgusu =
            "SELECT p.projeid AS [_id], p.ProjeAdi AS [Proje Adı], p.Sahip, o.oncelik AS [Öncelik], d.durum AS [Durum], " +
            "       (SELECT ISNULL(100 * SUM(CASE WHEN gd.durum = N'Tamamlanmış' THEN 1 ELSE 0 END) / NULLIF(COUNT(*), 0), 0) " +
            "        FROM gorev g2 JOIN durum gd ON gd.durum_id = g2.durum_id WHERE g2.projeid = p.projeid) AS [İlerleme], " +
            "       p.pbaslangic AS [Başlangıç], p.pbitis AS [Bitiş], p.butce AS [Bütçe] " +
            "FROM proje p " +
            "JOIN oncelik o ON o.oncelik_id = p.oncelik_id " +
            "JOIN durum d ON d.durum_id = p.durum_id ";

        private void ProjeleriYukle()
        {
            Izgara(dgvProjeler, Tablo(ProjeSorgusu + "ORDER BY p.pbaslangic DESC"));
            Izgara(dgvYeniProjeler, Tablo(ProjeSorgusu + "WHERE d.durum = N'Yeni' ORDER BY p.pbaslangic DESC"));
            Izgara(dgvGuncelProjeler, Tablo(ProjeSorgusu + "WHERE d.durum = N'Güncel' ORDER BY p.pbaslangic DESC"));
            Izgara(dgvTamamlananProjeler, Tablo(ProjeSorgusu + "WHERE d.durum = N'Tamamlanmış' ORDER BY p.pbaslangic DESC"));

            DataTable projeler = Tablo("SELECT projeid, ProjeAdi FROM proje ORDER BY ProjeAdi");
            Bagla(cbProjeSec, projeler.Copy(), "ProjeAdi", "projeid");
            Bagla(cbGorevProje, projeler.Copy(), "ProjeAdi", "projeid");

            ProjeGuncelleTablosunuYukle();
        }

        private void btnProjeKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtProjeAdi.Text.Trim();
            if (!Zorunlu(ad, "Proje adı")) return;
            if (!TarihleriKontrolEt(dtpProjeBaslangic.Value, dtpProjeBitis.Value)) return;
            if (!ParaOku(txtButce.Text, "Bütçe", out decimal butce)) return;

            Guvenli(() =>
            {
                Calistir(
                    "INSERT INTO proje (ProjeAdi, Sahip, oncelik_id, durum_id, pbaslangic, pbitis, butce) " +
                    "VALUES (@ad, @sahip, @oncelik, @durum, @baslangic, @bitis, @butce)",
                    P("@ad", ad),
                    P("@sahip", txtSahip.Text.Trim()),
                    P("@oncelik", cbProjeOncelik.SelectedValue),
                    P("@durum", cbProjeDurum.SelectedValue),
                    P("@baslangic", dtpProjeBaslangic.Value.Date),
                    P("@bitis", dtpProjeBitis.Value.Date),
                    P("@butce", butce));

                txtProjeAdi.Clear();
                txtSahip.Clear();
                txtProjeBitisYazi.Clear();
                txtButce.Text = 0m.ToString("C2", Tr);

                Yenile(ProjeleriYukle, AnasayfayiYukle);
                Bilgi("Proje kaydedildi.");
            });
        }

        private void dtpProjeBitis_ValueChanged(object sender, EventArgs e)
        {
            txtProjeBitisYazi.Text = dtpProjeBitis.Value.ToString("d MMMM yyyy dddd", Tr);
        }

        /// <summary>
        /// Proje Güncelle sekmesi: projeler tabloda doğrudan düzenlenir,
        /// "GÜNCELLE" butonuyla değişiklikler (ekleme/silme dahil) veritabanına yazılır.
        /// </summary>
        private void ProjeGuncelleTablosunuYukle()
        {
            projeGuncelleAdaptor = new SqlDataAdapter(
                "SELECT projeid, ProjeAdi, Sahip, oncelik_id, durum_id, pbaslangic, pbitis, butce FROM proje",
                BaglantiCumlesi);
            new SqlCommandBuilder(projeGuncelleAdaptor); // UPDATE/INSERT/DELETE komutlarını otomatik üretir

            projeGuncelleTablo = new DataTable();
            projeGuncelleAdaptor.Fill(projeGuncelleTablo);

            var dgv = dgvProjeGuncelle;
            dgv.AutoGenerateColumns = false;
            dgv.Columns.Clear();
            dgv.Columns.Add(MetinSutunu("ProjeAdi", "Proje Adı"));
            dgv.Columns.Add(MetinSutunu("Sahip", "Sahip"));
            dgv.Columns.Add(SecimSutunu("oncelik_id", "Öncelik", Tablo("SELECT oncelik_id, oncelik FROM oncelik"), "oncelik"));
            dgv.Columns.Add(SecimSutunu("durum_id", "Durum", Tablo("SELECT durum_id, durum FROM durum"), "durum"));
            dgv.Columns.Add(MetinSutunu("pbaslangic", "Başlangıç", "dd.MM.yyyy"));
            dgv.Columns.Add(MetinSutunu("pbitis", "Bitiş", "dd.MM.yyyy"));
            dgv.Columns.Add(MetinSutunu("butce", "Bütçe", "N2"));
            dgv.DataSource = projeGuncelleTablo;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AllowUserToAddRows = false;
            dgv.RowHeadersVisible = true; // satır seçip Delete tuşuyla silebilmek için
        }

        private void btnProjeGuncelle_Click(object sender, EventArgs e)
        {
            dgvProjeGuncelle.EndEdit();
            if (projeGuncelleTablo.GetChanges() == null)
            {
                Bilgi("Kaydedilecek bir değişiklik yok.");
                return;
            }

            Guvenli(() =>
            {
                projeGuncelleAdaptor.Update(projeGuncelleTablo);
                Yenile(ProjeleriYukle, GorevleriYukle, AnasayfayiYukle);
                Bilgi("Projeler güncellendi.");
            });
        }

        private void cbProjeSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!yukleniyor) Guvenli(ProjeGorevleriniGoster);
        }

        private void ProjeGorevleriniGoster()
        {
            int? projeId = SeciliId(cbProjeSec);
            if (projeId == null)
            {
                dgvProjeGorevleri.DataSource = null;
                return;
            }

            Izgara(dgvProjeGorevleri, Tablo(GorevSorgusu + "WHERE g.projeid = @id ORDER BY g.gbaslangic",
                P("@id", projeId.Value)));
        }

        #endregion

        #region Çalışanlar

        private void CalisanlariYukle()
        {
            Izgara(dgvCalisanlar, Tablo(
                "SELECT c.calisanid AS [_id], c.calisanadi AS [Adı], c.calisansoyadi AS [Soyadı], c.calisaneposta AS [E-Posta], " +
                "       c.calisantel AS [Telefon], u.unvan_adi AS [Unvan], t.tecrube AS [İş Deneyimi] " +
                "FROM calisan c " +
                "LEFT JOIN unvan u ON u.unvan_id = c.unvan_id " +
                "LEFT JOIN tecrube t ON t.tecrube_id = c.tecrube_id " +
                "ORDER BY c.calisanadi, c.calisansoyadi"));

            DataTable calisanlar = Tablo(
                "SELECT calisanid, calisanadi + ' ' + calisansoyadi AS adsoyad FROM calisan ORDER BY calisanadi, calisansoyadi");
            Bagla(cbGuncellenecekCalisan, calisanlar.Copy(), "adsoyad", "calisanid");
            Bagla(cbCalisanSec, calisanlar.Copy(), "adsoyad", "calisanid");
            Bagla(cbGorevAtanan, calisanlar.Copy(), "adsoyad", "calisanid");
        }

        private void btnCalisanKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtCadi.Text.Trim();
            string soyad = txtCsoyadi.Text.Trim();
            if (!Zorunlu(ad, "Ad") || !Zorunlu(soyad, "Soyad")) return;

            Guvenli(() =>
            {
                Calistir(
                    "INSERT INTO calisan (calisanadi, calisansoyadi, calisaneposta, calisantel, unvan_id, tecrube_id) " +
                    "VALUES (@ad, @soyad, @eposta, @tel, @unvan, @tecrube)",
                    P("@ad", ad),
                    P("@soyad", soyad),
                    P("@eposta", txtCeposta.Text.Trim()),
                    P("@tel", txtCtel.Text.Trim()),
                    P("@unvan", cbCalisanUnvan.SelectedValue),
                    P("@tecrube", cbCalisanTecrube.SelectedValue));

                txtCadi.Clear();
                txtCsoyadi.Clear();
                txtCeposta.Clear();
                txtCtel.Clear();

                Yenile(CalisanlariYukle, AnasayfayiYukle);
                Bilgi("Çalışan kaydedildi.");
            });
        }

        private void cbGuncellenecekCalisan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!yukleniyor) Guvenli(GuncellenecekCalisaniGoster);
        }

        private void GuncellenecekCalisaniGoster()
        {
            int? id = SeciliId(cbGuncellenecekCalisan);
            if (id == null) return;

            DataTable dt = Tablo("SELECT * FROM calisan WHERE calisanid = @id", P("@id", id.Value));
            if (dt.Rows.Count == 0) return;

            DataRow satir = dt.Rows[0];
            txtGuncelAdi.Text = satir["calisanadi"].ToString();
            txtGuncelSoyadi.Text = satir["calisansoyadi"].ToString();
            txtGuncelEposta.Text = satir["calisaneposta"].ToString();
            txtGuncelTel.Text = satir["calisantel"].ToString();
            if (satir["unvan_id"] != DBNull.Value) cbGuncelUnvan.SelectedValue = satir["unvan_id"];
            if (satir["tecrube_id"] != DBNull.Value) cbGuncelTecrube.SelectedValue = satir["tecrube_id"];
        }

        private void btnCalisanGuncelle_Click(object sender, EventArgs e)
        {
            int? id = SeciliId(cbGuncellenecekCalisan);
            if (id == null)
            {
                Uyari("Önce güncellenecek çalışanı seçin.");
                return;
            }

            string ad = txtGuncelAdi.Text.Trim();
            string soyad = txtGuncelSoyadi.Text.Trim();
            if (!Zorunlu(ad, "Ad") || !Zorunlu(soyad, "Soyad")) return;

            Guvenli(() =>
            {
                // Eski sürümde id metin olarak sorguya ekleniyordu; artık parametre kullanılıyor
                Calistir(
                    "UPDATE calisan SET calisanadi = @ad, calisansoyadi = @soyad, calisaneposta = @eposta, " +
                    "calisantel = @tel, unvan_id = @unvan, tecrube_id = @tecrube WHERE calisanid = @id",
                    P("@ad", ad),
                    P("@soyad", soyad),
                    P("@eposta", txtGuncelEposta.Text.Trim()),
                    P("@tel", txtGuncelTel.Text.Trim()),
                    P("@unvan", cbGuncelUnvan.SelectedValue),
                    P("@tecrube", cbGuncelTecrube.SelectedValue),
                    P("@id", id.Value));

                Yenile(CalisanlariYukle, GorevleriYukle);
                cbGuncellenecekCalisan.SelectedValue = id.Value;
                GuncellenecekCalisaniGoster();
                Bilgi("Çalışan güncellendi.");
            });
        }

        private void cbCalisanSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!yukleniyor) Guvenli(CalisanGorevleriniGoster);
        }

        private void CalisanGorevleriniGoster()
        {
            int? id = SeciliId(cbCalisanSec);
            if (id == null)
            {
                dgvCalisanGorevleri.DataSource = null;
                return;
            }

            Izgara(dgvCalisanGorevleri, Tablo(GorevSorgusu + "WHERE g.calisanid = @id ORDER BY g.gbaslangic",
                P("@id", id.Value)));
        }

        #endregion

        #region Görevler ve kategoriler

        private const string GorevSorgusu =
            "SELECT g.gorevid AS [_id], p.ProjeAdi AS [Proje], g.gorevadi AS [Görev], " +
            "       ISNULL(c.calisanadi + ' ' + c.calisansoyadi, N'(atanmamış)') AS [Atanan], " +
            "       g.gbaslangic AS [Başlangıç], g.gbitis AS [Bitiş], o.oncelik AS [Öncelik], d.durum AS [Durum], " +
            "       g.gmaaliyet AS [Maliyet] " +
            "FROM gorev g " +
            "JOIN proje p ON p.projeid = g.projeid " +
            "LEFT JOIN calisan c ON c.calisanid = g.calisanid " +
            "JOIN oncelik o ON o.oncelik_id = g.oncelik_id " +
            "JOIN durum d ON d.durum_id = g.durum_id ";

        private void GorevleriYukle()
        {
            Izgara(dgvGorevler, Tablo(GorevSorgusu + "ORDER BY g.gbaslangic DESC"));
        }

        private void KategorileriYukle()
        {
            DataTable kategoriler = Tablo("SELECT kategori_id, kategori_adi FROM kategori ORDER BY kategori_adi");

            lstKategoriler.Clear();
            foreach (DataRow satir in kategoriler.Rows)
                lstKategoriler.Items.Add(satir["kategori_adi"].ToString());

            Bagla(cbGorevKategori, kategoriler, "kategori_adi", "kategori_id");
        }

        private void btnKategoriEkle_Click(object sender, EventArgs e)
        {
            string ad = txtKategoriAdi.Text.Trim();
            if (!Zorunlu(ad, "Kategori adı")) return;

            Guvenli(() =>
            {
                Calistir("INSERT INTO kategori (kategori_adi) VALUES (@ad)", P("@ad", ad));
                txtKategoriAdi.Clear();
                Yenile(KategorileriYukle);
            });
        }

        private void btnGorevKaydet_Click(object sender, EventArgs e)
        {
            string ad = txtGorevAdi.Text.Trim();
            if (!Zorunlu(ad, "Görev adı")) return;
            if (SeciliId(cbGorevProje) == null)
            {
                Uyari("Önce bir proje ekleyin ve seçin.");
                return;
            }
            if (!TarihleriKontrolEt(dtpGorevBaslangic.Value, dtpGorevBitis.Value)) return;
            if (!ParaOku(txtGorevMaliyet.Text, "Maliyet", out decimal maliyet)) return;

            Guvenli(() =>
            {
                Calistir(
                    "INSERT INTO gorev (projeid, kategori_id, gorevadi, calisanid, gbaslangic, gbitis, oncelik_id, durum_id, gmaaliyet, grvaciklama) " +
                    "VALUES (@proje, @kategori, @ad, @calisan, @baslangic, @bitis, @oncelik, @durum, @maliyet, @aciklama)",
                    P("@proje", cbGorevProje.SelectedValue),
                    P("@kategori", cbGorevKategori.SelectedValue),
                    P("@ad", ad),
                    P("@calisan", cbGorevAtanan.SelectedValue),
                    P("@baslangic", dtpGorevBaslangic.Value.Date),
                    P("@bitis", dtpGorevBitis.Value.Date),
                    P("@oncelik", cbGorevOncelik.SelectedValue),
                    P("@durum", cbGorevDurum.SelectedValue),
                    P("@maliyet", maliyet),
                    P("@aciklama", txtGorevAciklama.Text.Trim()));

                txtGorevAdi.Clear();
                txtGorevAciklama.Clear();
                txtGorevBitisYazi.Clear();
                txtGorevMaliyet.Text = 0m.ToString("C2", Tr);

                Yenile(GorevleriYukle, ProjeGorevleriniGoster, CalisanGorevleriniGoster, AnasayfayiYukle);
                Bilgi("Görev kaydedildi.");
            });
        }

        private void dtpGorevBitis_ValueChanged(object sender, EventArgs e)
        {
            txtGorevBitisYazi.Text = dtpGorevBitis.Value.ToString("d MMMM yyyy dddd", Tr);
        }

        #endregion

        #region Yardımcılar

        /// <summary>Veritabanı hatalarını yakalayıp kullanıcıya anlaşılır mesaj gösterir.</summary>
        private void Guvenli(Action islem)
        {
            try
            {
                islem();
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                Hata("Bu kayıt başka kayıtlarla ilişkili olduğu için işlem yapılamadı.\n" +
                     "(Örneğin görevi olan bir proje silinemez.)");
            }
            catch (SqlException ex)
            {
                Hata("Veritabanı hatası:\n\n" + ex.Message);
            }
            catch (Exception ex)
            {
                Hata("Beklenmeyen hata:\n\n" + ex.Message);
            }
        }

        private void Yenile(params Action[] islemler)
        {
            yukleniyor = true;
            try
            {
                foreach (var islem in islemler) islem();
            }
            finally
            {
                yukleniyor = false;
            }
        }

        private static void Bagla(ComboBox cb, DataTable kaynak, string gorunen, string deger)
        {
            // Önce üyeler, sonra veri kaynağı: aksi halde SelectedValue bir süre DataRowView olur
            cb.DataSource = null;
            cb.DisplayMember = gorunen;
            cb.ValueMember = deger;
            cb.DataSource = kaynak;
        }

        private static int? SeciliId(ComboBox cb)
        {
            return cb.SelectedValue is int id ? id : (int?)null;
        }

        private void Izgara(DataGridView dgv, DataTable veri)
        {
            dgv.DataSource = veri;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.RowHeadersVisible = false;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            foreach (DataGridViewColumn sutun in dgv.Columns)
            {
                Type tip = sutun.ValueType;
                if (tip == typeof(DateTime))
                {
                    sutun.DefaultCellStyle.Format = "dd.MM.yyyy";
                }
                else if (tip == typeof(decimal) || tip == typeof(double))
                {
                    sutun.DefaultCellStyle.Format = "C2";
                    sutun.DefaultCellStyle.FormatProvider = Tr;
                    sutun.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                }
            }

            IzgarayiBicimlendir(dgv);
        }

        private static DataGridViewTextBoxColumn MetinSutunu(string alan, string baslik, string bicim = null)
        {
            var sutun = new DataGridViewTextBoxColumn { DataPropertyName = alan, HeaderText = baslik, Name = alan };
            if (bicim != null)
            {
                sutun.DefaultCellStyle.Format = bicim;
                sutun.DefaultCellStyle.FormatProvider = Tr;
            }
            return sutun;
        }

        private static DataGridViewComboBoxColumn SecimSutunu(string alan, string baslik, DataTable kaynak, string gorunen)
        {
            return new DataGridViewComboBoxColumn
            {
                DataPropertyName = alan,
                HeaderText = baslik,
                Name = alan,
                DataSource = kaynak,
                ValueMember = alan,
                DisplayMember = gorunen,
                DisplayStyle = DataGridViewComboBoxDisplayStyle.Nothing
            };
        }

        /// <summary>"₺1.250,50", "1250,5", "1250.5" gibi girişleri sayıya çevirir.</summary>
        private bool ParaOku(string metin, string alanAdi, out decimal tutar)
        {
            string temiz = (metin ?? string.Empty).Replace("₺", string.Empty).Replace("TL", string.Empty).Trim();
            if (temiz.Length == 0)
            {
                tutar = 0m;
                return true;
            }

            if (decimal.TryParse(temiz, NumberStyles.Number, Tr, out tutar) && tutar >= 0)
                return true;

            Uyari(alanAdi + " geçerli bir tutar olmalı. Örnek: 1.250,50");
            return false;
        }

        private bool Zorunlu(string deger, string alanAdi)
        {
            if (!string.IsNullOrWhiteSpace(deger)) return true;
            Uyari(alanAdi + " boş bırakılamaz.");
            return false;
        }

        private bool TarihleriKontrolEt(DateTime baslangic, DateTime bitis)
        {
            if (bitis.Date >= baslangic.Date) return true;
            Uyari("Bitiş tarihi, başlangıç tarihinden önce olamaz.");
            return false;
        }

        private static void Bilgi(string mesaj) =>
            MessageBox.Show(mesaj, "Proje Yönetimi", MessageBoxButtons.OK, MessageBoxIcon.Information);

        private static void Uyari(string mesaj) =>
            MessageBox.Show(mesaj, "Proje Yönetimi", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private static void Hata(string mesaj) =>
            MessageBox.Show(mesaj, "Proje Yönetimi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        #endregion
    }
}
