using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static ProjeYonetimi.Data.Veritabani;

namespace ProjeYonetimi.Forms
{
    /// <summary>
    /// Ana ekranın kodla eklenen parçaları:
    /// - Anasayfa: özet kartları, yaklaşan/geciken görevler listesi, bütçe grafiği
    /// - Listeler: arama kutusu, Excel'e (CSV) aktarma, duruma göre renklendirme
    /// - Sağ tık menüsü: durum değiştirme, silme, ilgili ekrana gitme
    /// </summary>
    public partial class AnaForm
    {
        private const string Tamamlandi = "Tamamlanmış";

        private static readonly Color Vurgu = Color.FromArgb(35, 168, 109);
        private static readonly Color KoyuZemin = Color.FromArgb(45, 47, 49);
        private static readonly Color Kirmizi = Color.FromArgb(198, 40, 40);
        private static readonly Color Turuncu = Color.FromArgb(230, 120, 0);
        private static readonly Color Mavi = Color.FromArgb(25, 118, 210);

        private readonly Dictionary<DataGridView, TextBox> aramaKutulari = new Dictionary<DataGridView, TextBox>();
        private readonly Label[] kartBasliklari = new Label[5];
        private readonly Label[] kartDegerleri = new Label[5];
        private DataGridView dgvYaklasan;
        private Font kalinYazi;

        private enum KayitTuru { Proje, Gorev, Calisan }

        private void ArayuzuHazirla()
        {
            kalinYazi = new Font(dgvProjeler.Font, FontStyle.Bold);

            // Sekme çubuğu pencere başlığının altını kapatıyordu: biraz aşağı alınır
            const int baslikPayi = 14;
            tcAna.Top += baslikPayi;
            ClientSize = new Size(ClientSize.Width, ClientSize.Height + baslikPayi);

            // Saat: sekme çubuğunun sağında, çubukla aynı zeminde
            lblSaat.Visible = false;
            var saat = new Label
            {
                AutoSize = true,
                BackColor = KoyuZemin,
                ForeColor = Color.WhiteSmoke,
                Font = new Font("Segoe UI", 10F),
                Anchor = AnchorStyles.Top | AnchorStyles.Right
            };
            Controls.Add(saat);
            saat.BringToFront();
            saat.Text = DateTime.Now.ToString("dd.MM.yyyy  HH:mm", Tr);
            saat.Location = new Point(ClientSize.Width - saat.PreferredWidth - 16, tcAna.Top + 11);
            tmrSaat.Tick += (s, e) => saat.Text = DateTime.Now.ToString("dd.MM.yyyy  HH:mm", Tr);

            AnasayfayiHazirla();

            AracCubuguEkle(dgvProjeler);
            AracCubuguEkle(dgvCalisanlar);
            AracCubuguEkle(dgvGorevler);

            var projeIzgaralari = new[] { dgvProjeler, dgvYeniProjeler, dgvGuncelProjeler, dgvTamamlananProjeler };
            var gorevIzgaralari = new[] { dgvGorevler, dgvProjeGorevleri, dgvCalisanGorevleri, dgvYaklasan };

            foreach (var dgv in projeIzgaralari) SagTikMenusuBagla(dgv, KayitTuru.Proje);
            foreach (var dgv in gorevIzgaralari) SagTikMenusuBagla(dgv, KayitTuru.Gorev);
            SagTikMenusuBagla(dgvCalisanlar, KayitTuru.Calisan);
        }

        #region Anasayfa: kartlar, yaklaşan görevler, grafik

