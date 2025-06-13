using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AracKiralamaVeTakip
{
    public partial class FormAracYonetimi : Form
    {
        public FormAracYonetimi()
        {
            InitializeComponent();
            cmbAracTuru.Items.Add("Sedan");
            cmbAracTuru.Items.Add("SUV");
            cmbAracTuru.Items.Add("Kamyonet");
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Arac arac = null;

            switch (cmbAracTuru.SelectedItem.ToString())
            {
                case "Sedan": arac = new Sedan(); break;
                case "SUV": arac = new SUV(); break;
                case "Kamyonet": arac = new Kamyonet(); break;
            }

            arac.Marka = txtMarka.Text;
            arac.Model = txtModel.Text;
            arac.Yil = int.Parse(txtYil.Text);
            arac.Plaka = txtPlaka.Text;
            arac.GunlukUcret=double.Parse(txtGunlukUcret.Text);
            foreach (var s in Program.Araclar)
                if (s.Plaka == arac.Plaka)
                {
                    MessageBox.Show("Aynı plakaya sahip araç eklenemez");
                    return;
                }
            arac.AraçTürü=cmbAracTuru.SelectedItem.ToString();
            Program.Araclar.Add(arac);
            Listele();
        }
        private void Listele()
        {
            Araç_listesi.Items.Clear();
            foreach (var arac in Program.Araclar)
                Araç_listesi.Items.Add(arac);
        }

        private void lstAraclar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Araç_listesi.SelectedItem is Arac seciliArac)
            {
                txtMarka.Text = seciliArac.Marka;
                txtModel.Text = seciliArac.Model;
                txtYil.Text = seciliArac.Yil.ToString();
                txtPlaka.Text = seciliArac.Plaka;

                if (seciliArac is Sedan) cmbAracTuru.SelectedItem = "Sedan";
                else if (seciliArac is SUV) cmbAracTuru.SelectedItem = "SUV";
                else if (seciliArac is Kamyonet) cmbAracTuru.SelectedItem = "Kamyonet";
            }
        }

        public void cmbAracTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void Araç_listesi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
