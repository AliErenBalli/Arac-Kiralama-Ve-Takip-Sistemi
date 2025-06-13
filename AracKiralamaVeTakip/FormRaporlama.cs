using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AracKiralamaVeTakip
{
    public partial class FormRaporlama : Form
    {
        List<KiraSozlesmesi> sozlesmeler;
        public FormRaporlama(List<KiraSozlesmesi> sozlesmeList)
        {
            InitializeComponent();
            sozlesmeler = sozlesmeList;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Aktif_Kiralamalar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void FormRaporlama_Load(object sender, EventArgs e)
        {

            List<KiraSozlesmesi> kirasözleşmeleri = Program.Sozlesmeler;
            var enCok = Raporlama.EnCokKiralananArac(Program.Sozlesmeler);
            lblEnCokKiralanan.Text = enCok?.ToString() ?? "Veri yok";
            
            foreach (var KiraSozlesmesi in Raporlama.AktifKiralamalar(kirasözleşmeleri))
            {
                Aktif_Kiralamalar.Items.Add(KiraSozlesmesi);
            }
            foreach (var KiraSozlesmesi in Raporlama.RezerveKiralamalar(kirasözleşmeleri))
            {
                Aktif_Kiralamalar.Items.Add(KiraSozlesmesi);
            }
            foreach (var KiraSozlesmesi in Raporlama.GeçmişKiralamalar(kirasözleşmeleri))
            {
                Aktif_Kiralamalar.Items.Add(KiraSozlesmesi);
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            var enCok = Raporlama.EnCokKiralananArac(sozlesmeler);
            lblEnCokKiralanan.Text = enCok != null ? enCok.ToString() : "Yok";

            Aktif_Kiralamalar.Items.Clear();

            foreach (var s in Raporlama.AktifKiralamalar(sozlesmeler))
            {
                Aktif_Kiralamalar.Items.Add($"Aktif Kiralamalar: {s.KiralananArac.Marka} - {s.KiralananArac.Model} - {s.KiralananArac.Yil} - {s.KiralananArac.Plaka} - {s.Musteri.AdSoyad} ({s.BaslangicTarihi.ToShortDateString()} - {s.BitisTarihi.ToShortDateString()}) - {s.ToplamTutar}TL");
            }
            foreach (var s in Raporlama.RezerveKiralamalar(sozlesmeler))
            {
                Aktif_Kiralamalar.Items.Add($"Rezerve Kiralamalar: {s.KiralananArac.Marka} - {s.KiralananArac.Model} - {s.KiralananArac.Yil} - {s.KiralananArac.Plaka} - {s.Musteri.AdSoyad} ({s.BaslangicTarihi.ToShortDateString()} - {s.BitisTarihi.ToShortDateString()}) - {s.ToplamTutar}TL");
            }
            foreach (var s in Raporlama.GeçmişKiralamalar(sozlesmeler))
            {
                Aktif_Kiralamalar.Items.Add($"Geçmiş Kiralamalar: {s.KiralananArac.Marka} - {s.KiralananArac.Model} - {s.KiralananArac.Yil} - {s.KiralananArac.Plaka} - {s.Musteri.AdSoyad} ({s.BaslangicTarihi.ToShortDateString()} - {s.BitisTarihi.ToShortDateString()}) - {s.ToplamTutar}TL");
            }
        }
    }
}
