using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using ProjeYonetimi.Data;
using ReaLTaiizor.Forms;

namespace ProjeYonetimi.Forms
{
    public partial class GirisForm : MaterialForm
    {
        public GirisForm()
        {
            InitializeComponent();
        }

        // Enter tuşu ile giriş yapılabilsin. ReaLTaiizor metin kutuları KeyDown olayını
        // forma iletmediği için tuş, form seviyesinde yakalanır.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                GirisYap();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            GirisYap();
        }

        private void GirisYap()
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string sifre = txtSifre.Text;

            if (kullaniciAdi.Length == 0 || sifre.Length == 0)
            {
                MessageBox.Show("Kullanıcı adı ve şifre boş bırakılamaz.", "Giriş",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Parametreli sorgu: SQL injection'a karşı güvenli
                object sonuc = Veritabani.Deger(
                    "SELECT COUNT(*) FROM kadi WHERE kadi = @kadi AND sifre = @sifre",
                    Veritabani.P("@kadi", kullaniciAdi),
                    Veritabani.P("@sifre", Veritabani.SifreOzeti(sifre)));

                if (Convert.ToInt32(sonuc) > 0)
                {
                    var anaForm = new AnaForm();
                    anaForm.FormClosed += (s, a) => Close();
                    Hide();
                    anaForm.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Giriş",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSifre.Text = string.Empty;
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Veritabanına bağlanılamadı.\n\n" + ex.Message +
                    "\n\nApp.config içindeki bağlantı cümlesini kontrol edin.",
                    "Bağlantı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
