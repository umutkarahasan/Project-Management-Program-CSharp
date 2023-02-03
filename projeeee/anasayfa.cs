using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Forms;
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using System.Data.Sql;
using System.Data.SqlTypes;



namespace projeeee
{
    public partial class anasayfa : MaterialForm
    {
        public anasayfa()
        {
            InitializeComponent();

            projeget();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-US47PBB\SQLEXPRESS; initial catalog=Proje Yönetimi; integrated security=true");
        private void anasayfa_Load(object sender, EventArgs e)
        {

            Projecekme();
            Kategoricekme();
            Oncelikcekme();
            gorevOncelikcekme();
            durumcekme();
            gorevdurumcekme();
            calisandansahipcekme();
            guncelprojecekme();
            yeniprojecekme();
            tamamlanmışprojecekme();
            pprojegetirr();
            kategorigetir();
            listele();
            calisangetir();
            cbcalisangetir();
            grafik();
            calisancbgetirr();
            unvanguncellegetir();
            unvangetir();
            gorevcekme();
            tecrubegetir();
            tecrubeguncellegetir();
            atanancbcekme();
        }



        void grafik()
        {
            SqlConnection bag = new SqlConnection("Data Source=DESKTOP-US47PBB\\SQLEXPRESS;Initial Catalog=Proje Yönetimi;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            SqlDataAdapter da = new SqlDataAdapter("select projeadi  , Butce  from proje", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            chart1.DataSource = dt;

            chart1.Series[0].XValueMember = "projeadi";
            chart1.Series[0].YValueMembers = "Butce";
            chart1.DataBind();
            chart1.Series[0].ChartType = SeriesChartType.Pie;

            bag.Close();
        }



        // tabpage tıklandığında olacak olanlar
        private void airTabPage2_Click(object sender, EventArgs e)
        {
            Projecekme();
            guncelprojecekme();
            yeniprojecekme();
            tamamlanmışprojecekme();


        }
        // tabpage tıklandığında olacak olanlar

        private void foreverTabPage1_Click(object sender, EventArgs e)
        {
            Projecekme();
            guncelprojecekme();
            yeniprojecekme();
            tamamlanmışprojecekme();


        }



        // bütün sayfalarda sol üstteki saat
        private void timer1_Tick(object sender, EventArgs e)
        {
            thunderLabel1.Text = DateTime.Now.ToLongTimeString();
        }

        //-------------------------------------------------------GÖREV SAYFASI-------------------------------------------------------------------------

         //kategori tablosundan kategori sayfasındaki listboxa verileri çekme
        private void kategorigetir()
        {
            bag.Open();
            SqlCommand abc = new SqlCommand("SELECT * FROM kategori", bag);
            SqlDataReader atr;


            atr = abc.ExecuteReader();
            while (atr.Read())
            {
                metroListBox2.Items.Add(atr["kategori_adi"]);
            }
            bag.Close();
        }


        //kategori tablosundan proje ekle sayfasındaki kategori adlı comboboxa veri çekme

        private void Kategoricekme()
        {

            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM kategori", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);

            aloneComboBox2.DataSource = dt;
            aloneComboBox2.ValueMember = "kategori_id";
            aloneComboBox2.DisplayMember = "kategori_adi";


        } 
        private void pprojegetirr()
        {
            SqlDataAdapter umutkarahasan = new SqlDataAdapter("select * from proje", bag);
            DataTable osmanak = new DataTable();
            umutkarahasan.Fill(osmanak);
            aloneComboBox4.DataSource = osmanak;

            aloneComboBox4.ValueMember = "projeid";
            aloneComboBox4.DisplayMember = "ProjeAdi";

        }

        private void gorevcekme()
        {
            
            SqlDataAdapter da = new SqlDataAdapter("select a.gorevadi,c.calisanadi,a.gbaslangic,a.gbitis,o.oncelik,d.durum,a.gmaaliyet " +
                "from gorev a,calisan c,oncelik o,durum d " +
                "where (a.calisanid=c.calisanid) and (a.durum_id=d.durum_id) and (o.oncelik_id=a.oncelik_id) ", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgwGrev.DataSource = dt;
            dgwGrev.Columns["gorevadi"].HeaderText = "Görev Adı";
            dgwGrev.Columns["calisanadi"].HeaderText = "Atanan";
            dgwGrev.Columns["gbaslangic"].HeaderText = "Başlangıç Tarihi";
            dgwGrev.Columns["gbitis"].HeaderText = "Bitiş Tarihi";
            dgwGrev.Columns["oncelik"].HeaderText = "Öncelik ";
            dgwGrev.Columns["durum"].HeaderText = "Durum";
            dgwGrev.Columns["gmaaliyet"].HeaderText = "Maaliyet";


            this.dgwGrev.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }



        private void thunderButton2_Click_1(object sender, EventArgs e)
        {
            bag.Open();
            string sql = "insert into gorev (projeid,kategori_id,gorevadi,calisanid,gbaslangic,gbitis,oncelik_id,durum_id,gmaaliyet,grvaciklama) values  (@projeid,@kategori,@gorevadi,@calisanid,@grvbaslangic,@grvsontarih,@grvoncelik,@grvdurum,@grvmaaliyet,@grvaciklama)";
            SqlCommand cmd = new SqlCommand(sql, bag);
            cmd.Parameters.AddWithValue("@projeid", aloneComboBox4.SelectedValue);
            cmd.Parameters.AddWithValue("@kategori", aloneComboBox2.SelectedValue);
            cmd.Parameters.AddWithValue("@gorevadi", txtGadi.Text);
            cmd.Parameters.AddWithValue("@calisanid", cbatanan.SelectedValue);
            cmd.Parameters.AddWithValue("@grvbaslangic", dtgbas.Value);
            cmd.Parameters.AddWithValue("@grvsontarih", dateTimePicker1.Value);
            cmd.Parameters.AddWithValue("@grvoncelik", cmbGoncelik.SelectedValue);
            cmd.Parameters.AddWithValue("@grvdurum", cmbGdurum.SelectedValue);
            cmd.Parameters.AddWithValue("@grvmaaliyet", txtMaaliyet.Text);
            cmd.Parameters.AddWithValue("@grvaciklama", txtAciklama.Text);

            cmd.ExecuteNonQuery();
            bag.Close();
            txtGadi.Clear();
            txtAciklama.Clear();
            txtGbitis.Clear();
            txtMaaliyet.Text = "";
            gorevcekme();


        }
        // kategori sayfasındaki girilen kategoriyi veritabanına ekleme
        private void airButton3_Click(object sender, EventArgs e)
        {
            bag.Open();
            SqlCommand cmd = new SqlCommand("insert into Kategori (kategori_adi) values (@prm1)", bag);
            cmd.Parameters.AddWithValue("@prm1", textBox2.Text);
            cmd.ExecuteNonQuery();
            bag.Close();
            metroListBox2.Clear();
            textBox2.Clear();
            kategorigetir();
            Kategoricekme();
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtGbitis.Text = dateTimePicker1.Value.Date.ToString(" d  MMMM  yyyy    dddd");
        }

        private void atanancbcekme()
        {
            SqlDataAdapter ad = new SqlDataAdapter("select * from calisan", bag);
            DataTable acx = new DataTable();
            ad.Fill(acx);

            cbatanan.DataSource = acx;
            cbatanan.DisplayMember = "calisanadi";
            cbatanan.ValueMember = "calisanid";
        }
        private void guncelprojecekme()
        {
            bag.Open();
            SqlDataAdapter da2 = new SqlDataAdapter("select p.ProjeAdi,p.Sahip,o.oncelik,d.durum,p.pbaslangic,p.pbitis,p.butce " +
                "from proje p, oncelik o ,durum d " +
                "where  (o.oncelik_id=p.oncelik_id) and (d.durum_id=p.durum_id) and durum='Güncel'", bag);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            dataGridView3.DataSource = dt2;
            bag.Close();
            this.dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void gorevdurumcekme()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM durum", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbGdurum.DataSource = dt;
            cmbGdurum.ValueMember = "durum_id";
            cmbGdurum.DisplayMember = "durum";
        }
        private void gorevOncelikcekme()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM oncelik", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmbGoncelik.DataSource = dt;
            cmbGoncelik.ValueMember = "oncelik_id";
            cmbGoncelik.DisplayMember = "oncelik";
        }


        //-------------------------------------------------------ÇALIŞAN SAYFASI-------------------------------------------------------------------------
        private void calisancbgetirr()
        {
            SqlDataAdapter calisancbgetir = new SqlDataAdapter("select * from calisan", bag);
            DataTable dtcalisancbget = new DataTable();
            calisancbgetir.Fill(dtcalisancbget);
            calisancbget.DataSource = dtcalisancbget;
            calisancbget.ValueMember = "calisanid";
            calisancbget.DisplayMember = "calisanadi";
        }

        private void unvanguncellegetir()
        {
            SqlDataAdapter projeget = new SqlDataAdapter("select * from unvan", bag);
            DataTable dtprojeget = new DataTable();
            projeget.Fill(dtprojeget);
            unvancb.DataSource = dtprojeget;
            unvancb.ValueMember = "unvan_id";
            unvancb.DisplayMember = "unvan_adi";
        }
        private void tecrubegetir()
        {
            SqlDataAdapter tecrube = new SqlDataAdapter("Select * from tecrube", bag);
            DataTable dttecrube = new DataTable();
            tecrube.Fill(dttecrube);
            aloneComboBox3.DataSource = dttecrube;
            aloneComboBox3.DisplayMember = "tecrube";
            aloneComboBox3.ValueMember = "tecrube_id";
        }
        private void tecrubeguncellegetir()
        {
            SqlDataAdapter tecrubegun = new SqlDataAdapter("Select * from tecrube", bag);
            DataTable dttecrubegun = new DataTable();
            tecrubegun.Fill(dttecrubegun);
            tecrubecb.DataSource = dttecrubegun;
            tecrubecb.DisplayMember = "tecrube";
            tecrubecb.ValueMember = "tecrube_id";
        }

        private void aloneComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbProjelerget.ValueMember = "calisanid";
            //cbProjelerget.DisplayMember = "calisanadi";

            bag.Open();
            SqlDataAdapter abc = new SqlDataAdapter("select c.calisanadi,c.calisansoyadi,g.gorevadi,g.gbaslangic,g.gbitis,o.oncelik,d.durum,g.gmaaliyet " +
                "from gorev g,calisan c,durum d,oncelik o " +
                "where(g.calisanid=c.calisanid) and (g.oncelik_id=o.oncelik_id) and (d.durum_id=g.durum_id) and c.calisanid=@prm1", bag);
            abc.SelectCommand.Parameters.AddWithValue("@prm1", calisancbget.SelectedValue);
            DataTable sj = new DataTable();
            abc.Fill(sj);
            dataGridView7.DataSource = sj;
            dataGridView7.Columns["calisanadi"].HeaderText = "Çalışan Adı";
            dataGridView7.Columns["calisansoyadi"].HeaderText = "Çalışan Soyadı";
            dataGridView7.Columns["gorevadi"].HeaderText = "Görev Adı";
            dataGridView7.Columns["gbaslangic"].HeaderText = "Başlama";
            dataGridView7.Columns["gbitis"].HeaderText = "Bitiş";
            dataGridView7.Columns["oncelik"].HeaderText = "Öncelik";
            dataGridView7.Columns["durum"].HeaderText = "Durum";
            dataGridView7.Columns["gmaaliyet"].HeaderText = "Maaliyet";

            this.dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            bag.Close();
        }

        //textboxlardaki girilen verileri veritabanına aktarma
        private void thunderButton1_Click(object sender, EventArgs e)
        {
            bag.Open();
            string sql = "update calisan set calisanadi=@calisanadi,calisansoyadi=@calisansoyadi,calisaneposta=@calisaneposta,calisantel=@calisantel,unvan_id=@unvan,tecrube_id=@tecrube where calisanid='" + cbCalisan.SelectedValue + "'";
            SqlCommand cmd = new SqlCommand(sql, bag);

            cmd.Parameters.AddWithValue("@calisanadi", txt1.Text);
            cmd.Parameters.AddWithValue("@calisansoyadi", txt2.Text);
            cmd.Parameters.AddWithValue("@calisaneposta", txt3.Text);
            cmd.Parameters.AddWithValue("@calisantel", txt4.Text);
            cmd.Parameters.AddWithValue("@unvan", unvancb.SelectedValue);
            cmd.Parameters.AddWithValue("@tecrube", tecrubecb.SelectedValue);


            cmd.ExecuteNonQuery();
            bag.Close();
            calisangetir();
            cbcalisangetir();
            txt1.Text = " ";
            txt2.Text = " ";
            txt3.Text = " ";
            txt4.Text = " ";

        }

        //comboboxta seçili değere göre textboxlara verileri getirme
        private void cbCalisan_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbCalisan.DisplayMember = "calisanadi";
            cbCalisan.ValueMember = "calisanid";
            bag.Open();

            SqlDataAdapter da = new SqlDataAdapter("select * from calisan where calisanid=@prm1", bag);
            da.SelectCommand.Parameters.AddWithValue("@prm1", cbCalisan.SelectedValue);

            DataTable dt = new DataTable();
            da.Fill(dt);
            txt1.Text = dt.Rows[0][1].ToString();
            txt2.Text = dt.Rows[0][2].ToString();
            txt3.Text = dt.Rows[0][3].ToString();
            txt4.Text = dt.Rows[0][4].ToString();
            txt5.Text = dt.Rows[0][5].ToString();





            bag.Close();
        }