        private void AnasayfayiHazirla()
        {
            lblHosgeldin.Visible = false;
            lblOzet.Visible = false;

            // Grafik: halka grafik, dilim yazıları kapalı (çakışıyordu), açıklama altta
            chartButce.Location = new Point(656, 41);
            chartButce.Size = new Size(324, 309);
            Series seri = chartButce.Series[0];
            seri.ChartType = SeriesChartType.Doughnut;
            seri["PieLabelStyle"] = "Disabled";
            seri["DoughnutRadius"] = "55";
            seri.ToolTip = "#VALX: #VALY{C0}";
            chartButce.Legends[0].Docking = Docking.Bottom;
            chartButce.Legends[0].Alignment = StringAlignment.Center;
            chartButce.Titles.Add(new Title("Proje bütçe dağılımı", Docking.Top,
                new Font("Segoe UI", 10F, FontStyle.Bold), KoyuZemin));

            // Yaklaşan ve geciken görevler
            tpAnasayfa.Controls.Add(new Label
            {
                Text = "Yaklaşan ve geciken görevler",
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 10F, FontStyle.Bold),
                AutoSize = true,
                Location = new Point(290, 41)
            });
            dgvYaklasan = new DataGridView { Location = new Point(292, 68), Size = new Size(348, 282) };
            tpAnasayfa.Controls.Add(dgvYaklasan);

            // Özet kartları
            string[] basliklar = { "Projeler", "Açık görevler", "Geciken görevler", "Çalışanlar", "Toplam bütçe" };
            const int genislik = 180, aralik = 10;
            for (int i = 0; i < basliklar.Length; i++)
            {
                var kart = new Panel
                {
                    BackColor = KoyuZemin,
                    Location = new Point(26 + i * (genislik + aralik), 372),
                    Size = new Size(genislik, 78)
                };
                kart.Controls.Add(new Panel
                {
                    BackColor = i == 2 ? Kirmizi : Vurgu,
                    Dock = DockStyle.Left,
                    Width = 4
                });
                kartBasliklari[i] = new Label
                {
                    Text = basliklar[i],
                    ForeColor = Color.Silver,
                    Font = new Font("Segoe UI", 9F),
                    AutoSize = true,
                    Location = new Point(14, 10)
                };
                kartDegerleri[i] = new Label
                {
                    Text = "-",
                    ForeColor = Color.White,
                    Font = new Font("Segoe UI", 17F, FontStyle.Bold),
                    AutoSize = true,
                    Location = new Point(11, 32)
                };
                kart.Controls.Add(kartBasliklari[i]);
                kart.Controls.Add(kartDegerleri[i]);
                tpAnasayfa.Controls.Add(kart);
            }
        }

        private void OzetKartlariniYukle()
        {
            DataRow o = Tablo(
                "SELECT " +
                " (SELECT COUNT(*) FROM proje) AS proje, " +
                " (SELECT COUNT(*) FROM proje p JOIN durum d ON d.durum_id = p.durum_id WHERE d.durum <> @tamam) AS aktifProje, " +
                " (SELECT COUNT(*) FROM gorev g JOIN durum d ON d.durum_id = g.durum_id WHERE d.durum <> @tamam) AS acikGorev, " +
                " (SELECT COUNT(*) FROM gorev g JOIN durum d ON d.durum_id = g.durum_id " +
                "   WHERE d.durum <> @tamam AND g.gbitis < CAST(GETDATE() AS date)) AS geciken, " +
                " (SELECT COUNT(*) FROM calisan) AS calisan, " +
                " (SELECT ISNULL(SUM(butce), 0) FROM proje) AS butce",
                P("@tamam", Tamamlandi)).Rows[0];

            kartBasliklari[0].Text = string.Format(Tr, "Projeler ({0} aktif)", o["aktifProje"]);
            kartDegerleri[0].Text = Convert.ToString(o["proje"], Tr);
            kartDegerleri[1].Text = Convert.ToString(o["acikGorev"], Tr);
            kartDegerleri[2].Text = Convert.ToString(o["geciken"], Tr);
            kartDegerleri[2].ForeColor = Convert.ToInt32(o["geciken"]) > 0 ? Color.FromArgb(255, 138, 128) : Color.White;
            kartDegerleri[3].Text = Convert.ToString(o["calisan"], Tr);
            kartDegerleri[4].Text = Convert.ToDecimal(o["butce"]).ToString("C0", Tr);

            Izgara(dgvYaklasan, Tablo(
                "SELECT TOP 20 g.gorevid AS [_id], g.gorevadi AS [Görev], p.ProjeAdi AS [Proje], " +
                "       DATEDIFF(day, CAST(GETDATE() AS date), g.gbitis) AS [Kalan] " +
                "FROM gorev g " +
                "JOIN proje p ON p.projeid = g.projeid " +
                "JOIN durum d ON d.durum_id = g.durum_id " +
                "WHERE d.durum <> @tamam " +
                "ORDER BY g.gbitis",
                P("@tamam", Tamamlandi)));
        }

