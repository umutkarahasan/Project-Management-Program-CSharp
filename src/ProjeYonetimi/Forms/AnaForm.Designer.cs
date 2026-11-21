using System.Data;

namespace ProjeYonetimi.Forms
{
    partial class AnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tcAna = new ReaLTaiizor.Controls.ForeverTabPage();
            this.tpAnasayfa = new System.Windows.Forms.TabPage();
            this.lblOzet = new System.Windows.Forms.Label();
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.chartButce = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.takvim = new ReaLTaiizor.Controls.HopeDatePicker();
            this.tpProjeler = new System.Windows.Forms.TabPage();
            this.tcProjeler = new ReaLTaiizor.Controls.AirTabPage();
            this.tpProjeListesi = new System.Windows.Forms.TabPage();
            this.dgvProjeler = new System.Windows.Forms.DataGridView();
            this.tpProjeEkle = new System.Windows.Forms.TabPage();
            this.pnlProjeEkle = new ReaLTaiizor.Controls.Panel();
            this.txtSahip = new System.Windows.Forms.TextBox();
            this.btnProjeKaydet = new ReaLTaiizor.Controls.ThunderButton();
            this.lblButce = new ReaLTaiizor.Controls.MetroLabel();
            this.lblProjeBitis = new ReaLTaiizor.Controls.MetroLabel();
            this.lblProjeBaslangic = new ReaLTaiizor.Controls.MetroLabel();
            this.lblProjeDurum = new ReaLTaiizor.Controls.MetroLabel();
            this.lblProjeOncelik = new ReaLTaiizor.Controls.MetroLabel();
            this.lblSahip = new ReaLTaiizor.Controls.MetroLabel();
            this.lblProjeAdi = new ReaLTaiizor.Controls.MetroLabel();
            this.txtProjeAdi = new System.Windows.Forms.TextBox();
            this.txtProjeBitisYazi = new System.Windows.Forms.TextBox();
            this.dtpProjeBitis = new System.Windows.Forms.DateTimePicker();
            this.txtButce = new System.Windows.Forms.TextBox();
            this.dtpProjeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.cbProjeOncelik = new ReaLTaiizor.Controls.AloneComboBox();
            this.cbProjeDurum = new ReaLTaiizor.Controls.AloneComboBox();
            this.tpGuncelProjeler = new System.Windows.Forms.TabPage();
            this.dgvGuncelProjeler = new System.Windows.Forms.DataGridView();
            this.tpYeniProjeler = new System.Windows.Forms.TabPage();
            this.dgvYeniProjeler = new System.Windows.Forms.DataGridView();
            this.tpTamamlananProjeler = new System.Windows.Forms.TabPage();
            this.dgvTamamlananProjeler = new System.Windows.Forms.DataGridView();
            this.tpProjeGuncelle = new System.Windows.Forms.TabPage();
            this.btnProjeGuncelle = new ReaLTaiizor.Controls.AirButton();
            this.dgvProjeGuncelle = new System.Windows.Forms.DataGridView();
            this.tpProjeGorevleri = new System.Windows.Forms.TabPage();
            this.dgvProjeGorevleri = new System.Windows.Forms.DataGridView();
            this.lblProjeGorevleri = new ReaLTaiizor.Controls.MetroLabel();
            this.lblProjeSec = new ReaLTaiizor.Controls.MetroLabel();
            this.cbProjeSec = new ReaLTaiizor.Controls.AloneComboBox();
            this.tpCalisanlar = new System.Windows.Forms.TabPage();
            this.tcCalisanlar = new ReaLTaiizor.Controls.AirTabPage();
            this.tpCalisanListesi = new System.Windows.Forms.TabPage();
            this.dgvCalisanlar = new System.Windows.Forms.DataGridView();
            this.tpCalisanEkle = new System.Windows.Forms.TabPage();
            this.cbCalisanTecrube = new ReaLTaiizor.Controls.AloneComboBox();
            this.lblCalisanTecrube = new ReaLTaiizor.Controls.MetroLabel();
            this.cbCalisanUnvan = new ReaLTaiizor.Controls.AloneComboBox();
            this.btnCalisanKaydet = new ReaLTaiizor.Controls.ThunderButton();
            this.txtCeposta = new System.Windows.Forms.TextBox();
            this.txtCtel = new System.Windows.Forms.TextBox();
            this.txtCsoyadi = new System.Windows.Forms.TextBox();
            this.lblCalisanUnvan = new ReaLTaiizor.Controls.MetroLabel();
            this.lblCalisanTel = new ReaLTaiizor.Controls.MetroLabel();
            this.lblCalisanEposta = new ReaLTaiizor.Controls.MetroLabel();
            this.lblCalisanSoyadi = new ReaLTaiizor.Controls.MetroLabel();
            this.lblCalisanAdi = new ReaLTaiizor.Controls.MetroLabel();
            this.txtCadi = new System.Windows.Forms.TextBox();
            this.tpCalisanGuncelle = new System.Windows.Forms.TabPage();
            this.cbGuncelTecrube = new ReaLTaiizor.Controls.AloneComboBox();
            this.lblGuncelTecrube = new ReaLTaiizor.Controls.MetroLabel();
            this.cbGuncelUnvan = new ReaLTaiizor.Controls.AloneComboBox();
            this.btnCalisanGuncelle = new ReaLTaiizor.Controls.ThunderButton();
            this.txtGuncelEposta = new System.Windows.Forms.TextBox();
            this.txtGuncelTel = new System.Windows.Forms.TextBox();
            this.txtGuncelSoyadi = new System.Windows.Forms.TextBox();
            this.lblGuncelUnvan = new ReaLTaiizor.Controls.MetroLabel();
            this.lblGuncelTel = new ReaLTaiizor.Controls.MetroLabel();
            this.lblGuncelEposta = new ReaLTaiizor.Controls.MetroLabel();
            this.lblGuncelSoyadi = new ReaLTaiizor.Controls.MetroLabel();
            this.lblGuncelAdi = new ReaLTaiizor.Controls.MetroLabel();
            this.txtGuncelAdi = new System.Windows.Forms.TextBox();
            this.lblGuncellenecekCalisan = new ReaLTaiizor.Controls.MetroLabel();
            this.cbGuncellenecekCalisan = new ReaLTaiizor.Controls.AloneComboBox();
            this.tpCalisanGorevleri = new System.Windows.Forms.TabPage();
            this.lblCalisanGorevleri = new ReaLTaiizor.Controls.MetroLabel();
            this.lblCalisanSec = new ReaLTaiizor.Controls.MetroLabel();
            this.dgvCalisanGorevleri = new System.Windows.Forms.DataGridView();
            this.cbCalisanSec = new ReaLTaiizor.Controls.AloneComboBox();
            this.tpGorevler = new System.Windows.Forms.TabPage();
            this.tcGorevler = new ReaLTaiizor.Controls.AirTabPage();
            this.tpKategoriler = new System.Windows.Forms.TabPage();
            this.lblKategoriEkle = new ReaLTaiizor.Controls.MetroLabel();
            this.btnKategoriEkle = new ReaLTaiizor.Controls.AirButton();
            this.txtKategoriAdi = new System.Windows.Forms.TextBox();
            this.lblKategoriler = new ReaLTaiizor.Controls.MetroLabel();
            this.lstKategoriler = new ReaLTaiizor.Controls.MetroListBox();
            this.tpGorevListesi = new System.Windows.Forms.TabPage();
            this.dgvGorevler = new System.Windows.Forms.DataGridView();
            this.tpGorevEkle = new System.Windows.Forms.TabPage();
            this.lblGorevProje = new ReaLTaiizor.Controls.MetroLabel();
            this.cbGorevProje = new ReaLTaiizor.Controls.AloneComboBox();
            this.lblGorevKategori = new ReaLTaiizor.Controls.MetroLabel();
            this.cbGorevKategori = new ReaLTaiizor.Controls.AloneComboBox();
            this.lblGorevAciklama = new ReaLTaiizor.Controls.MetroLabel();
            this.txtGorevAciklama = new System.Windows.Forms.TextBox();
            this.txtGorevMaliyet = new System.Windows.Forms.TextBox();
            this.cbGorevAtanan = new ReaLTaiizor.Controls.AloneComboBox();
            this.cbGorevDurum = new ReaLTaiizor.Controls.AloneComboBox();
            this.cbGorevOncelik = new ReaLTaiizor.Controls.AloneComboBox();
            this.txtGorevBitisYazi = new System.Windows.Forms.TextBox();
            this.dtpGorevBitis = new System.Windows.Forms.DateTimePicker();
            this.dtpGorevBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblGorevMaliyet = new ReaLTaiizor.Controls.MetroLabel();
            this.btnGorevKaydet = new ReaLTaiizor.Controls.ThunderButton();
            this.lblGorevDurum = new ReaLTaiizor.Controls.MetroLabel();
            this.lblGorevOncelik = new ReaLTaiizor.Controls.MetroLabel();
            this.lblGorevBitis = new ReaLTaiizor.Controls.MetroLabel();
            this.lblGorevBaslangic = new ReaLTaiizor.Controls.MetroLabel();
            this.lblGorevAtanan = new ReaLTaiizor.Controls.MetroLabel();
            this.lblGorevAdi = new ReaLTaiizor.Controls.MetroLabel();
            this.txtGorevAdi = new System.Windows.Forms.TextBox();
            this.tmrSaat = new System.Windows.Forms.Timer(this.components);
            this.lblSaat = new ReaLTaiizor.Controls.ThunderLabel();
            this.tcAna.SuspendLayout();
            this.tpAnasayfa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartButce)).BeginInit();
            this.tpProjeler.SuspendLayout();
            this.tcProjeler.SuspendLayout();
            this.tpProjeListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).BeginInit();
            this.tpProjeEkle.SuspendLayout();
            this.pnlProjeEkle.SuspendLayout();
            this.tpGuncelProjeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuncelProjeler)).BeginInit();
            this.tpYeniProjeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeniProjeler)).BeginInit();
            this.tpTamamlananProjeler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamamlananProjeler)).BeginInit();
            this.tpProjeGuncelle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeGuncelle)).BeginInit();
            this.tpProjeGorevleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeGorevleri)).BeginInit();
            this.tpCalisanlar.SuspendLayout();
            this.tcCalisanlar.SuspendLayout();
            this.tpCalisanListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).BeginInit();
            this.tpCalisanEkle.SuspendLayout();
            this.tpCalisanGuncelle.SuspendLayout();
            this.tpCalisanGorevleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanGorevleri)).BeginInit();
            this.tpGorevler.SuspendLayout();
            this.tcGorevler.SuspendLayout();
            this.tpKategoriler.SuspendLayout();
            this.tpGorevListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).BeginInit();
            this.tpGorevEkle.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcAna
            // 
            this.tcAna.ActiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.tcAna.ActiveFontColor = System.Drawing.Color.White;
            this.tcAna.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.tcAna.BGColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tcAna.Controls.Add(this.tpAnasayfa);
            this.tcAna.Controls.Add(this.tpProjeler);
            this.tcAna.Controls.Add(this.tpCalisanlar);
            this.tcAna.Controls.Add(this.tpGorevler);
            this.tcAna.DeactiveFontColor = System.Drawing.Color.White;
            this.tcAna.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tcAna.ItemSize = new System.Drawing.Size(120, 40);
            this.tcAna.Location = new System.Drawing.Point(-4, 50);
            this.tcAna.Margin = new System.Windows.Forms.Padding(2);
            this.tcAna.Name = "tcAna";
            this.tcAna.SelectedIndex = 0;
            this.tcAna.Size = new System.Drawing.Size(1017, 537);
            this.tcAna.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcAna.TabIndex = 0;
            this.tcAna.SelectedIndexChanged += new System.EventHandler(this.Sekme_SelectedIndexChanged);
            // 
            // tpAnasayfa
            // 
            this.tpAnasayfa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tpAnasayfa.Controls.Add(this.lblOzet);
            this.tpAnasayfa.Controls.Add(this.lblHosgeldin);
            this.tpAnasayfa.Controls.Add(this.chartButce);
            this.tpAnasayfa.Controls.Add(this.takvim);
            this.tpAnasayfa.Location = new System.Drawing.Point(4, 44);
            this.tpAnasayfa.Margin = new System.Windows.Forms.Padding(2);
            this.tpAnasayfa.Name = "tpAnasayfa";
            this.tpAnasayfa.Padding = new System.Windows.Forms.Padding(2);
            this.tpAnasayfa.Size = new System.Drawing.Size(1009, 489);
            this.tpAnasayfa.TabIndex = 0;
            this.tpAnasayfa.Text = "ANASAYFA";
            // 
            // lblOzet
            // 
            this.lblOzet.AutoSize = true;
            this.lblOzet.ForeColor = System.Drawing.Color.Red;
            this.lblOzet.Location = new System.Drawing.Point(572, 371);
            this.lblOzet.Name = "lblOzet";
            this.lblOzet.Size = new System.Drawing.Size(370, 19);
            this.lblOzet.TabIndex = 6;
            this.lblOzet.Text = "Grafikte projelerin bütçe dağılımı gösterilmektedir.";
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblHosgeldin.Location = new System.Drawing.Point(22, 371);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(316, 19);
            this.lblHosgeldin.TabIndex = 5;
            this.lblHosgeldin.Text = "PROJE YÖNETİMİ UYGULAMASINA HOŞ GELDİNİZ";
            // 
            // chartButce
            // 
            chartArea6.Name = "ChartArea1";
            this.chartButce.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.chartButce.Legends.Add(legend6);
            this.chartButce.Location = new System.Drawing.Point(576, 41);
            this.chartButce.Name = "chartButce";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series6.Legend = "Legend1";
            series6.Name = "seri1";
            this.chartButce.Series.Add(series6);
            this.chartButce.Size = new System.Drawing.Size(404, 309);
            this.chartButce.TabIndex = 4;
            this.chartButce.Text = "chartButce";
            // 
            // takvim
            // 
            this.takvim.BackColor = System.Drawing.Color.White;
            this.takvim.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.takvim.Date = System.DateTime.Today;
            this.takvim.DayNames = "MTWTFSS";
            this.takvim.DaysTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(96)))), ((int)(((byte)(98)))), ((int)(((byte)(102)))));
            this.takvim.DayTextColorA = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.takvim.DayTextColorB = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.takvim.HeaderFormat = "{0} Y - {1} M";
            this.takvim.HeaderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.takvim.HeadLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.takvim.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(238)))), ((int)(((byte)(245)))));
            this.takvim.Location = new System.Drawing.Point(26, 41);
            this.takvim.Margin = new System.Windows.Forms.Padding(2);
            this.takvim.Name = "takvim";
            this.takvim.NMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.takvim.NMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.takvim.NYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.takvim.NYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.takvim.PMColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.takvim.PMHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.takvim.PYColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.takvim.PYHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.takvim.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.takvim.SelectedTextColor = System.Drawing.Color.White;
            this.takvim.Size = new System.Drawing.Size(250, 270);
            this.takvim.TabIndex = 3;
            this.takvim.Text = "takvim";
            this.takvim.ValueTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(43)))), ((int)(((byte)(133)))), ((int)(((byte)(228)))));
            // 
            // tpProjeler
            // 
            this.tpProjeler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tpProjeler.Controls.Add(this.tcProjeler);
            this.tpProjeler.Location = new System.Drawing.Point(4, 44);
            this.tpProjeler.Margin = new System.Windows.Forms.Padding(2);
            this.tpProjeler.Name = "tpProjeler";
            this.tpProjeler.Padding = new System.Windows.Forms.Padding(2);
            this.tpProjeler.Size = new System.Drawing.Size(1009, 489);
            this.tpProjeler.TabIndex = 1;
            this.tpProjeler.Text = "PROJELER";
            // 
            // tcProjeler
            // 
            this.tcProjeler.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcProjeler.Controls.Add(this.tpProjeListesi);
            this.tcProjeler.Controls.Add(this.tpProjeEkle);
            this.tcProjeler.Controls.Add(this.tpGuncelProjeler);
            this.tcProjeler.Controls.Add(this.tpYeniProjeler);
            this.tcProjeler.Controls.Add(this.tpTamamlananProjeler);
            this.tcProjeler.Controls.Add(this.tpProjeGuncelle);
            this.tcProjeler.Controls.Add(this.tpProjeGorevleri);
            this.tcProjeler.ItemSize = new System.Drawing.Size(40, 140);
            this.tcProjeler.Location = new System.Drawing.Point(3, 3);
            this.tcProjeler.Multiline = true;
            this.tcProjeler.Name = "tcProjeler";
            this.tcProjeler.SelectedIndex = 0;
            this.tcProjeler.ShowOuterBorders = false;
            this.tcProjeler.Size = new System.Drawing.Size(998, 437);
            this.tcProjeler.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcProjeler.SquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.tcProjeler.TabIndex = 14;
            this.tcProjeler.SelectedIndexChanged += new System.EventHandler(this.Sekme_SelectedIndexChanged);
            // 
            // tpProjeListesi
            // 
            this.tpProjeListesi.BackColor = System.Drawing.Color.White;
            this.tpProjeListesi.Controls.Add(this.dgvProjeler);
            this.tpProjeListesi.Location = new System.Drawing.Point(144, 4);
            this.tpProjeListesi.Name = "tpProjeListesi";
            this.tpProjeListesi.Padding = new System.Windows.Forms.Padding(3);
            this.tpProjeListesi.Size = new System.Drawing.Size(850, 429);
            this.tpProjeListesi.TabIndex = 1;
            this.tpProjeListesi.Text = "Projeler";
            // 
            // dgvProjeler
            // 
            this.dgvProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjeler.Location = new System.Drawing.Point(6, 6);
            this.dgvProjeler.Name = "dgvProjeler";
            this.dgvProjeler.RowHeadersWidth = 51;
            this.dgvProjeler.Size = new System.Drawing.Size(841, 417);
            this.dgvProjeler.TabIndex = 0;
            // 
            // tpProjeEkle
            // 
            this.tpProjeEkle.BackColor = System.Drawing.Color.White;
            this.tpProjeEkle.Controls.Add(this.pnlProjeEkle);
            this.tpProjeEkle.Location = new System.Drawing.Point(144, 4);
            this.tpProjeEkle.Name = "tpProjeEkle";
            this.tpProjeEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tpProjeEkle.Size = new System.Drawing.Size(850, 429);
            this.tpProjeEkle.TabIndex = 0;
            this.tpProjeEkle.Text = "Proje Ekle";
            // 
            // pnlProjeEkle
            // 
            this.pnlProjeEkle.BackColor = System.Drawing.Color.White;
            this.pnlProjeEkle.Controls.Add(this.txtSahip);
            this.pnlProjeEkle.Controls.Add(this.btnProjeKaydet);
            this.pnlProjeEkle.Controls.Add(this.lblButce);
            this.pnlProjeEkle.Controls.Add(this.lblProjeBitis);
            this.pnlProjeEkle.Controls.Add(this.lblProjeBaslangic);
            this.pnlProjeEkle.Controls.Add(this.lblProjeDurum);
            this.pnlProjeEkle.Controls.Add(this.lblProjeOncelik);
            this.pnlProjeEkle.Controls.Add(this.lblSahip);
            this.pnlProjeEkle.Controls.Add(this.lblProjeAdi);
            this.pnlProjeEkle.Controls.Add(this.txtProjeAdi);
            this.pnlProjeEkle.Controls.Add(this.txtProjeBitisYazi);
            this.pnlProjeEkle.Controls.Add(this.dtpProjeBitis);
            this.pnlProjeEkle.Controls.Add(this.txtButce);
            this.pnlProjeEkle.Controls.Add(this.dtpProjeBaslangic);
            this.pnlProjeEkle.Controls.Add(this.cbProjeOncelik);
            this.pnlProjeEkle.Controls.Add(this.cbProjeDurum);
            this.pnlProjeEkle.EdgeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.pnlProjeEkle.Location = new System.Drawing.Point(5, 2);
            this.pnlProjeEkle.Margin = new System.Windows.Forms.Padding(2);
            this.pnlProjeEkle.Name = "pnlProjeEkle";
            this.pnlProjeEkle.Padding = new System.Windows.Forms.Padding(4);
            this.pnlProjeEkle.Size = new System.Drawing.Size(845, 422);
            this.pnlProjeEkle.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pnlProjeEkle.TabIndex = 14;
            this.pnlProjeEkle.Text = "pnlProjeEkle";
            // 
            // txtSahip
            // 
            this.txtSahip.Location = new System.Drawing.Point(220, 84);
            this.txtSahip.Margin = new System.Windows.Forms.Padding(2);
            this.txtSahip.Name = "txtSahip";
            this.txtSahip.Size = new System.Drawing.Size(162, 25);
            this.txtSahip.TabIndex = 24;
            // 
            // btnProjeKaydet
            // 
            this.btnProjeKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnProjeKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjeKaydet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnProjeKaydet.Location = new System.Drawing.Point(552, 233);
            this.btnProjeKaydet.Margin = new System.Windows.Forms.Padding(2);
            this.btnProjeKaydet.Name = "btnProjeKaydet";
            this.btnProjeKaydet.Size = new System.Drawing.Size(194, 32);
            this.btnProjeKaydet.TabIndex = 23;
            this.btnProjeKaydet.Text = "KAYDET";
            this.btnProjeKaydet.Click += new System.EventHandler(this.btnProjeKaydet_Click);
            // 
            // lblButce
            // 
            this.lblButce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblButce.IsDerivedStyle = true;
            this.lblButce.Location = new System.Drawing.Point(424, 185);
            this.lblButce.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblButce.Name = "lblButce";
            this.lblButce.Size = new System.Drawing.Size(75, 19);
            this.lblButce.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblButce.StyleManager = null;
            this.lblButce.TabIndex = 18;
            this.lblButce.Text = "Bütçe";
            this.lblButce.ThemeAuthor = "Taiizor";
            this.lblButce.ThemeName = "MetroLight";
            // 
            // lblProjeBitis
            // 
            this.lblProjeBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjeBitis.IsDerivedStyle = true;
            this.lblProjeBitis.Location = new System.Drawing.Point(424, 138);
            this.lblProjeBitis.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjeBitis.Name = "lblProjeBitis";
            this.lblProjeBitis.Size = new System.Drawing.Size(75, 19);
            this.lblProjeBitis.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblProjeBitis.StyleManager = null;
            this.lblProjeBitis.TabIndex = 17;
            this.lblProjeBitis.Text = "Bitiş Tarihi";
            this.lblProjeBitis.ThemeAuthor = "Taiizor";
            this.lblProjeBitis.ThemeName = "MetroLight";
            // 
            // lblProjeBaslangic
            // 
            this.lblProjeBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjeBaslangic.IsDerivedStyle = true;
            this.lblProjeBaslangic.Location = new System.Drawing.Point(424, 90);
            this.lblProjeBaslangic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjeBaslangic.Name = "lblProjeBaslangic";
            this.lblProjeBaslangic.Size = new System.Drawing.Size(113, 19);
            this.lblProjeBaslangic.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblProjeBaslangic.StyleManager = null;
            this.lblProjeBaslangic.TabIndex = 16;
            this.lblProjeBaslangic.Text = "Başlangıç Tarihi";
            this.lblProjeBaslangic.ThemeAuthor = "Taiizor";
            this.lblProjeBaslangic.ThemeName = "MetroLight";
            // 
            // lblProjeDurum
            // 
            this.lblProjeDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjeDurum.IsDerivedStyle = true;
            this.lblProjeDurum.Location = new System.Drawing.Point(122, 184);
            this.lblProjeDurum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjeDurum.Name = "lblProjeDurum";
            this.lblProjeDurum.Size = new System.Drawing.Size(75, 19);
            this.lblProjeDurum.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblProjeDurum.StyleManager = null;
            this.lblProjeDurum.TabIndex = 15;
            this.lblProjeDurum.Text = "Durum";
            this.lblProjeDurum.ThemeAuthor = "Taiizor";
            this.lblProjeDurum.ThemeName = "MetroLight";
            // 
            // lblProjeOncelik
            // 
            this.lblProjeOncelik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjeOncelik.IsDerivedStyle = true;
            this.lblProjeOncelik.Location = new System.Drawing.Point(122, 138);
            this.lblProjeOncelik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjeOncelik.Name = "lblProjeOncelik";
            this.lblProjeOncelik.Size = new System.Drawing.Size(75, 19);
            this.lblProjeOncelik.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblProjeOncelik.StyleManager = null;
            this.lblProjeOncelik.TabIndex = 14;
            this.lblProjeOncelik.Text = "Öncelik";
            this.lblProjeOncelik.ThemeAuthor = "Taiizor";
            this.lblProjeOncelik.ThemeName = "MetroLight";
            // 
            // lblSahip
            // 
            this.lblSahip.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblSahip.IsDerivedStyle = true;
            this.lblSahip.Location = new System.Drawing.Point(122, 87);
            this.lblSahip.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSahip.Name = "lblSahip";
            this.lblSahip.Size = new System.Drawing.Size(75, 19);
            this.lblSahip.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblSahip.StyleManager = null;
            this.lblSahip.TabIndex = 12;
            this.lblSahip.Text = "Sahip";
            this.lblSahip.ThemeAuthor = "Taiizor";
            this.lblSahip.ThemeName = "MetroLight";
            // 
            // lblProjeAdi
            // 
            this.lblProjeAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblProjeAdi.IsDerivedStyle = true;
            this.lblProjeAdi.Location = new System.Drawing.Point(105, 21);
            this.lblProjeAdi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjeAdi.Name = "lblProjeAdi";
            this.lblProjeAdi.Size = new System.Drawing.Size(110, 28);
            this.lblProjeAdi.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblProjeAdi.StyleManager = null;
            this.lblProjeAdi.TabIndex = 11;
            this.lblProjeAdi.Text = "Proje Adı";
            this.lblProjeAdi.ThemeAuthor = "Taiizor";
            this.lblProjeAdi.ThemeName = "MetroLight";
            // 
            // txtProjeAdi
            // 
            this.txtProjeAdi.Location = new System.Drawing.Point(220, 24);
            this.txtProjeAdi.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjeAdi.Name = "txtProjeAdi";
            this.txtProjeAdi.Size = new System.Drawing.Size(526, 25);
            this.txtProjeAdi.TabIndex = 10;
            // 
            // txtProjeBitisYazi
            // 
            this.txtProjeBitisYazi.Location = new System.Drawing.Point(551, 132);
            this.txtProjeBitisYazi.Margin = new System.Windows.Forms.Padding(2);
            this.txtProjeBitisYazi.Name = "txtProjeBitisYazi";
            this.txtProjeBitisYazi.Size = new System.Drawing.Size(180, 25);
            this.txtProjeBitisYazi.TabIndex = 8;
            // 
            // dtpProjeBitis
            // 
            this.dtpProjeBitis.Location = new System.Drawing.Point(724, 132);
            this.dtpProjeBitis.Margin = new System.Windows.Forms.Padding(2);
            this.dtpProjeBitis.Name = "dtpProjeBitis";
            this.dtpProjeBitis.Size = new System.Drawing.Size(22, 25);
            this.dtpProjeBitis.TabIndex = 6;
            this.dtpProjeBitis.ValueChanged += new System.EventHandler(this.dtpProjeBitis_ValueChanged);
            // 
            // txtButce
            // 
            this.txtButce.Location = new System.Drawing.Point(551, 178);
            this.txtButce.Margin = new System.Windows.Forms.Padding(2);
            this.txtButce.Name = "txtButce";
            this.txtButce.Size = new System.Drawing.Size(195, 25);
            this.txtButce.TabIndex = 9;
            this.txtButce.Text = "₺0,00";
            this.txtButce.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dtpProjeBaslangic
            // 
            this.dtpProjeBaslangic.Location = new System.Drawing.Point(551, 84);
            this.dtpProjeBaslangic.Margin = new System.Windows.Forms.Padding(2);
            this.dtpProjeBaslangic.Name = "dtpProjeBaslangic";
            this.dtpProjeBaslangic.Size = new System.Drawing.Size(195, 25);
            this.dtpProjeBaslangic.TabIndex = 5;
            // 
            // cbProjeOncelik
            // 
            this.cbProjeOncelik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProjeOncelik.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProjeOncelik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjeOncelik.EnabledCalc = true;
            this.cbProjeOncelik.FormattingEnabled = true;
            this.cbProjeOncelik.ItemHeight = 20;
            this.cbProjeOncelik.Location = new System.Drawing.Point(220, 138);
            this.cbProjeOncelik.Margin = new System.Windows.Forms.Padding(2);
            this.cbProjeOncelik.Name = "cbProjeOncelik";
            this.cbProjeOncelik.Size = new System.Drawing.Size(162, 26);
            this.cbProjeOncelik.TabIndex = 2;
            // 
            // cbProjeDurum
            // 
            this.cbProjeDurum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProjeDurum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProjeDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjeDurum.EnabledCalc = true;
            this.cbProjeDurum.FormattingEnabled = true;
            this.cbProjeDurum.ItemHeight = 20;
            this.cbProjeDurum.Location = new System.Drawing.Point(220, 184);
            this.cbProjeDurum.Margin = new System.Windows.Forms.Padding(2);
            this.cbProjeDurum.Name = "cbProjeDurum";
            this.cbProjeDurum.Size = new System.Drawing.Size(162, 26);
            this.cbProjeDurum.TabIndex = 3;
                        // 
            // tpGuncelProjeler
            // 
            this.tpGuncelProjeler.BackColor = System.Drawing.Color.White;
            this.tpGuncelProjeler.Controls.Add(this.dgvGuncelProjeler);
            this.tpGuncelProjeler.Location = new System.Drawing.Point(144, 4);
            this.tpGuncelProjeler.Name = "tpGuncelProjeler";
            this.tpGuncelProjeler.Size = new System.Drawing.Size(850, 429);
            this.tpGuncelProjeler.TabIndex = 7;
            this.tpGuncelProjeler.Text = "Güncel Projeler";
            // 
            // dgvGuncelProjeler
            // 
            this.dgvGuncelProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGuncelProjeler.Location = new System.Drawing.Point(3, 3);
            this.dgvGuncelProjeler.Name = "dgvGuncelProjeler";
            this.dgvGuncelProjeler.RowHeadersWidth = 51;
            this.dgvGuncelProjeler.Size = new System.Drawing.Size(844, 423);
            this.dgvGuncelProjeler.TabIndex = 0;
            // 
            // tpYeniProjeler
            // 
            this.tpYeniProjeler.BackColor = System.Drawing.Color.White;
            this.tpYeniProjeler.Controls.Add(this.dgvYeniProjeler);
            this.tpYeniProjeler.Location = new System.Drawing.Point(144, 4);
            this.tpYeniProjeler.Name = "tpYeniProjeler";
            this.tpYeniProjeler.Size = new System.Drawing.Size(850, 429);
            this.tpYeniProjeler.TabIndex = 6;
            this.tpYeniProjeler.Text = "Yeni Projeler";
            // 
            // dgvYeniProjeler
            // 
            this.dgvYeniProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvYeniProjeler.Location = new System.Drawing.Point(3, 3);
            this.dgvYeniProjeler.Name = "dgvYeniProjeler";
            this.dgvYeniProjeler.RowHeadersWidth = 51;
            this.dgvYeniProjeler.Size = new System.Drawing.Size(844, 423);
            this.dgvYeniProjeler.TabIndex = 0;
            // 
            // tpTamamlananProjeler
            // 
            this.tpTamamlananProjeler.BackColor = System.Drawing.Color.White;
            this.tpTamamlananProjeler.Controls.Add(this.dgvTamamlananProjeler);
            this.tpTamamlananProjeler.Location = new System.Drawing.Point(144, 4);
            this.tpTamamlananProjeler.Name = "tpTamamlananProjeler";
            this.tpTamamlananProjeler.Size = new System.Drawing.Size(850, 429);
            this.tpTamamlananProjeler.TabIndex = 8;
            this.tpTamamlananProjeler.Text = "Tamamlanmış Projeler";
            // 
            // dgvTamamlananProjeler
            // 
            this.dgvTamamlananProjeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTamamlananProjeler.Location = new System.Drawing.Point(3, 3);
            this.dgvTamamlananProjeler.Name = "dgvTamamlananProjeler";
            this.dgvTamamlananProjeler.RowHeadersWidth = 51;
            this.dgvTamamlananProjeler.Size = new System.Drawing.Size(847, 423);
            this.dgvTamamlananProjeler.TabIndex = 0;
            // 
            // tpProjeGuncelle
            // 
            this.tpProjeGuncelle.BackColor = System.Drawing.Color.White;
            this.tpProjeGuncelle.Controls.Add(this.btnProjeGuncelle);
            this.tpProjeGuncelle.Controls.Add(this.dgvProjeGuncelle);
            this.tpProjeGuncelle.Location = new System.Drawing.Point(144, 4);
            this.tpProjeGuncelle.Name = "tpProjeGuncelle";
            this.tpProjeGuncelle.Size = new System.Drawing.Size(850, 429);
            this.tpProjeGuncelle.TabIndex = 2;
            this.tpProjeGuncelle.Text = "Proje Güncelle";
            // 
            // btnProjeGuncelle
            // 
            this.btnProjeGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjeGuncelle.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnProjeGuncelle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnProjeGuncelle.Image = null;
            this.btnProjeGuncelle.Location = new System.Drawing.Point(549, 369);
            this.btnProjeGuncelle.Name = "btnProjeGuncelle";
            this.btnProjeGuncelle.NoRounding = false;
            this.btnProjeGuncelle.Size = new System.Drawing.Size(298, 45);
            this.btnProjeGuncelle.TabIndex = 2;
            this.btnProjeGuncelle.Text = "GÜNCELLE";
            this.btnProjeGuncelle.Transparent = false;
            this.btnProjeGuncelle.Click += new System.EventHandler(this.btnProjeGuncelle_Click);
            // 
            // dgvProjeGuncelle
            // 
            this.dgvProjeGuncelle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjeGuncelle.Location = new System.Drawing.Point(3, 3);
            this.dgvProjeGuncelle.Name = "dgvProjeGuncelle";
            this.dgvProjeGuncelle.RowHeadersWidth = 51;
            this.dgvProjeGuncelle.Size = new System.Drawing.Size(844, 360);
            this.dgvProjeGuncelle.TabIndex = 0;
            // 
            // tpProjeGorevleri
            // 
            this.tpProjeGorevleri.BackColor = System.Drawing.Color.White;
            this.tpProjeGorevleri.Controls.Add(this.dgvProjeGorevleri);
            this.tpProjeGorevleri.Controls.Add(this.lblProjeGorevleri);
            this.tpProjeGorevleri.Controls.Add(this.lblProjeSec);
            this.tpProjeGorevleri.Controls.Add(this.cbProjeSec);
            this.tpProjeGorevleri.Location = new System.Drawing.Point(144, 4);
            this.tpProjeGorevleri.Name = "tpProjeGorevleri";
            this.tpProjeGorevleri.Size = new System.Drawing.Size(850, 429);
            this.tpProjeGorevleri.TabIndex = 3;
            this.tpProjeGorevleri.Text = "Projenin Görevleri";
            // 
            // dgvProjeGorevleri
            // 
            this.dgvProjeGorevleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjeGorevleri.Location = new System.Drawing.Point(3, 115);
            this.dgvProjeGorevleri.Name = "dgvProjeGorevleri";
            this.dgvProjeGorevleri.RowHeadersWidth = 51;
            this.dgvProjeGorevleri.Size = new System.Drawing.Size(844, 311);
            this.dgvProjeGorevleri.TabIndex = 27;
            // 
            // lblProjeGorevleri
            // 
            this.lblProjeGorevleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjeGorevleri.IsDerivedStyle = true;
            this.lblProjeGorevleri.Location = new System.Drawing.Point(4, 81);
            this.lblProjeGorevleri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjeGorevleri.Name = "lblProjeGorevleri";
            this.lblProjeGorevleri.Size = new System.Drawing.Size(76, 31);
            this.lblProjeGorevleri.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblProjeGorevleri.StyleManager = null;
            this.lblProjeGorevleri.TabIndex = 26;
            this.lblProjeGorevleri.Text = "Görevler";
            this.lblProjeGorevleri.ThemeAuthor = "Taiizor";
            this.lblProjeGorevleri.ThemeName = "MetroLight";
            // 
            // lblProjeSec
            // 
            this.lblProjeSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblProjeSec.IsDerivedStyle = true;
            this.lblProjeSec.Location = new System.Drawing.Point(4, 18);
            this.lblProjeSec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProjeSec.Name = "lblProjeSec";
            this.lblProjeSec.Size = new System.Drawing.Size(75, 31);
            this.lblProjeSec.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblProjeSec.StyleManager = null;
            this.lblProjeSec.TabIndex = 24;
            this.lblProjeSec.Text = "Projeler";
            this.lblProjeSec.ThemeAuthor = "Taiizor";
            this.lblProjeSec.ThemeName = "MetroLight";
            // 
            // cbProjeSec
            // 
            this.cbProjeSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbProjeSec.DisplayMember = "ProjeAdi";
            this.cbProjeSec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbProjeSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProjeSec.EnabledCalc = true;
            this.cbProjeSec.FormattingEnabled = true;
            this.cbProjeSec.ItemHeight = 20;
            this.cbProjeSec.Location = new System.Drawing.Point(83, 18);
            this.cbProjeSec.Margin = new System.Windows.Forms.Padding(2);
            this.cbProjeSec.Name = "cbProjeSec";
            this.cbProjeSec.Size = new System.Drawing.Size(261, 26);
            this.cbProjeSec.TabIndex = 23;
            this.cbProjeSec.ValueMember = "projeid";
            this.cbProjeSec.SelectedIndexChanged += new System.EventHandler(this.cbProjeSec_SelectedIndexChanged);
            // 
            // tpCalisanlar
            // 
            this.tpCalisanlar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tpCalisanlar.Controls.Add(this.tcCalisanlar);
            this.tpCalisanlar.Location = new System.Drawing.Point(4, 44);
            this.tpCalisanlar.Margin = new System.Windows.Forms.Padding(2);
            this.tpCalisanlar.Name = "tpCalisanlar";
            this.tpCalisanlar.Size = new System.Drawing.Size(1009, 489);
            this.tpCalisanlar.TabIndex = 2;
            this.tpCalisanlar.Text = "ÇALIŞANLAR";
            // 
            // tcCalisanlar
            // 
            this.tcCalisanlar.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcCalisanlar.Controls.Add(this.tpCalisanListesi);
            this.tcCalisanlar.Controls.Add(this.tpCalisanEkle);
            this.tcCalisanlar.Controls.Add(this.tpCalisanGuncelle);
            this.tcCalisanlar.Controls.Add(this.tpCalisanGorevleri);
            this.tcCalisanlar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.tcCalisanlar.ItemSize = new System.Drawing.Size(50, 150);
            this.tcCalisanlar.Location = new System.Drawing.Point(5, 3);
            this.tcCalisanlar.Multiline = true;
            this.tcCalisanlar.Name = "tcCalisanlar";
            this.tcCalisanlar.Padding = new System.Drawing.Point(5, 10);
            this.tcCalisanlar.SelectedIndex = 0;
            this.tcCalisanlar.ShowOuterBorders = true;
            this.tcCalisanlar.Size = new System.Drawing.Size(996, 463);
            this.tcCalisanlar.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcCalisanlar.SquareColor = System.Drawing.Color.Black;
            this.tcCalisanlar.TabIndex = 25;
            // 
            // tpCalisanListesi
            // 
            this.tpCalisanListesi.BackColor = System.Drawing.Color.White;
            this.tpCalisanListesi.Controls.Add(this.dgvCalisanlar);
            this.tpCalisanListesi.Location = new System.Drawing.Point(154, 4);
            this.tpCalisanListesi.Name = "tpCalisanListesi";
            this.tpCalisanListesi.Size = new System.Drawing.Size(838, 455);
            this.tpCalisanListesi.TabIndex = 3;
            this.tpCalisanListesi.Text = "Çalışanlar";
            // 
            // dgvCalisanlar
            // 
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCalisanlar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanlar.Location = new System.Drawing.Point(3, 3);
            this.dgvCalisanlar.Name = "dgvCalisanlar";
            this.dgvCalisanlar.RowHeadersWidth = 51;
            this.dgvCalisanlar.Size = new System.Drawing.Size(832, 449);
            this.dgvCalisanlar.TabIndex = 0;
            // 
            // tpCalisanEkle
            // 
            this.tpCalisanEkle.BackColor = System.Drawing.Color.White;
            this.tpCalisanEkle.Controls.Add(this.cbCalisanTecrube);
            this.tpCalisanEkle.Controls.Add(this.lblCalisanTecrube);
            this.tpCalisanEkle.Controls.Add(this.cbCalisanUnvan);
            this.tpCalisanEkle.Controls.Add(this.btnCalisanKaydet);
            this.tpCalisanEkle.Controls.Add(this.txtCeposta);
            this.tpCalisanEkle.Controls.Add(this.txtCtel);
            this.tpCalisanEkle.Controls.Add(this.txtCsoyadi);
            this.tpCalisanEkle.Controls.Add(this.lblCalisanUnvan);
            this.tpCalisanEkle.Controls.Add(this.lblCalisanTel);
            this.tpCalisanEkle.Controls.Add(this.lblCalisanEposta);
            this.tpCalisanEkle.Controls.Add(this.lblCalisanSoyadi);
            this.tpCalisanEkle.Controls.Add(this.lblCalisanAdi);
            this.tpCalisanEkle.Controls.Add(this.txtCadi);
            this.tpCalisanEkle.Location = new System.Drawing.Point(154, 4);
            this.tpCalisanEkle.Name = "tpCalisanEkle";
            this.tpCalisanEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalisanEkle.Size = new System.Drawing.Size(838, 455);
            this.tpCalisanEkle.TabIndex = 0;
            this.tpCalisanEkle.Text = "Çalışan Ekle";
                        // 
            // cbCalisanTecrube
            // 
            this.cbCalisanTecrube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCalisanTecrube.DisplayMember = "unvan_adi";
            this.cbCalisanTecrube.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCalisanTecrube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalisanTecrube.EnabledCalc = true;
            this.cbCalisanTecrube.FormattingEnabled = true;
            this.cbCalisanTecrube.ItemHeight = 20;
            this.cbCalisanTecrube.Location = new System.Drawing.Point(262, 249);
            this.cbCalisanTecrube.Name = "cbCalisanTecrube";
            this.cbCalisanTecrube.Size = new System.Drawing.Size(185, 26);
            this.cbCalisanTecrube.TabIndex = 28;
            this.cbCalisanTecrube.ValueMember = "unvan_id";
            // 
            // lblCalisanTecrube
            // 
            this.lblCalisanTecrube.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCalisanTecrube.IsDerivedStyle = true;
            this.lblCalisanTecrube.Location = new System.Drawing.Point(101, 249);
            this.lblCalisanTecrube.Name = "lblCalisanTecrube";
            this.lblCalisanTecrube.Size = new System.Drawing.Size(100, 23);
            this.lblCalisanTecrube.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCalisanTecrube.StyleManager = null;
            this.lblCalisanTecrube.TabIndex = 27;
            this.lblCalisanTecrube.Text = "İş Deneyimi";
            this.lblCalisanTecrube.ThemeAuthor = "Taiizor";
            this.lblCalisanTecrube.ThemeName = "MetroLight";
            // 
            // cbCalisanUnvan
            // 
            this.cbCalisanUnvan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCalisanUnvan.DisplayMember = "unvan_adi";
            this.cbCalisanUnvan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCalisanUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalisanUnvan.EnabledCalc = true;
            this.cbCalisanUnvan.FormattingEnabled = true;
            this.cbCalisanUnvan.ItemHeight = 20;
            this.cbCalisanUnvan.Location = new System.Drawing.Point(262, 291);
            this.cbCalisanUnvan.Name = "cbCalisanUnvan";
            this.cbCalisanUnvan.Size = new System.Drawing.Size(185, 26);
            this.cbCalisanUnvan.TabIndex = 12;
            this.cbCalisanUnvan.ValueMember = "unvan_id";
            // 
            // btnCalisanKaydet
            // 
            this.btnCalisanKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnCalisanKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalisanKaydet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalisanKaydet.Location = new System.Drawing.Point(507, 42);
            this.btnCalisanKaydet.Name = "btnCalisanKaydet";
            this.btnCalisanKaydet.Size = new System.Drawing.Size(166, 127);
            this.btnCalisanKaydet.TabIndex = 11;
            this.btnCalisanKaydet.Text = "KAYDET";
            this.btnCalisanKaydet.Click += new System.EventHandler(this.btnCalisanKaydet_Click);
            // 
            // txtCeposta
            // 
            this.txtCeposta.Location = new System.Drawing.Point(262, 146);
            this.txtCeposta.Name = "txtCeposta";
            this.txtCeposta.Size = new System.Drawing.Size(185, 23);
            this.txtCeposta.TabIndex = 8;
            // 
            // txtCtel
            // 
            this.txtCtel.Location = new System.Drawing.Point(262, 202);
            this.txtCtel.Name = "txtCtel";
            this.txtCtel.Size = new System.Drawing.Size(185, 23);
            this.txtCtel.TabIndex = 8;
            // 
            // txtCsoyadi
            // 
            this.txtCsoyadi.Location = new System.Drawing.Point(262, 96);
            this.txtCsoyadi.Name = "txtCsoyadi";
            this.txtCsoyadi.Size = new System.Drawing.Size(185, 23);
            this.txtCsoyadi.TabIndex = 7;
            // 
            // lblCalisanUnvan
            // 
            this.lblCalisanUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCalisanUnvan.IsDerivedStyle = true;
            this.lblCalisanUnvan.Location = new System.Drawing.Point(101, 295);
            this.lblCalisanUnvan.Name = "lblCalisanUnvan";
            this.lblCalisanUnvan.Size = new System.Drawing.Size(100, 23);
            this.lblCalisanUnvan.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCalisanUnvan.StyleManager = null;
            this.lblCalisanUnvan.TabIndex = 6;
            this.lblCalisanUnvan.Text = "Unvanı";
            this.lblCalisanUnvan.ThemeAuthor = "Taiizor";
            this.lblCalisanUnvan.ThemeName = "MetroLight";
            // 
            // lblCalisanTel
            // 
            this.lblCalisanTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCalisanTel.IsDerivedStyle = true;
            this.lblCalisanTel.Location = new System.Drawing.Point(101, 202);
            this.lblCalisanTel.Name = "lblCalisanTel";
            this.lblCalisanTel.Size = new System.Drawing.Size(100, 23);
            this.lblCalisanTel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCalisanTel.StyleManager = null;
            this.lblCalisanTel.TabIndex = 4;
            this.lblCalisanTel.Text = "Tel No (5**)";
            this.lblCalisanTel.ThemeAuthor = "Taiizor";
            this.lblCalisanTel.ThemeName = "MetroLight";
            // 
            // lblCalisanEposta
            // 
            this.lblCalisanEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCalisanEposta.IsDerivedStyle = true;
            this.lblCalisanEposta.Location = new System.Drawing.Point(101, 146);
            this.lblCalisanEposta.Name = "lblCalisanEposta";
            this.lblCalisanEposta.Size = new System.Drawing.Size(100, 23);
            this.lblCalisanEposta.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCalisanEposta.StyleManager = null;
            this.lblCalisanEposta.TabIndex = 3;
            this.lblCalisanEposta.Text = "E-Posta";
            this.lblCalisanEposta.ThemeAuthor = "Taiizor";
            this.lblCalisanEposta.ThemeName = "MetroLight";
            // 
            // lblCalisanSoyadi
            // 
            this.lblCalisanSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCalisanSoyadi.IsDerivedStyle = true;
            this.lblCalisanSoyadi.Location = new System.Drawing.Point(101, 96);
            this.lblCalisanSoyadi.Name = "lblCalisanSoyadi";
            this.lblCalisanSoyadi.Size = new System.Drawing.Size(100, 23);
            this.lblCalisanSoyadi.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCalisanSoyadi.StyleManager = null;
            this.lblCalisanSoyadi.TabIndex = 2;
            this.lblCalisanSoyadi.Text = "Soyadı";
            this.lblCalisanSoyadi.ThemeAuthor = "Taiizor";
            this.lblCalisanSoyadi.ThemeName = "MetroLight";
            // 
            // lblCalisanAdi
            // 
            this.lblCalisanAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCalisanAdi.IsDerivedStyle = true;
            this.lblCalisanAdi.Location = new System.Drawing.Point(101, 42);
            this.lblCalisanAdi.Name = "lblCalisanAdi";
            this.lblCalisanAdi.Size = new System.Drawing.Size(100, 23);
            this.lblCalisanAdi.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCalisanAdi.StyleManager = null;
            this.lblCalisanAdi.TabIndex = 1;
            this.lblCalisanAdi.Text = "Adı";
            this.lblCalisanAdi.ThemeAuthor = "Taiizor";
            this.lblCalisanAdi.ThemeName = "MetroLight";
            // 
            // txtCadi
            // 
            this.txtCadi.Location = new System.Drawing.Point(262, 42);
            this.txtCadi.Name = "txtCadi";
            this.txtCadi.Size = new System.Drawing.Size(185, 23);
            this.txtCadi.TabIndex = 0;
            // 
            // tpCalisanGuncelle
            // 
            this.tpCalisanGuncelle.BackColor = System.Drawing.Color.White;
            this.tpCalisanGuncelle.Controls.Add(this.cbGuncelTecrube);
            this.tpCalisanGuncelle.Controls.Add(this.lblGuncelTecrube);
            this.tpCalisanGuncelle.Controls.Add(this.cbGuncelUnvan);
            this.tpCalisanGuncelle.Controls.Add(this.btnCalisanGuncelle);
            this.tpCalisanGuncelle.Controls.Add(this.txtGuncelEposta);
            this.tpCalisanGuncelle.Controls.Add(this.txtGuncelTel);
            this.tpCalisanGuncelle.Controls.Add(this.txtGuncelSoyadi);
            this.tpCalisanGuncelle.Controls.Add(this.lblGuncelUnvan);
            this.tpCalisanGuncelle.Controls.Add(this.lblGuncelTel);
            this.tpCalisanGuncelle.Controls.Add(this.lblGuncelEposta);
            this.tpCalisanGuncelle.Controls.Add(this.lblGuncelSoyadi);
            this.tpCalisanGuncelle.Controls.Add(this.lblGuncelAdi);
            this.tpCalisanGuncelle.Controls.Add(this.txtGuncelAdi);
            this.tpCalisanGuncelle.Controls.Add(this.lblGuncellenecekCalisan);
            this.tpCalisanGuncelle.Controls.Add(this.cbGuncellenecekCalisan);
            this.tpCalisanGuncelle.Location = new System.Drawing.Point(154, 4);
            this.tpCalisanGuncelle.Name = "tpCalisanGuncelle";
            this.tpCalisanGuncelle.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalisanGuncelle.Size = new System.Drawing.Size(838, 455);
            this.tpCalisanGuncelle.TabIndex = 1;
            this.tpCalisanGuncelle.Text = "Çalışan Güncelle";
            // 
            // cbGuncelTecrube
            // 
            this.cbGuncelTecrube.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGuncelTecrube.DisplayMember = "unvan_adi";
            this.cbGuncelTecrube.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGuncelTecrube.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuncelTecrube.EnabledCalc = true;
            this.cbGuncelTecrube.FormattingEnabled = true;
            this.cbGuncelTecrube.ItemHeight = 20;
            this.cbGuncelTecrube.Location = new System.Drawing.Point(210, 296);
            this.cbGuncelTecrube.Name = "cbGuncelTecrube";
            this.cbGuncelTecrube.Size = new System.Drawing.Size(185, 26);
            this.cbGuncelTecrube.TabIndex = 26;
            this.cbGuncelTecrube.ValueMember = "unvan_id";
            // 
            // lblGuncelTecrube
            // 
            this.lblGuncelTecrube.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGuncelTecrube.IsDerivedStyle = true;
            this.lblGuncelTecrube.Location = new System.Drawing.Point(49, 296);
            this.lblGuncelTecrube.Name = "lblGuncelTecrube";
            this.lblGuncelTecrube.Size = new System.Drawing.Size(100, 23);
            this.lblGuncelTecrube.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGuncelTecrube.StyleManager = null;
            this.lblGuncelTecrube.TabIndex = 25;
            this.lblGuncelTecrube.Text = "İş Deneyimi";
            this.lblGuncelTecrube.ThemeAuthor = "Taiizor";
            this.lblGuncelTecrube.ThemeName = "MetroLight";
            // 
            // cbGuncelUnvan
            // 
            this.cbGuncelUnvan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGuncelUnvan.DisplayMember = "unvan_adi";
            this.cbGuncelUnvan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGuncelUnvan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuncelUnvan.EnabledCalc = true;
            this.cbGuncelUnvan.FormattingEnabled = true;
            this.cbGuncelUnvan.ItemHeight = 20;
            this.cbGuncelUnvan.Location = new System.Drawing.Point(210, 343);
            this.cbGuncelUnvan.Name = "cbGuncelUnvan";
            this.cbGuncelUnvan.Size = new System.Drawing.Size(185, 26);
            this.cbGuncelUnvan.TabIndex = 24;
            this.cbGuncelUnvan.ValueMember = "unvan_id";
                        // 
            // btnCalisanGuncelle
            // 
            this.btnCalisanGuncelle.BackColor = System.Drawing.Color.Transparent;
            this.btnCalisanGuncelle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalisanGuncelle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCalisanGuncelle.Location = new System.Drawing.Point(484, 21);
            this.btnCalisanGuncelle.Name = "btnCalisanGuncelle";
            this.btnCalisanGuncelle.Size = new System.Drawing.Size(164, 120);
            this.btnCalisanGuncelle.TabIndex = 23;
            this.btnCalisanGuncelle.Text = "GÜNCELLE";
            this.btnCalisanGuncelle.Click += new System.EventHandler(this.btnCalisanGuncelle_Click);
            // 
            // 
            // txtGuncelEposta
            // 
            this.txtGuncelEposta.Location = new System.Drawing.Point(210, 191);
            this.txtGuncelEposta.Name = "txtGuncelEposta";
            this.txtGuncelEposta.Size = new System.Drawing.Size(185, 23);
            this.txtGuncelEposta.TabIndex = 19;
            // 
            // txtGuncelTel
            // 
            this.txtGuncelTel.Location = new System.Drawing.Point(210, 247);
            this.txtGuncelTel.Name = "txtGuncelTel";
            this.txtGuncelTel.Size = new System.Drawing.Size(185, 23);
            this.txtGuncelTel.TabIndex = 20;
            // 
            // txtGuncelSoyadi
            // 
            this.txtGuncelSoyadi.Location = new System.Drawing.Point(210, 141);
            this.txtGuncelSoyadi.Name = "txtGuncelSoyadi";
            this.txtGuncelSoyadi.Size = new System.Drawing.Size(185, 23);
            this.txtGuncelSoyadi.TabIndex = 18;
            // 
            // lblGuncelUnvan
            // 
            this.lblGuncelUnvan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGuncelUnvan.IsDerivedStyle = true;
            this.lblGuncelUnvan.Location = new System.Drawing.Point(49, 343);
            this.lblGuncelUnvan.Name = "lblGuncelUnvan";
            this.lblGuncelUnvan.Size = new System.Drawing.Size(100, 23);
            this.lblGuncelUnvan.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGuncelUnvan.StyleManager = null;
            this.lblGuncelUnvan.TabIndex = 17;
            this.lblGuncelUnvan.Text = "Unvanı";
            this.lblGuncelUnvan.ThemeAuthor = "Taiizor";
            this.lblGuncelUnvan.ThemeName = "MetroLight";
            // 
            // 
            // lblGuncelTel
            // 
            this.lblGuncelTel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGuncelTel.IsDerivedStyle = true;
            this.lblGuncelTel.Location = new System.Drawing.Point(49, 247);
            this.lblGuncelTel.Name = "lblGuncelTel";
            this.lblGuncelTel.Size = new System.Drawing.Size(100, 23);
            this.lblGuncelTel.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGuncelTel.StyleManager = null;
            this.lblGuncelTel.TabIndex = 15;
            this.lblGuncelTel.Text = "Tel No (5**)";
            this.lblGuncelTel.ThemeAuthor = "Taiizor";
            this.lblGuncelTel.ThemeName = "MetroLight";
            // 
            // lblGuncelEposta
            // 
            this.lblGuncelEposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGuncelEposta.IsDerivedStyle = true;
            this.lblGuncelEposta.Location = new System.Drawing.Point(49, 191);
            this.lblGuncelEposta.Name = "lblGuncelEposta";
            this.lblGuncelEposta.Size = new System.Drawing.Size(100, 23);
            this.lblGuncelEposta.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGuncelEposta.StyleManager = null;
            this.lblGuncelEposta.TabIndex = 14;
            this.lblGuncelEposta.Text = "E-Posta";
            this.lblGuncelEposta.ThemeAuthor = "Taiizor";
            this.lblGuncelEposta.ThemeName = "MetroLight";
            // 
            // lblGuncelSoyadi
            // 
            this.lblGuncelSoyadi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGuncelSoyadi.IsDerivedStyle = true;
            this.lblGuncelSoyadi.Location = new System.Drawing.Point(49, 141);
            this.lblGuncelSoyadi.Name = "lblGuncelSoyadi";
            this.lblGuncelSoyadi.Size = new System.Drawing.Size(100, 23);
            this.lblGuncelSoyadi.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGuncelSoyadi.StyleManager = null;
            this.lblGuncelSoyadi.TabIndex = 13;
            this.lblGuncelSoyadi.Text = "Soyadı";
            this.lblGuncelSoyadi.ThemeAuthor = "Taiizor";
            this.lblGuncelSoyadi.ThemeName = "MetroLight";
            // 
            // lblGuncelAdi
            // 
            this.lblGuncelAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGuncelAdi.IsDerivedStyle = true;
            this.lblGuncelAdi.Location = new System.Drawing.Point(49, 87);
            this.lblGuncelAdi.Name = "lblGuncelAdi";
            this.lblGuncelAdi.Size = new System.Drawing.Size(100, 23);
            this.lblGuncelAdi.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGuncelAdi.StyleManager = null;
            this.lblGuncelAdi.TabIndex = 12;
            this.lblGuncelAdi.Text = "Adı";
            this.lblGuncelAdi.ThemeAuthor = "Taiizor";
            this.lblGuncelAdi.ThemeName = "MetroLight";
            // 
            // txtGuncelAdi
            // 
            this.txtGuncelAdi.Location = new System.Drawing.Point(210, 87);
            this.txtGuncelAdi.Name = "txtGuncelAdi";
            this.txtGuncelAdi.Size = new System.Drawing.Size(185, 23);
            this.txtGuncelAdi.TabIndex = 11;
            // 
            // lblGuncellenecekCalisan
            // 
            this.lblGuncellenecekCalisan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGuncellenecekCalisan.IsDerivedStyle = true;
            this.lblGuncellenecekCalisan.Location = new System.Drawing.Point(49, 21);
            this.lblGuncellenecekCalisan.Name = "lblGuncellenecekCalisan";
            this.lblGuncellenecekCalisan.Size = new System.Drawing.Size(119, 53);
            this.lblGuncellenecekCalisan.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGuncellenecekCalisan.StyleManager = null;
            this.lblGuncellenecekCalisan.TabIndex = 1;
            this.lblGuncellenecekCalisan.Text = "Güncellenecek Çalışan";
            this.lblGuncellenecekCalisan.ThemeAuthor = "Taiizor";
            this.lblGuncellenecekCalisan.ThemeName = "MetroLight";
            // 
            // cbGuncellenecekCalisan
            // 
            this.cbGuncellenecekCalisan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGuncellenecekCalisan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGuncellenecekCalisan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGuncellenecekCalisan.EnabledCalc = true;
            this.cbGuncellenecekCalisan.FormattingEnabled = true;
            this.cbGuncellenecekCalisan.ItemHeight = 20;
            this.cbGuncellenecekCalisan.Location = new System.Drawing.Point(210, 21);
            this.cbGuncellenecekCalisan.Name = "cbGuncellenecekCalisan";
            this.cbGuncellenecekCalisan.Size = new System.Drawing.Size(185, 26);
            this.cbGuncellenecekCalisan.TabIndex = 0;
            this.cbGuncellenecekCalisan.SelectedIndexChanged += new System.EventHandler(this.cbGuncellenecekCalisan_SelectedIndexChanged);
            // 
            // tpCalisanGorevleri
            // 
            this.tpCalisanGorevleri.BackColor = System.Drawing.Color.White;
            this.tpCalisanGorevleri.Controls.Add(this.lblCalisanGorevleri);
            this.tpCalisanGorevleri.Controls.Add(this.lblCalisanSec);
            this.tpCalisanGorevleri.Controls.Add(this.dgvCalisanGorevleri);
            this.tpCalisanGorevleri.Controls.Add(this.cbCalisanSec);
            this.tpCalisanGorevleri.Location = new System.Drawing.Point(154, 4);
            this.tpCalisanGorevleri.Name = "tpCalisanGorevleri";
            this.tpCalisanGorevleri.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalisanGorevleri.Size = new System.Drawing.Size(838, 455);
            this.tpCalisanGorevleri.TabIndex = 2;
            this.tpCalisanGorevleri.Text = "Çalışanların Görevleri";
            // 
            // lblCalisanGorevleri
            // 
            this.lblCalisanGorevleri.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCalisanGorevleri.IsDerivedStyle = true;
            this.lblCalisanGorevleri.Location = new System.Drawing.Point(5, 87);
            this.lblCalisanGorevleri.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalisanGorevleri.Name = "lblCalisanGorevleri";
            this.lblCalisanGorevleri.Size = new System.Drawing.Size(75, 31);
            this.lblCalisanGorevleri.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCalisanGorevleri.StyleManager = null;
            this.lblCalisanGorevleri.TabIndex = 26;
            this.lblCalisanGorevleri.Text = "Görevler";
            this.lblCalisanGorevleri.ThemeAuthor = "Taiizor";
            this.lblCalisanGorevleri.ThemeName = "MetroLight";
            // 
            // lblCalisanSec
            // 
            this.lblCalisanSec.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblCalisanSec.IsDerivedStyle = true;
            this.lblCalisanSec.Location = new System.Drawing.Point(6, 24);
            this.lblCalisanSec.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCalisanSec.Name = "lblCalisanSec";
            this.lblCalisanSec.Size = new System.Drawing.Size(75, 31);
            this.lblCalisanSec.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblCalisanSec.StyleManager = null;
            this.lblCalisanSec.TabIndex = 25;
            this.lblCalisanSec.Text = "Çalışanlar";
            this.lblCalisanSec.ThemeAuthor = "Taiizor";
            this.lblCalisanSec.ThemeName = "MetroLight";
            // 
            // dgvCalisanGorevleri
            // 
            this.dgvCalisanGorevleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCalisanGorevleri.Location = new System.Drawing.Point(6, 121);
            this.dgvCalisanGorevleri.Name = "dgvCalisanGorevleri";
            this.dgvCalisanGorevleri.RowHeadersWidth = 51;
            this.dgvCalisanGorevleri.Size = new System.Drawing.Size(826, 328);
            this.dgvCalisanGorevleri.TabIndex = 1;
            // 
            // cbCalisanSec
            // 
            this.cbCalisanSec.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbCalisanSec.DisplayMember = "calisanadi";
            this.cbCalisanSec.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCalisanSec.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCalisanSec.EnabledCalc = true;
            this.cbCalisanSec.FormattingEnabled = true;
            this.cbCalisanSec.ItemHeight = 20;
            this.cbCalisanSec.Location = new System.Drawing.Point(102, 24);
            this.cbCalisanSec.Name = "cbCalisanSec";
            this.cbCalisanSec.Size = new System.Drawing.Size(219, 26);
            this.cbCalisanSec.TabIndex = 0;
            this.cbCalisanSec.ValueMember = "calisanid";
            this.cbCalisanSec.SelectedIndexChanged += new System.EventHandler(this.cbCalisanSec_SelectedIndexChanged);
            // 
            // tpGorevler
            // 
            this.tpGorevler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.tpGorevler.Controls.Add(this.tcGorevler);
            this.tpGorevler.Location = new System.Drawing.Point(4, 44);
            this.tpGorevler.Margin = new System.Windows.Forms.Padding(2);
            this.tpGorevler.Name = "tpGorevler";
            this.tpGorevler.Size = new System.Drawing.Size(1009, 489);
            this.tpGorevler.TabIndex = 3;
            this.tpGorevler.Text = "GÖREVLER";
            // 
            // tcGorevler
            // 
            this.tcGorevler.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tcGorevler.Controls.Add(this.tpGorevListesi);
            this.tcGorevler.Controls.Add(this.tpGorevEkle);
            this.tcGorevler.Controls.Add(this.tpKategoriler);
            this.tcGorevler.ItemSize = new System.Drawing.Size(30, 115);
            this.tcGorevler.Location = new System.Drawing.Point(5, 3);
            this.tcGorevler.Multiline = true;
            this.tcGorevler.Name = "tcGorevler";
            this.tcGorevler.SelectedIndex = 0;
            this.tcGorevler.ShowOuterBorders = false;
            this.tcGorevler.Size = new System.Drawing.Size(996, 463);
            this.tcGorevler.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tcGorevler.SquareColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(100)))));
            this.tcGorevler.TabIndex = 0;
            // 
            // tpKategoriler
            // 
            this.tpKategoriler.BackColor = System.Drawing.Color.White;
            this.tpKategoriler.Controls.Add(this.lblKategoriEkle);
            this.tpKategoriler.Controls.Add(this.btnKategoriEkle);
            this.tpKategoriler.Controls.Add(this.txtKategoriAdi);
            this.tpKategoriler.Controls.Add(this.lblKategoriler);
            this.tpKategoriler.Controls.Add(this.lstKategoriler);
            this.tpKategoriler.Location = new System.Drawing.Point(119, 4);
            this.tpKategoriler.Name = "tpKategoriler";
            this.tpKategoriler.Padding = new System.Windows.Forms.Padding(3);
            this.tpKategoriler.Size = new System.Drawing.Size(873, 455);
            this.tpKategoriler.TabIndex = 3;
            this.tpKategoriler.Text = "Kategoriler";
            // 
            // lblKategoriEkle
            // 
            this.lblKategoriEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriEkle.IsDerivedStyle = true;
            this.lblKategoriEkle.Location = new System.Drawing.Point(402, 52);
            this.lblKategoriEkle.Name = "lblKategoriEkle";
            this.lblKategoriEkle.Size = new System.Drawing.Size(321, 28);
            this.lblKategoriEkle.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblKategoriEkle.StyleManager = null;
            this.lblKategoriEkle.TabIndex = 9;
            this.lblKategoriEkle.Text = "KATEGORİ EKLE";
            this.lblKategoriEkle.ThemeAuthor = "Taiizor";
            this.lblKategoriEkle.ThemeName = "MetroLight";
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKategoriEkle.Customization = "7e3t//Ly8v/r6+v/5ubm/+vr6//f39//p6en/zw8PP8UFBT/gICA/w==";
            this.btnKategoriEkle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKategoriEkle.Image = null;
            this.btnKategoriEkle.Location = new System.Drawing.Point(403, 132);
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.NoRounding = false;
            this.btnKategoriEkle.Size = new System.Drawing.Size(320, 40);
            this.btnKategoriEkle.TabIndex = 8;
            this.btnKategoriEkle.Text = "EKLE";
            this.btnKategoriEkle.Transparent = false;
            this.btnKategoriEkle.Click += new System.EventHandler(this.btnKategoriEkle_Click);
            // 
            // txtKategoriAdi
            // 
            this.txtKategoriAdi.Location = new System.Drawing.Point(403, 92);
            this.txtKategoriAdi.Name = "txtKategoriAdi";
            this.txtKategoriAdi.Size = new System.Drawing.Size(320, 25);
            this.txtKategoriAdi.TabIndex = 7;
            // 
            // lblKategoriler
            // 
            this.lblKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKategoriler.IsDerivedStyle = true;
            this.lblKategoriler.Location = new System.Drawing.Point(48, 52);
            this.lblKategoriler.Name = "lblKategoriler";
            this.lblKategoriler.Size = new System.Drawing.Size(203, 37);
            this.lblKategoriler.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblKategoriler.StyleManager = null;
            this.lblKategoriler.TabIndex = 6;
            this.lblKategoriler.Text = "KATEGORİLER";
            this.lblKategoriler.ThemeAuthor = "Taiizor";
            this.lblKategoriler.ThemeName = "MetroLight";
            // 
            // lstKategoriler
            // 
            this.lstKategoriler.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lstKategoriler.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lstKategoriler.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lstKategoriler.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.lstKategoriler.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lstKategoriler.HoveredItemBackColor = System.Drawing.Color.LightGray;
            this.lstKategoriler.HoveredItemColor = System.Drawing.Color.DimGray;
            this.lstKategoriler.IsDerivedStyle = true;
            this.lstKategoriler.ItemHeight = 30;
            this.lstKategoriler.Location = new System.Drawing.Point(48, 92);
            this.lstKategoriler.MultiSelect = false;
            this.lstKategoriler.Name = "lstKategoriler";
            this.lstKategoriler.SelectedIndex = -1;
            this.lstKategoriler.SelectedItem = null;
            this.lstKategoriler.SelectedItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.lstKategoriler.SelectedItemColor = System.Drawing.Color.White;
            this.lstKategoriler.SelectedText = null;
            this.lstKategoriler.SelectedValue = null;
            this.lstKategoriler.ShowBorder = false;
            this.lstKategoriler.ShowScrollBar = false;
            this.lstKategoriler.Size = new System.Drawing.Size(203, 206);
            this.lstKategoriler.Style = ReaLTaiizor.Enum.Metro.Style.Custom;
            this.lstKategoriler.StyleManager = null;
            this.lstKategoriler.TabIndex = 5;
            this.lstKategoriler.ThemeAuthor = "Taiizor";
            this.lstKategoriler.ThemeName = "MetroDark";
            // 
            // tpGorevListesi
            // 
            this.tpGorevListesi.BackColor = System.Drawing.Color.White;
            this.tpGorevListesi.Controls.Add(this.dgvGorevler);
            this.tpGorevListesi.Location = new System.Drawing.Point(119, 4);
            this.tpGorevListesi.Name = "tpGorevListesi";
            this.tpGorevListesi.Padding = new System.Windows.Forms.Padding(3);
            this.tpGorevListesi.Size = new System.Drawing.Size(873, 455);
            this.tpGorevListesi.TabIndex = 0;
            this.tpGorevListesi.Text = "Görevler";
            // 
            // dgvGorevler
            // 
            this.dgvGorevler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGorevler.Location = new System.Drawing.Point(6, 6);
            this.dgvGorevler.Name = "dgvGorevler";
            this.dgvGorevler.Size = new System.Drawing.Size(864, 446);
            this.dgvGorevler.TabIndex = 0;
            // 
            // tpGorevEkle
            // 
            this.tpGorevEkle.BackColor = System.Drawing.Color.White;
            this.tpGorevEkle.Controls.Add(this.lblGorevProje);
            this.tpGorevEkle.Controls.Add(this.cbGorevProje);
            this.tpGorevEkle.Controls.Add(this.lblGorevKategori);
            this.tpGorevEkle.Controls.Add(this.cbGorevKategori);
            this.tpGorevEkle.Controls.Add(this.lblGorevAciklama);
            this.tpGorevEkle.Controls.Add(this.txtGorevAciklama);
            this.tpGorevEkle.Controls.Add(this.txtGorevMaliyet);
            this.tpGorevEkle.Controls.Add(this.cbGorevAtanan);
            this.tpGorevEkle.Controls.Add(this.cbGorevDurum);
            this.tpGorevEkle.Controls.Add(this.cbGorevOncelik);
            this.tpGorevEkle.Controls.Add(this.txtGorevBitisYazi);
            this.tpGorevEkle.Controls.Add(this.dtpGorevBitis);
            this.tpGorevEkle.Controls.Add(this.dtpGorevBaslangic);
            this.tpGorevEkle.Controls.Add(this.lblGorevMaliyet);
            this.tpGorevEkle.Controls.Add(this.btnGorevKaydet);
            this.tpGorevEkle.Controls.Add(this.lblGorevDurum);
            this.tpGorevEkle.Controls.Add(this.lblGorevOncelik);
            this.tpGorevEkle.Controls.Add(this.lblGorevBitis);
            this.tpGorevEkle.Controls.Add(this.lblGorevBaslangic);
            this.tpGorevEkle.Controls.Add(this.lblGorevAtanan);
            this.tpGorevEkle.Controls.Add(this.lblGorevAdi);
            this.tpGorevEkle.Controls.Add(this.txtGorevAdi);
            this.tpGorevEkle.Location = new System.Drawing.Point(119, 4);
            this.tpGorevEkle.Name = "tpGorevEkle";
            this.tpGorevEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tpGorevEkle.Size = new System.Drawing.Size(873, 455);
            this.tpGorevEkle.TabIndex = 2;
            this.tpGorevEkle.Text = "Görev Ekle";
                        // 
            // lblGorevProje
            // 
            this.lblGorevProje.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGorevProje.IsDerivedStyle = true;
            this.lblGorevProje.Location = new System.Drawing.Point(33, 18);
            this.lblGorevProje.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGorevProje.Name = "lblGorevProje";
            this.lblGorevProje.Size = new System.Drawing.Size(75, 31);
            this.lblGorevProje.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGorevProje.StyleManager = null;
            this.lblGorevProje.TabIndex = 43;
            this.lblGorevProje.Text = "Projeler";
            this.lblGorevProje.ThemeAuthor = "Taiizor";
            this.lblGorevProje.ThemeName = "MetroLight";
            // 
            // cbGorevProje
            // 
            this.cbGorevProje.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGorevProje.DisplayMember = "ProjeAdi";
            this.cbGorevProje.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGorevProje.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGorevProje.EnabledCalc = true;
            this.cbGorevProje.FormattingEnabled = true;
            this.cbGorevProje.ItemHeight = 20;
            this.cbGorevProje.Location = new System.Drawing.Point(194, 23);
            this.cbGorevProje.Margin = new System.Windows.Forms.Padding(2);
            this.cbGorevProje.Name = "cbGorevProje";
            this.cbGorevProje.Size = new System.Drawing.Size(643, 26);
            this.cbGorevProje.TabIndex = 42;
            this.cbGorevProje.ValueMember = "projeid";
            // 
            // lblGorevKategori
            // 
            this.lblGorevKategori.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGorevKategori.IsDerivedStyle = true;
            this.lblGorevKategori.Location = new System.Drawing.Point(481, 68);
            this.lblGorevKategori.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblGorevKategori.Name = "lblGorevKategori";
            this.lblGorevKategori.Size = new System.Drawing.Size(75, 14);
            this.lblGorevKategori.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGorevKategori.StyleManager = null;
            this.lblGorevKategori.TabIndex = 41;
            this.lblGorevKategori.Text = "Kategori";
            this.lblGorevKategori.ThemeAuthor = "Taiizor";
            this.lblGorevKategori.ThemeName = "MetroLight";
                        // 
            // cbGorevKategori
            // 
            this.cbGorevKategori.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGorevKategori.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGorevKategori.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGorevKategori.EnabledCalc = true;
            this.cbGorevKategori.FormattingEnabled = true;
            this.cbGorevKategori.ItemHeight = 20;
            this.cbGorevKategori.Location = new System.Drawing.Point(642, 64);
            this.cbGorevKategori.Margin = new System.Windows.Forms.Padding(2);
            this.cbGorevKategori.Name = "cbGorevKategori";
            this.cbGorevKategori.Size = new System.Drawing.Size(195, 26);
            this.cbGorevKategori.TabIndex = 40;
            // 
            // lblGorevAciklama
            // 
            this.lblGorevAciklama.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGorevAciklama.IsDerivedStyle = true;
            this.lblGorevAciklama.Location = new System.Drawing.Point(33, 276);
            this.lblGorevAciklama.Name = "lblGorevAciklama";
            this.lblGorevAciklama.Size = new System.Drawing.Size(125, 14);
            this.lblGorevAciklama.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGorevAciklama.StyleManager = null;
            this.lblGorevAciklama.TabIndex = 39;
            this.lblGorevAciklama.Text = "Görev Açıklama";
            this.lblGorevAciklama.ThemeAuthor = "Taiizor";
            this.lblGorevAciklama.ThemeName = "MetroLight";
            // 
            // txtGorevAciklama
            // 
            this.txtGorevAciklama.Location = new System.Drawing.Point(194, 276);
            this.txtGorevAciklama.Multiline = true;
            this.txtGorevAciklama.Name = "txtGorevAciklama";
            this.txtGorevAciklama.Size = new System.Drawing.Size(643, 81);
            this.txtGorevAciklama.TabIndex = 38;
            // 
            // txtGorevMaliyet
            // 
            this.txtGorevMaliyet.Location = new System.Drawing.Point(642, 225);
            this.txtGorevMaliyet.Name = "txtGorevMaliyet";
            this.txtGorevMaliyet.Size = new System.Drawing.Size(195, 25);
            this.txtGorevMaliyet.TabIndex = 37;
            this.txtGorevMaliyet.Text = "₺0,00";
            this.txtGorevMaliyet.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cbGorevAtanan
            // 
            this.cbGorevAtanan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGorevAtanan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGorevAtanan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGorevAtanan.EnabledCalc = true;
            this.cbGorevAtanan.FormattingEnabled = true;
            this.cbGorevAtanan.ItemHeight = 20;
            this.cbGorevAtanan.Location = new System.Drawing.Point(194, 118);
            this.cbGorevAtanan.Margin = new System.Windows.Forms.Padding(2);
            this.cbGorevAtanan.Name = "cbGorevAtanan";
            this.cbGorevAtanan.Size = new System.Drawing.Size(195, 26);
            this.cbGorevAtanan.TabIndex = 36;
            // 
            // cbGorevDurum
            // 
            this.cbGorevDurum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGorevDurum.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGorevDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGorevDurum.EnabledCalc = true;
            this.cbGorevDurum.FormattingEnabled = true;
            this.cbGorevDurum.ItemHeight = 20;
            this.cbGorevDurum.Location = new System.Drawing.Point(642, 167);
            this.cbGorevDurum.Margin = new System.Windows.Forms.Padding(2);
            this.cbGorevDurum.Name = "cbGorevDurum";
            this.cbGorevDurum.Size = new System.Drawing.Size(195, 26);
            this.cbGorevDurum.TabIndex = 31;
            // 
            // cbGorevOncelik
            // 
            this.cbGorevOncelik.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbGorevOncelik.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbGorevOncelik.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbGorevOncelik.EnabledCalc = true;
            this.cbGorevOncelik.FormattingEnabled = true;
            this.cbGorevOncelik.ItemHeight = 20;
            this.cbGorevOncelik.Location = new System.Drawing.Point(642, 115);
            this.cbGorevOncelik.Margin = new System.Windows.Forms.Padding(2);
            this.cbGorevOncelik.Name = "cbGorevOncelik";
            this.cbGorevOncelik.Size = new System.Drawing.Size(195, 26);
            this.cbGorevOncelik.TabIndex = 30;
            // 
            // txtGorevBitisYazi
            // 
            this.txtGorevBitisYazi.Location = new System.Drawing.Point(194, 216);
            this.txtGorevBitisYazi.Margin = new System.Windows.Forms.Padding(2);
            this.txtGorevBitisYazi.Name = "txtGorevBitisYazi";
            this.txtGorevBitisYazi.Size = new System.Drawing.Size(180, 25);
            this.txtGorevBitisYazi.TabIndex = 29;
            // 
            // dtpGorevBitis
            // 
            this.dtpGorevBitis.Location = new System.Drawing.Point(367, 216);
            this.dtpGorevBitis.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGorevBitis.Name = "dtpGorevBitis";
            this.dtpGorevBitis.Size = new System.Drawing.Size(22, 25);
            this.dtpGorevBitis.TabIndex = 28;
            this.dtpGorevBitis.ValueChanged += new System.EventHandler(this.dtpGorevBitis_ValueChanged);
            // 
            // dtpGorevBaslangic
            // 
            this.dtpGorevBaslangic.Location = new System.Drawing.Point(194, 168);
            this.dtpGorevBaslangic.Margin = new System.Windows.Forms.Padding(2);
            this.dtpGorevBaslangic.Name = "dtpGorevBaslangic";
            this.dtpGorevBaslangic.Size = new System.Drawing.Size(195, 25);
            this.dtpGorevBaslangic.TabIndex = 27;
            // 
            // lblGorevMaliyet
            // 
            this.lblGorevMaliyet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGorevMaliyet.IsDerivedStyle = true;
            this.lblGorevMaliyet.Location = new System.Drawing.Point(481, 222);
            this.lblGorevMaliyet.Name = "lblGorevMaliyet";
            this.lblGorevMaliyet.Size = new System.Drawing.Size(100, 14);
            this.lblGorevMaliyet.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGorevMaliyet.StyleManager = null;
            this.lblGorevMaliyet.TabIndex = 26;
            this.lblGorevMaliyet.Text = "Maliyet";
            this.lblGorevMaliyet.ThemeAuthor = "Taiizor";
            this.lblGorevMaliyet.ThemeName = "MetroLight";
            // 
            // btnGorevKaydet
            // 
            this.btnGorevKaydet.BackColor = System.Drawing.Color.Transparent;
            this.btnGorevKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGorevKaydet.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnGorevKaydet.Location = new System.Drawing.Point(33, 376);
            this.btnGorevKaydet.Name = "btnGorevKaydet";
            this.btnGorevKaydet.Size = new System.Drawing.Size(804, 53);
            this.btnGorevKaydet.TabIndex = 24;
            this.btnGorevKaydet.Text = "KAYDET";
            this.btnGorevKaydet.Click += new System.EventHandler(this.btnGorevKaydet_Click);
            // 
            // lblGorevDurum
            // 
            this.lblGorevDurum.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGorevDurum.IsDerivedStyle = true;
            this.lblGorevDurum.Location = new System.Drawing.Point(481, 167);
            this.lblGorevDurum.Name = "lblGorevDurum";
            this.lblGorevDurum.Size = new System.Drawing.Size(100, 14);
            this.lblGorevDurum.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGorevDurum.StyleManager = null;
            this.lblGorevDurum.TabIndex = 18;
            this.lblGorevDurum.Text = "Durum";
            this.lblGorevDurum.ThemeAuthor = "Taiizor";
            this.lblGorevDurum.ThemeName = "MetroLight";
            // 
            // lblGorevOncelik
            // 
            this.lblGorevOncelik.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGorevOncelik.IsDerivedStyle = true;
            this.lblGorevOncelik.Location = new System.Drawing.Point(481, 118);
            this.lblGorevOncelik.Name = "lblGorevOncelik";
            this.lblGorevOncelik.Size = new System.Drawing.Size(100, 14);
            this.lblGorevOncelik.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGorevOncelik.StyleManager = null;
            this.lblGorevOncelik.TabIndex = 17;
            this.lblGorevOncelik.Text = "Öncelik";
            this.lblGorevOncelik.ThemeAuthor = "Taiizor";
            this.lblGorevOncelik.ThemeName = "MetroLight";
            // 
            // lblGorevBitis
            // 
            this.lblGorevBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGorevBitis.IsDerivedStyle = true;
            this.lblGorevBitis.Location = new System.Drawing.Point(33, 224);
            this.lblGorevBitis.Name = "lblGorevBitis";
            this.lblGorevBitis.Size = new System.Drawing.Size(100, 14);
            this.lblGorevBitis.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGorevBitis.StyleManager = null;
            this.lblGorevBitis.TabIndex = 16;
            this.lblGorevBitis.Text = "Bitiş Tarihi";
            this.lblGorevBitis.ThemeAuthor = "Taiizor";
            this.lblGorevBitis.ThemeName = "MetroLight";
            // 
            // lblGorevBaslangic
            // 
            this.lblGorevBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGorevBaslangic.IsDerivedStyle = true;
            this.lblGorevBaslangic.Location = new System.Drawing.Point(33, 168);
            this.lblGorevBaslangic.Name = "lblGorevBaslangic";
            this.lblGorevBaslangic.Size = new System.Drawing.Size(125, 14);
            this.lblGorevBaslangic.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGorevBaslangic.StyleManager = null;
            this.lblGorevBaslangic.TabIndex = 15;
            this.lblGorevBaslangic.Text = "Başlangıç Tarihi";
            this.lblGorevBaslangic.ThemeAuthor = "Taiizor";
            this.lblGorevBaslangic.ThemeName = "MetroLight";
            // 
            // lblGorevAtanan
            // 
            this.lblGorevAtanan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGorevAtanan.IsDerivedStyle = true;
            this.lblGorevAtanan.Location = new System.Drawing.Point(33, 118);
            this.lblGorevAtanan.Name = "lblGorevAtanan";
            this.lblGorevAtanan.Size = new System.Drawing.Size(100, 14);
            this.lblGorevAtanan.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGorevAtanan.StyleManager = null;
            this.lblGorevAtanan.TabIndex = 14;
            this.lblGorevAtanan.Text = "Görev Atanan";
            this.lblGorevAtanan.ThemeAuthor = "Taiizor";
            this.lblGorevAtanan.ThemeName = "MetroLight";
            // 
            // lblGorevAdi
            // 
            this.lblGorevAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblGorevAdi.IsDerivedStyle = true;
            this.lblGorevAdi.Location = new System.Drawing.Point(33, 64);
            this.lblGorevAdi.Name = "lblGorevAdi";
            this.lblGorevAdi.Size = new System.Drawing.Size(100, 14);
            this.lblGorevAdi.Style = ReaLTaiizor.Enum.Metro.Style.Light;
            this.lblGorevAdi.StyleManager = null;
            this.lblGorevAdi.TabIndex = 13;
            this.lblGorevAdi.Text = "Görev Adı";
            this.lblGorevAdi.ThemeAuthor = "Taiizor";
            this.lblGorevAdi.ThemeName = "MetroLight";
            // 
            // txtGorevAdi
            // 
            this.txtGorevAdi.Location = new System.Drawing.Point(194, 64);
            this.txtGorevAdi.Name = "txtGorevAdi";
            this.txtGorevAdi.Size = new System.Drawing.Size(195, 25);
            this.txtGorevAdi.TabIndex = 12;
            // 
            // tmrSaat
            // 
            this.tmrSaat.Enabled = true;
            this.tmrSaat.Interval = 1000;
            this.tmrSaat.Tick += new System.EventHandler(this.tmrSaat_Tick);
            // 
            // lblSaat
            // 
            this.lblSaat.BackColor = System.Drawing.Color.Transparent;
            this.lblSaat.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblSaat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblSaat.Location = new System.Drawing.Point(900, 62);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(96, 16);
            this.lblSaat.TabIndex = 1;
            this.lblSaat.Text = "lblSaat";
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 565);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.tcAna);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnaForm";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proje Yönetimi";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            this.tcAna.ResumeLayout(false);
            this.tpAnasayfa.ResumeLayout(false);
            this.tpAnasayfa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartButce)).EndInit();
            this.tpProjeler.ResumeLayout(false);
            this.tcProjeler.ResumeLayout(false);
            this.tpProjeListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeler)).EndInit();
            this.tpProjeEkle.ResumeLayout(false);
            this.pnlProjeEkle.ResumeLayout(false);
            this.pnlProjeEkle.PerformLayout();
            this.tpGuncelProjeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGuncelProjeler)).EndInit();
            this.tpYeniProjeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvYeniProjeler)).EndInit();
            this.tpTamamlananProjeler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTamamlananProjeler)).EndInit();
            this.tpProjeGuncelle.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeGuncelle)).EndInit();
            this.tpProjeGorevleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjeGorevleri)).EndInit();
            this.tpCalisanlar.ResumeLayout(false);
            this.tcCalisanlar.ResumeLayout(false);
            this.tpCalisanListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanlar)).EndInit();
            this.tpCalisanEkle.ResumeLayout(false);
            this.tpCalisanEkle.PerformLayout();
            this.tpCalisanGuncelle.ResumeLayout(false);
            this.tpCalisanGuncelle.PerformLayout();
            this.tpCalisanGorevleri.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCalisanGorevleri)).EndInit();
            this.tpGorevler.ResumeLayout(false);
            this.tcGorevler.ResumeLayout(false);
            this.tpKategoriler.ResumeLayout(false);
            this.tpKategoriler.PerformLayout();
            this.tpGorevListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGorevler)).EndInit();
            this.tpGorevEkle.ResumeLayout(false);
            this.tpGorevEkle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Controls.ForeverTabPage tcAna;
        private System.Windows.Forms.TabPage tpAnasayfa;
        private System.Windows.Forms.TabPage tpProjeler;
        private System.Windows.Forms.TabPage tpCalisanlar;
        private System.Windows.Forms.TabPage tpGorevler;
        private ReaLTaiizor.Controls.HopeDatePicker takvim;
        private ReaLTaiizor.Controls.AirTabPage tcCalisanlar;
        private System.Windows.Forms.TabPage tpCalisanEkle;
        private System.Windows.Forms.TabPage tpCalisanGuncelle;
        private System.Windows.Forms.TabPage tpCalisanGorevleri;
        private System.Windows.Forms.TabPage tpCalisanListesi;
        private System.Windows.Forms.DataGridView dgvCalisanlar;
        private ReaLTaiizor.Controls.ThunderButton btnCalisanKaydet;
        private System.Windows.Forms.TextBox txtCeposta;
        private System.Windows.Forms.TextBox txtCtel;
        private System.Windows.Forms.TextBox txtCsoyadi;
        private ReaLTaiizor.Controls.MetroLabel lblCalisanUnvan;
        private ReaLTaiizor.Controls.MetroLabel lblCalisanTel;
        private ReaLTaiizor.Controls.MetroLabel lblCalisanEposta;
        private ReaLTaiizor.Controls.MetroLabel lblCalisanSoyadi;
        private ReaLTaiizor.Controls.MetroLabel lblCalisanAdi;
        private System.Windows.Forms.TextBox txtCadi;
        private ReaLTaiizor.Controls.ThunderButton btnCalisanGuncelle;
        private System.Windows.Forms.TextBox txtGuncelEposta;
        private System.Windows.Forms.TextBox txtGuncelTel;
        private System.Windows.Forms.TextBox txtGuncelSoyadi;
        private ReaLTaiizor.Controls.MetroLabel lblGuncelUnvan;
        private ReaLTaiizor.Controls.MetroLabel lblGuncelTel;
        private ReaLTaiizor.Controls.MetroLabel lblGuncelEposta;
        private ReaLTaiizor.Controls.MetroLabel lblGuncelSoyadi;
        private ReaLTaiizor.Controls.MetroLabel lblGuncelAdi;
        private System.Windows.Forms.TextBox txtGuncelAdi;
        private ReaLTaiizor.Controls.MetroLabel lblGuncellenecekCalisan;
        private ReaLTaiizor.Controls.AloneComboBox cbGuncellenecekCalisan;
        private ReaLTaiizor.Controls.AirTabPage tcProjeler;
        private System.Windows.Forms.TabPage tpProjeListesi;
        private System.Windows.Forms.DataGridView dgvProjeler;
        private System.Windows.Forms.TabPage tpProjeEkle;
        private ReaLTaiizor.Controls.Panel pnlProjeEkle;
        private ReaLTaiizor.Controls.ThunderButton btnProjeKaydet;
        private ReaLTaiizor.Controls.MetroLabel lblButce;
        private ReaLTaiizor.Controls.MetroLabel lblProjeBitis;
        private ReaLTaiizor.Controls.MetroLabel lblProjeBaslangic;
        private ReaLTaiizor.Controls.MetroLabel lblProjeDurum;
        private ReaLTaiizor.Controls.MetroLabel lblProjeOncelik;
        private ReaLTaiizor.Controls.MetroLabel lblSahip;
        private ReaLTaiizor.Controls.MetroLabel lblProjeAdi;
        private System.Windows.Forms.TextBox txtProjeAdi;
        private System.Windows.Forms.TextBox txtProjeBitisYazi;
        private System.Windows.Forms.DateTimePicker dtpProjeBitis;
        private System.Windows.Forms.TextBox txtButce;
        private System.Windows.Forms.DateTimePicker dtpProjeBaslangic;
        private ReaLTaiizor.Controls.AloneComboBox cbProjeOncelik;
        private ReaLTaiizor.Controls.AloneComboBox cbProjeDurum;
        private System.Windows.Forms.TabPage tpGuncelProjeler;
        private System.Windows.Forms.DataGridView dgvGuncelProjeler;
        private System.Windows.Forms.TabPage tpYeniProjeler;
        private System.Windows.Forms.DataGridView dgvYeniProjeler;
        private System.Windows.Forms.TabPage tpTamamlananProjeler;
        private System.Windows.Forms.DataGridView dgvTamamlananProjeler;
        private System.Windows.Forms.TabPage tpProjeGuncelle;
        private System.Windows.Forms.TabPage tpProjeGorevleri;
        private ReaLTaiizor.Controls.MetroLabel lblProjeGorevleri;
        private ReaLTaiizor.Controls.MetroLabel lblProjeSec;
        private ReaLTaiizor.Controls.AloneComboBox cbProjeSec;
        private ReaLTaiizor.Controls.AirButton btnProjeGuncelle;
        private System.Windows.Forms.DataGridView dgvProjeGuncelle;
        private System.Windows.Forms.Timer tmrSaat;
        private ReaLTaiizor.Controls.ThunderLabel lblSaat;
        private System.Windows.Forms.DataGridView dgvProjeGorevleri;
        private ReaLTaiizor.Controls.MetroLabel lblCalisanGorevleri;
        private ReaLTaiizor.Controls.MetroLabel lblCalisanSec;
        private System.Windows.Forms.DataGridView dgvCalisanGorevleri;
        private ReaLTaiizor.Controls.AloneComboBox cbCalisanSec;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartButce;
        private ReaLTaiizor.Controls.AirTabPage tcGorevler;
        private System.Windows.Forms.TabPage tpGorevListesi;
        private System.Windows.Forms.DataGridView dgvGorevler;
        private System.Windows.Forms.TabPage tpGorevEkle;
        private ReaLTaiizor.Controls.AloneComboBox cbGorevDurum;
        private ReaLTaiizor.Controls.AloneComboBox cbGorevOncelik;
        private System.Windows.Forms.TextBox txtGorevBitisYazi;
        private System.Windows.Forms.DateTimePicker dtpGorevBitis;
        private System.Windows.Forms.DateTimePicker dtpGorevBaslangic;
        private ReaLTaiizor.Controls.MetroLabel lblGorevMaliyet;
        private ReaLTaiizor.Controls.ThunderButton btnGorevKaydet;
        private ReaLTaiizor.Controls.MetroLabel lblGorevDurum;
        private ReaLTaiizor.Controls.MetroLabel lblGorevOncelik;
        private ReaLTaiizor.Controls.MetroLabel lblGorevBitis;
        private ReaLTaiizor.Controls.MetroLabel lblGorevBaslangic;
        private ReaLTaiizor.Controls.MetroLabel lblGorevAtanan;
        private ReaLTaiizor.Controls.MetroLabel lblGorevAdi;
        private System.Windows.Forms.TextBox txtGorevAdi;
        private ReaLTaiizor.Controls.AloneComboBox cbGorevAtanan;
        private System.Windows.Forms.TextBox txtGorevMaliyet;
        private ReaLTaiizor.Controls.MetroLabel lblGorevAciklama;
        private System.Windows.Forms.TextBox txtGorevAciklama;
        private System.Windows.Forms.TextBox txtSahip;
        private System.Windows.Forms.TabPage tpKategoriler;
        private ReaLTaiizor.Controls.MetroLabel lblKategoriEkle;
        private ReaLTaiizor.Controls.AirButton btnKategoriEkle;
        private System.Windows.Forms.TextBox txtKategoriAdi;
        private ReaLTaiizor.Controls.MetroLabel lblKategoriler;
        private ReaLTaiizor.Controls.MetroListBox lstKategoriler;
        private ReaLTaiizor.Controls.AloneComboBox cbCalisanUnvan;
        private ReaLTaiizor.Controls.MetroLabel lblGorevKategori;
        private ReaLTaiizor.Controls.AloneComboBox cbGorevKategori;
        private ReaLTaiizor.Controls.AloneComboBox cbGuncelTecrube;
        private ReaLTaiizor.Controls.MetroLabel lblGuncelTecrube;
        private ReaLTaiizor.Controls.AloneComboBox cbGuncelUnvan;
        private ReaLTaiizor.Controls.AloneComboBox cbCalisanTecrube;
        private ReaLTaiizor.Controls.MetroLabel lblCalisanTecrube;
        private ReaLTaiizor.Controls.MetroLabel lblGorevProje;
        private ReaLTaiizor.Controls.AloneComboBox cbGorevProje;
        private System.Windows.Forms.Label lblOzet;
        private System.Windows.Forms.Label lblHosgeldin;
    }

    
}