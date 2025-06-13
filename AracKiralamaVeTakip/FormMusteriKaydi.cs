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
    public partial class FormMusteriKaydi : Form
    {
        public FormMusteriKaydi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Musteri m = new Musteri();
            m.AdSoyad = txtAdSoyad.Text;
            m.Telefon = txtTelefon.Text;
            m.Email = txtEmail.Text;
            foreach (var s in Program.Musteriler)
                if (s.Telefon == m.Telefon)
                {
                    MessageBox.Show("Mevcut kullanıcı eklenemez");
                    return;
                }
            Program.Musteriler.Add(m);
            Listele();
        }

        private void Listele()
        {
            Müşteriler.Items.Clear();
            foreach (var m in Program.Musteriler)
                Müşteriler.Items.Add(m);
        }
    }
}