        #endregion

        #region Arama ve Excel'e aktarma

        private void AracCubuguEkle(DataGridView dgv)
        {
            const int yukseklik = 36;
            Control sayfa = dgv.Parent;

            var ara = new TextBox
            {
                Location = new Point(dgv.Left, dgv.Top + 3),
                Width = 260,
                Font = new Font("Segoe UI", 10F)
            };
            IpucuYazisi(ara, "Ara...");
            ara.TextChanged += (s, e) => FiltreUygula(dgv);

            var ipucu = new Label
            {
                Text = "İpucu: satıra sağ tıklayarak durumu değiştirebilir veya silebilirsiniz.",
                AutoSize = true,
                ForeColor = Color.DimGray,
                Font = new Font("Segoe UI", 8.5F),
                Location = new Point(dgv.Left + 272, dgv.Top + 8)
            };

            var aktar = new Button
            {
                Text = "Excel'e aktar",
                FlatStyle = FlatStyle.Flat,
                BackColor = Vurgu,
                ForeColor = Color.White,
                Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                Size = new Size(120, 28),
                Location = new Point(dgv.Right - 120, dgv.Top + 1),
                Cursor = Cursors.Hand
            };
            aktar.FlatAppearance.BorderSize = 0;
            aktar.Click += (s, e) => Guvenli(() => ExcelAktar(dgv, sayfa.Text));

            dgv.Top += yukseklik;
            dgv.Height -= yukseklik;
            sayfa.Controls.Add(ara);
            sayfa.Controls.Add(ipucu);
            sayfa.Controls.Add(aktar);
            aramaKutulari[dgv] = ara;
        }

        /// <summary>Arama kutusundaki metni tablonun tüm görünür sütunlarında arar.</summary>
        private void FiltreUygula(DataGridView dgv)
        {
            if (!(dgv.DataSource is DataTable tablo) || !aramaKutulari.TryGetValue(dgv, out TextBox kutu))
                return;

            string aranan = kutu.Text.Trim();
            if (aranan.Length == 0)
            {
                tablo.DefaultView.RowFilter = string.Empty;
                return;
            }

            // RowFilter LIKE kalıbında özel karakterler köşeli parantezle kaçırılır
            var kacis = new StringBuilder();
            foreach (char c in aranan)
            {
                if (c == '\'') kacis.Append("''");
                else if (c == '[' || c == ']' || c == '*' || c == '%') kacis.Append('[').Append(c).Append(']');
                else kacis.Append(c);
            }

            var kosullar = tablo.Columns.Cast<DataColumn>()
                .Where(s => !s.ColumnName.StartsWith("_"))
                .Select(s => string.Format("CONVERT([{0}], 'System.String') LIKE '%{1}%'",
                    s.ColumnName.Replace("\\", "\\\\").Replace("]", "\\]"), kacis));

            tablo.DefaultView.RowFilter = string.Join(" OR ", kosullar);
        }

        /// <summary>Tablodaki görünen satırları Excel'in açabileceği CSV dosyasına yazar.</summary>
        private void ExcelAktar(DataGridView dgv, string baslik)
        {
            using (var kaydet = new SaveFileDialog
            {
                Filter = "Excel için CSV (*.csv)|*.csv",
                FileName = string.Format("{0}_{1:yyyy-MM-dd}.csv", baslik, DateTime.Today)
            })
            {
                if (kaydet.ShowDialog(this) != DialogResult.OK) return;

                var sutunlar = dgv.Columns.Cast<DataGridViewColumn>()
                    .Where(s => s.Visible)
                    .OrderBy(s => s.DisplayIndex)
                    .ToList();

                var sb = new StringBuilder();
                sb.AppendLine(string.Join(";", sutunlar.Select(s => CsvHucre(s.HeaderText))));
                foreach (DataGridViewRow satir in dgv.Rows)
                {
                    if (satir.IsNewRow) continue;
                    sb.AppendLine(string.Join(";", sutunlar.Select(s =>
                        CsvHucre(Convert.ToString(satir.Cells[s.Index].FormattedValue, Tr)))));
                }

                // BOM'lu UTF-8 + noktalı virgül: Türkçe Excel dosyayı doğrudan doğru açar
                File.WriteAllText(kaydet.FileName, sb.ToString(), new UTF8Encoding(true));
                Bilgi(string.Format(Tr, "{0} satır dışa aktarıldı:\n{1}", dgv.Rows.Count, kaydet.FileName));
            }
        }

