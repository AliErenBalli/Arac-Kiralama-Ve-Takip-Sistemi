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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public List<Arac> araclar;
        public List<Musteri> musteriler;

        private void btnAracYonetimi_Click(object sender, EventArgs e)
        {
            FormAracYonetimi form = new FormAracYonetimi();
            form.ShowDialog();
        }

        private void btnMusteriKaydi_Click(object sender, EventArgs e)
        {
            FormMusteriKaydi form = new FormMusteriKaydi();
            form.ShowDialog();
        }

        private void btnKiraSozlesmesi_Click(object sender, EventArgs e)
        {
            FormKiraSozlesmesi form = new FormKiraSozlesmesi();
            form.ShowDialog();
        }

        private void btnRaporlama_Click(object sender, EventArgs e)
        {
            FormRaporlama form = new FormRaporlama(Program.Sozlesmeler);
            form.ShowDialog();
        }
    }
}
