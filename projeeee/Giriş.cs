using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReaLTaiizor.Forms;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace projeeee
{
    public partial class Giriş : MaterialForm
    {
        public Giriş()
        {
            InitializeComponent();
        }
        SqlConnection bag = new SqlConnection(@"Data Source=DESKTOP-US47PBB\SQLEXPRESS; initial catalog=Proje Yönetimi; integrated security=true");

        private void thunderButton1_Click(object sender, EventArgs e)
        {
            string adı = aloneTextBox1.Text;
            string şifre =aloneTextBox2.Text;
            bag.Open();
            SqlCommand komut = new SqlCommand();
            komut.Connection = bag;
            komut.CommandText = "SELECT * FROM kadi WHERE kadi ='" + adı + "' AND sifre ='" + şifre + "'";
            komut.ExecuteNonQuery();
            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                this.Hide();

                anasayfa anaekran = new anasayfa();

                anaekran.Show();

            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }

            bag.Close();
           
        }

        private void Giriş_Load(object sender, EventArgs e)
        {

        }

       
    }
}