        private static string CsvHucre(string deger)
        {
            deger = deger ?? string.Empty;
            return deger.IndexOfAny(new[] { ';', '"', '\n', '\r' }) >= 0
                ? "\"" + deger.Replace("\"", "\"\"") + "\""
                : deger;
        }

        [DllImport("user32.dll", CharSet = CharSet.Unicode)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wParam, string lParam);

        private static void IpucuYazisi(TextBox kutu, string metin)
        {
            const int EM_SETCUEBANNER = 0x1501;
            kutu.HandleCreated += (s, e) => SendMessage(kutu.Handle, EM_SETCUEBANNER, (IntPtr)1, metin);
        }

        #endregion

        #region Tablo görünümü ve renklendirme

        /// <summary>Izgara verisi bağlandıktan sonra: görünüm, gizli sütunlar, renkler, arama filtresi.</summary>
        private void IzgarayiBicimlendir(DataGridView dgv)
        {
            dgv.BackgroundColor = Color.White;
            dgv.BorderStyle = BorderStyle.None;
            dgv.GridColor = Color.FromArgb(230, 232, 235);
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = KoyuZemin;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.SelectionBackColor = KoyuZemin;
            dgv.ColumnHeadersDefaultCellStyle.Font = kalinYazi;
            dgv.ColumnHeadersHeight = 32;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.RowTemplate.Height = 28;
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(214, 240, 226);
            dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            dgv.AllowUserToResizeRows = false;

            foreach (DataGridViewColumn sutun in dgv.Columns)
            {
                if (sutun.Name.StartsWith("_"))
                    sutun.Visible = false;
                else if (sutun.Name == "İlerleme" || sutun.Name == "Kalan")
                    sutun.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                else if (sutun.Name == "Proje Adı" || sutun.Name == "Görev" || sutun.Name == "Proje")
                    sutun.FillWeight = 150;
                else if (sutun.Name == "Durum")
                    sutun.FillWeight = 120;
            }

            if (dgv == dgvYaklasan && dgv.Columns.Contains("Kalan"))
            {
                dgv.Columns["Görev"].FillWeight = 100;
                dgv.Columns["Proje"].FillWeight = 85;
                dgv.Columns["Kalan"].FillWeight = 95;
            }

            if (!(dgv.Tag is string bagli && bagli == "bicimli"))
            {
                dgv.CellFormatting += Izgara_CellFormatting;
                dgv.Tag = "bicimli";
            }

            FiltreUygula(dgv);
        }

