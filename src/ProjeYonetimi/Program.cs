using System;
using System.Windows.Forms;
using ProjeYonetimi.Forms;

namespace ProjeYonetimi
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın giriş noktası: önce giriş ekranı açılır,
        /// başarılı girişten sonra ana ekrana geçilir.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new GirisForm());
        }
    }
}