        //comboboxa calisanların isimlerini getirme
        private void cbcalisangetir()
        {
            SqlDataAdapter cbcalisanget = new SqlDataAdapter("select * from calisan", bag);
            DataTable dtcalisanget = new DataTable();
            cbcalisanget.Fill(dtcalisanget);
            cbCalisan.DataSource = dtcalisanget;
            cbCalisan.ValueMember = "calisanid";
            cbCalisan.DisplayMember = "calisanadi";
        }

        //calisan ekleme

        private void btnGkaydet_Click(object sender, EventArgs e)
        {
            calisanekleme();
            calisangetir();
            cbcalisangetir();
            atanancbcekme();

            txtCadi.Clear();
            txtCsoyadi.Clear();
            txtCeposta.Clear();
            txtCtel.Clear();


        }
        private void unvangetir()
        {
            SqlDataAdapter projeget = new SqlDataAdapter("select * from unvan", bag);
            DataTable dtprojeget = new DataTable();
            projeget.Fill(dtprojeget);
            aloneComboBox1.DataSource = dtprojeget;
            aloneComboBox1.ValueMember = "unvan_id";
            aloneComboBox1.DisplayMember = "unvan_adi";
        }

        private void calisanekleme()
        {
            bag.Open();
            SqlCommand cmd = new SqlCommand("insert into calisan (calisanadi,calisansoyadi,calisaneposta,calisantel,unvan_id,tecrube_id) values " +
                "(@calisanadi,@calisansoyadi,@calisaneposta,@calisantel,@isunvani,@tecrube) ", bag);
            cmd.Parameters.AddWithValue("@calisanadi", txtCadi.Text);
            cmd.Parameters.AddWithValue("@calisansoyadi", txtCsoyadi.Text);
            cmd.Parameters.AddWithValue("@calisaneposta", txtCeposta.Text);
            cmd.Parameters.AddWithValue("@calisantel", txtCtel.Text);
            cmd.Parameters.AddWithValue("@isunvani", aloneComboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@tecrube", aloneComboBox3.SelectedValue);

            cmd.ExecuteNonQuery();

            bag.Close();
        }

        //calisanlari datagride listeleme
        private void calisangetir()
        {
            bag.Open();
            SqlDataAdapter da = new SqlDataAdapter("select c.calisanadi,c.calisansoyadi,c.calisaneposta,c.calisantel,t.tecrube,u.unvan_adi " +
                "from calisan c ,unvan u, tecrube t " +
                "where(c.tecrube_id = t.tecrube_id) and(u.unvan_id = c.unvan_id)", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.Columns["calisanadi"].HeaderText = " Adı";
            dataGridView1.Columns["calisansoyadi"].HeaderText = "Soyadı";
            dataGridView1.Columns["calisaneposta"].HeaderText = "E-Posta";
            dataGridView1.Columns["calisantel"].HeaderText = "Telefon";
            dataGridView1.Columns["tecrube"].HeaderText = "İş Deneyimi";
            dataGridView1.Columns["unvan_adi"].HeaderText = "Unvanı";

            bag.Close();

            this.dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }



        //-------------------------------------------------------PROJELER SAYFASI-------------------------------------------------------------------------


        //tamamlanmış projeleri datagridde gösterme

        private void tamamlanmışprojecekme()
        {
            bag.Open();
            SqlDataAdapter da = new SqlDataAdapter("select p.ProjeAdi,p.Sahip,o.oncelik,d.durum,p.pbaslangic,p.pbitis,p.butce " +
                "from proje p,oncelik o ,durum d " +
                "where  (o.oncelik_id=p.oncelik_id) and (d.durum_id=p.durum_id) and durum= 'Tamamlanmış' ", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView5.DataSource = dt;
            bag.Close();
        }
        //yeni projeleri datagridde gösterme
        private void yeniprojecekme()
        {
            bag.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("select p.ProjeAdi,p.Sahip,o.oncelik,d.durum,p.pbaslangic,p.pbitis,p.butce " +
                "from proje p, oncelik o ,durum d " +
                "where  (o.oncelik_id=p.oncelik_id) and (d.durum_id=p.durum_id) and durum = 'Yeni' ", bag);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            dataGridView4.DataSource = dt1;
            bag.Close();
            this.dataGridView4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        // güncel projeleri datagridde gösterme
     
        // comboboxa proje isimlerini getirme
        private void projeget()
        {
            SqlDataAdapter projeget = new SqlDataAdapter("select * from Proje", bag);
            DataTable dtprojeget = new DataTable();
            projeget.Fill(dtprojeget);
            cbProjelerget.DataSource = dtprojeget;
            cbProjelerget.ValueMember = "projeid";
            cbProjelerget.DisplayMember = "ProjeAdi";
        }
        //çalışanlar tablosundan proje ekle sayfasındaki sahip adlı comboboxa veri çekme
        private void calisandansahipcekme()
        {


        }
      
        //proje ekleme sayfasında oncelik comboboxuna verileri getirme
        private void Oncelikcekme()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM oncelik", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbOncelik.DataSource = dt;
            cbOncelik.ValueMember = "oncelik_id";
            cbOncelik.DisplayMember = "oncelik";
        }
       
        private void durumcekme()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM durum", bag);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cbDurum.DataSource = dt;
            cbDurum.ValueMember = "durum_id";
            cbDurum.DisplayMember = "durum";
        }
      

        //projeler sayfasındaki datagride projeleri listeleme
        private void Projecekme()
        {
            bag.Open();
            SqlDataAdapter da3 = new SqlDataAdapter("select p.ProjeAdi,p.Sahip,o.oncelik,d.durum,p.pbaslangic,p.pbitis,p.butce " +
                "from proje p, oncelik o ,durum d " +
                "where  (o.oncelik_id=p.oncelik_id) and (d.durum_id=p.durum_id)", bag);
            DataTable dt3 = new DataTable();
            da3.Fill(dt3);
            dgvProjeler.DataSource = dt3;
            bag.Close();
            this.dgvProjeler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }


        //proje ekle sayfasındaki girilen verileri veritabanına kaydetme
        private void thunderButton2_Click(object sender, EventArgs e)
        {
            bag.Open();
            string sql = "insert into Proje (ProjeAdi,Sahip,oncelik_id,durum_id,pbaslangic,pbitis,butce) values  (@ProjeAdi,@Sahip,@Oncelik,@Durum,@Baslangıc,@Bitis,@Butce)";
            SqlCommand cmd = new SqlCommand(sql, bag);
            cmd.Parameters.AddWithValue("@ProjeAdi", txtProjeAdi.Text);
            cmd.Parameters.AddWithValue("@Sahip", txtSahip.Text);
            cmd.Parameters.AddWithValue("@Oncelik", cbOncelik.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Durum", cbDurum.SelectedValue.ToString());
            cmd.Parameters.AddWithValue("@Baslangıc", dt1.Value);
            cmd.Parameters.AddWithValue("@Bitis", dt2.Value);
            cmd.Parameters.AddWithValue("@Butce", txtButce.Text);

            cmd.ExecuteNonQuery();
            bag.Close();

            txtProjeAdi.Clear();
            txtSahip.Clear();
            txtDt.Clear();
            txtButce.Clear();

            Projecekme();
            guncelprojecekme();
            yeniprojecekme();
            tamamlanmışprojecekme();
            projeget();
            pprojegetirr();


        }
        //datetimepickerdaki değeri textboxa yazdırma
        public void dt2_ValueChanged(object sender, EventArgs e)
        {
            txtDt.Text = dt2.Value.Date.ToString(" d  MMMM  yyyy    dddd");
        }



        //proje güncelleme sayfasındaki kodlar


        SqlDataAdapter adtr;
        SqlCommandBuilder cmdb;
        DataSet ds;
        void listele()
        {
            bag.Open();

            adtr = new SqlDataAdapter("select p.ProjeAdi,p.Sahip,o.oncelik,d.durum,p.pbaslangic,p.pbitis,p.butce " +
                "from proje p, oncelik o ,durum d " +
                "where  (o.oncelik_id=p.oncelik_id) and (d.durum_id=p.durum_id)", bag);
            cmdb = new SqlCommandBuilder(adtr);
            ds = new DataSet();
            adtr.Fill(ds, "Proje");
            dataGridView2.DataSource = ds.Tables["Proje"];

            bag.Close();
            this.dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        // proje güncelle sayfasındaki güncelle butonuna tıklandığında değişiklikleri kaydetme butonu
        private void airButton2_Click(object sender, EventArgs e)
        {


            adtr.Update(ds, "Proje");
            MessageBox.Show("Güncellendi");
        }




        //projelerget isimli comboboxta seçilen değere göre datagridde gösterilecek verileri getirme
        private void cbProjelerget_SelectedIndexChanged(object sender, EventArgs e)
        {

            bag.Close();
            bag.Open();
            SqlDataAdapter abc = new SqlDataAdapter("select p.Sahip,g.gorevadi,c.calisanadi,g.gbaslangic,g.gbitis,o.oncelik,d.durum,g.gmaaliyet,p.butce " +
                "from gorev g,proje p,calisan c, oncelik o ,durum d " +
                "where (g.projeid=p.projeid) and  (c.calisanid=g.calisanid)  and (o.oncelik_id=g.oncelik_id) and (g.oncelik_id=o.oncelik_id) and (g.durum_id=d.durum_id) and p.projeid=@prm1 ", bag);
            abc.SelectCommand.Parameters.AddWithValue("@prm1", cbProjelerget.SelectedValue);
            DataTable sj = new DataTable();
            abc.Fill(sj);
            dataGridView6.DataSource = sj;
            dataGridView6.Columns["Sahip"].HeaderText = "Görevin Atanan Çalışanı";
            dataGridView6.Columns["gorevadi"].HeaderText = "Görev Adı";
            dataGridView6.Columns["calisanadi"].HeaderText = "Göreve Atanan";
            dataGridView6.Columns["gbaslangic"].HeaderText = "Başlama";
            dataGridView6.Columns["gbitis"].HeaderText = "Bitiş";
            dataGridView6.Columns["oncelik"].HeaderText = "Öncelik";
            dataGridView6.Columns["durum"].HeaderText = "Durum";
            dataGridView6.Columns["gmaaliyet"].HeaderText = "Maaliyet";

            this.dataGridView6.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;


            bag.Close();
        }

       

        private void tabPage19_Click(object sender, EventArgs e)
        {

        }

        
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void cbDurum_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void metroLabel1_Click(object sender, EventArgs e)
        {

        }

        private void unvancb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

       
    }
}
