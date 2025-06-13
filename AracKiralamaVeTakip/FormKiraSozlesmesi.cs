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
    public partial class FormKiraSozlesmesi : Form
    {
        public FormKiraSozlesmesi()
        {
            InitializeComponent();
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnKirala_Click(object sender, EventArgs e)
        {
            Arac seciliArac = cmbArac.SelectedItem as Arac;
            Musteri seciliMusteri = cmbMusteri.SelectedItem as Musteri;

            var sozlesme = new KiraSozlesmesi();
            sozlesme.Id = Program.Sozlesmeler.Count + 1;
            sozlesme.KiralananArac = seciliArac;
            sozlesme.Musteri = seciliMusteri;
            sozlesme.BaslangicTarihi = dtBaslangic.Value;
            sozlesme.BitisTarihi = dtBitis.Value;
            DateTime now = DateTime.Now;
            foreach (var s in Program.Sozlesmeler)
                if (s.KiralananArac == sozlesme.KiralananArac && (s.BaslangicTarihi <= sozlesme.BitisTarihi && s.BitisTarihi >= sozlesme.BaslangicTarihi))
                {
                    MessageBox.Show("Seçilen araç istenilen tarihlerde başka bir kullanıcı tarafından kiralanmış ");
                    return;
                }
            if (sozlesme.BaslangicTarihi >= sozlesme.BitisTarihi)
            {
                MessageBox.Show("Seçilen tarihler yanlıştır");
                return;
            }
            Program.Sozlesmeler.Add(sozlesme);
            Listele();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }
        private void Listele()
        {
            Kiralananlar.Items.Clear();
            foreach (var sozlesme in Program.Sozlesmeler)
                Kiralananlar.Items.Add(sozlesme);
        }

        private void cmbArac_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormKiraSozlesmesi_Load(object sender, EventArgs e)
        {
            List<Arac> araclar = Program.Araclar;
            foreach (var arac in araclar)
            {
                cmbArac.Items.Add(arac);
            }
            List<Musteri> musteriler = Program.Musteriler;
            foreach (var musteri in musteriler)
            {
                cmbMusteri.Items.Add(musteri);
            }

        }
    }
}
