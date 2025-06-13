using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaVeTakip
{
    static class Program
    {
        public static List<Arac> Araclar = new List<Arac>();
        public static List<Musteri> Musteriler = new List<Musteri>();
        public static List<KiraSozlesmesi> Sozlesmeler = new List<KiraSozlesmesi>();

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

}