        private void Izgara_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0 || e.Value == null || e.Value == DBNull.Value) return;

            var dgv = (DataGridView)sender;
            string sutun = dgv.Columns[e.ColumnIndex].Name;
            string deger = Convert.ToString(e.Value, Tr);

            switch (sutun)
            {
                case "Durum":
                    e.CellStyle.Font = kalinYazi;
                    e.CellStyle.ForeColor = deger == Tamamlandi ? Vurgu : deger == "Güncel" ? Mavi : Color.DimGray;
                    break;

                case "Öncelik":
                    if (deger == "Acil") { e.CellStyle.ForeColor = Kirmizi; e.CellStyle.Font = kalinYazi; }
                    else if (deger == "Yüksek") e.CellStyle.ForeColor = Turuncu;
                    break;

                case "Bitiş":
                    // Bitiş tarihi geçmiş ve tamamlanmamış: kırmızı + kalın
                    if (e.Value is DateTime bitis && bitis.Date < DateTime.Today && !TamamlanmisMi(dgv, e.RowIndex))
                    {
                        e.CellStyle.ForeColor = Kirmizi;
                        e.CellStyle.Font = kalinYazi;
                    }
                    break;

                case "İlerleme":
                    e.Value = "%" + deger;
                    e.CellStyle.ForeColor = deger == "100" ? Vurgu : Color.Black;
                    e.FormattingApplied = true;
                    break;

                case "Kalan":
                    int gun = Convert.ToInt32(e.Value);
                    if (gun < 0) { e.Value = -gun + " gün gecikti"; e.CellStyle.ForeColor = Kirmizi; e.CellStyle.Font = kalinYazi; }
                    else if (gun == 0) { e.Value = "Bugün"; e.CellStyle.ForeColor = Turuncu; e.CellStyle.Font = kalinYazi; }
                    else e.Value = gun + " gün";
                    e.FormattingApplied = true;
                    break;
            }
        }

        private static bool TamamlanmisMi(DataGridView dgv, int satir)
        {
            if (!dgv.Columns.Contains("Durum")) return false;
            return Convert.ToString(dgv.Rows[satir].Cells["Durum"].Value) == Tamamlandi;
        }

        #endregion

        #region Sağ tık menüsü: durum değiştir, sil, ilgili ekrana git

        private void SagTikMenusuBagla(DataGridView dgv, KayitTuru tur)
        {
            // Sağ tıklanan satır seçili hale gelsin
            dgv.CellMouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
                    dgv.CurrentCell = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex];
            };

            var menu = new ContextMenuStrip();
            menu.Opening += (s, e) =>
            {
                menu.Items.Clear();
                int? id = SeciliKayitId(dgv);
                if (id == null) { e.Cancel = true; return; }

                if (tur != KayitTuru.Calisan)
                {
                    var durumMenu = new ToolStripMenuItem("Durumu değiştir");
                    try
                    {
                        foreach (DataRow d in Tablo("SELECT durum_id, durum FROM durum ORDER BY durum_id").Rows)
                        {
                            int durumId = Convert.ToInt32(d["durum_id"]);
                            durumMenu.DropDownItems.Add(d["durum"].ToString(), null,
                                (a, b) => Guvenli(() => DurumDegistir(tur, id.Value, durumId)));
                        }
                    }
                    catch (Exception ex)
                    {
                        Hata("Durumlar okunamadı:\n\n" + ex.Message);
                        e.Cancel = true;
                        return;
                    }
                    menu.Items.Add(durumMenu);
                }

                if (tur == KayitTuru.Proje)
                    menu.Items.Add("Görevlerini göster", null, (a, b) => ProjeGorevlerineGit(id.Value));
                if (tur == KayitTuru.Calisan)
                {
                    menu.Items.Add("Düzenle", null, (a, b) => CalisaniDuzenle(id.Value));
                    menu.Items.Add("Görevlerini göster", null, (a, b) => CalisanGorevlerineGit(id.Value));
                }

                menu.Items.Add(new ToolStripSeparator());
                ToolStripItem sil = menu.Items.Add("Sil", null, (a, b) => Guvenli(() => Sil(dgv, tur, id.Value)));
                sil.ForeColor = Kirmizi;

                e.Cancel = false;
            };
            dgv.ContextMenuStrip = menu;
        }

        private static int? SeciliKayitId(DataGridView dgv)
        {
            if (dgv.CurrentRow?.DataBoundItem is DataRowView satir && satir.Row.Table.Columns.Contains("_id"))
                return Convert.ToInt32(satir["_id"]);
            return null;
        }

        private static string SeciliKayitAdi(DataGridView dgv)
        {
            var ilkSutun = dgv.Columns.Cast<DataGridViewColumn>()
                .Where(s => s.Visible).OrderBy(s => s.DisplayIndex).FirstOrDefault();
            return ilkSutun == null ? string.Empty : Convert.ToString(dgv.CurrentRow?.Cells[ilkSutun.Index].Value);
        }

        private void DurumDegistir(KayitTuru tur, int id, int durumId)
        {
            if (tur == KayitTuru.Proje)
                Calistir("UPDATE proje SET durum_id = @d WHERE projeid = @id", P("@d", durumId), P("@id", id));
            else
                Calistir("UPDATE gorev SET durum_id = @d WHERE gorevid = @id", P("@d", durumId), P("@id", id));

            ListeleriYenile();
        }

        private void Sil(DataGridView dgv, KayitTuru tur, int id)
        {
            string ad = SeciliKayitAdi(dgv);
            string soru, sql;

            switch (tur)
            {
                case KayitTuru.Proje:
                    int gorevSayisi = Convert.ToInt32(Deger("SELECT COUNT(*) FROM gorev WHERE projeid = @id", P("@id", id)));
                    soru = gorevSayisi > 0
                        ? string.Format(Tr, "\"{0}\" projesi ve projeye ait {1} görev kalıcı olarak silinecek.", ad, gorevSayisi)
                        : string.Format(Tr, "\"{0}\" projesi kalıcı olarak silinecek.", ad);
                    sql = "SET XACT_ABORT ON; BEGIN TRAN; " +
                          "DELETE FROM gorev WHERE projeid = @id; DELETE FROM proje WHERE projeid = @id; COMMIT;";
                    break;

                case KayitTuru.Calisan:
                    int atanan = Convert.ToInt32(Deger("SELECT COUNT(*) FROM gorev WHERE calisanid = @id", P("@id", id)));
                    soru = atanan > 0
                        ? string.Format(Tr, "\"{0}\" silinecek. Ona atanmış {1} görev \"atanmamış\" olarak kalacak.", ad, atanan)
                        : string.Format(Tr, "\"{0}\" kalıcı olarak silinecek.", ad);
                    sql = "SET XACT_ABORT ON; BEGIN TRAN; " +
                          "UPDATE gorev SET calisanid = NULL WHERE calisanid = @id; DELETE FROM calisan WHERE calisanid = @id; COMMIT;";
                    break;

                default:
                    soru = string.Format(Tr, "\"{0}\" görevi kalıcı olarak silinecek.", ad);
                    sql = "DELETE FROM gorev WHERE gorevid = @id";
                    break;
            }

            if (MessageBox.Show(soru + "\n\nBu işlem geri alınamaz. Devam edilsin mi?", "Silme Onayı",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) != DialogResult.Yes)
                return;

            Calistir(sql, P("@id", id));
            ListeleriYenile();
        }

        private void ProjeGorevlerineGit(int projeId)
        {
            tcAna.SelectedTab = tpProjeler;
            tcProjeler.SelectedTab = tpProjeGorevleri;
            cbProjeSec.SelectedValue = projeId;
        }

        private void CalisaniDuzenle(int calisanId)
        {
            tcCalisanlar.SelectedTab = tpCalisanGuncelle;
            cbGuncellenecekCalisan.SelectedValue = calisanId;
        }

        private void CalisanGorevlerineGit(int calisanId)
        {
            tcCalisanlar.SelectedTab = tpCalisanGorevleri;
            cbCalisanSec.SelectedValue = calisanId;
        }

        /// <summary>Bir kayıt değiştiğinde tüm listeleri yeniler; açık seçimler korunur.</summary>
        private void ListeleriYenile()
        {
            object seciliProje = cbProjeSec.SelectedValue;
            object seciliCalisan = cbCalisanSec.SelectedValue;
            object guncellenecek = cbGuncellenecekCalisan.SelectedValue;

            Yenile(ProjeleriYukle, CalisanlariYukle, GorevleriYukle, AnasayfayiYukle, () =>
            {
                if (seciliProje != null) cbProjeSec.SelectedValue = seciliProje;
                if (seciliCalisan != null) cbCalisanSec.SelectedValue = seciliCalisan;
                if (guncellenecek != null) cbGuncellenecekCalisan.SelectedValue = guncellenecek;
            });

            ProjeGorevleriniGoster();
            CalisanGorevleriniGoster();
            GuncellenecekCalisaniGoster();
        }

        #endregion
    }
}
