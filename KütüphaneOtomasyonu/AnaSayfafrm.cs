using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KütüphaneOtomasyonu
{
    public partial class AnaSayfafrm : Form
    {
        public AnaSayfafrm()
        {
            InitializeComponent();
        }

        private void btnÜyeEkle_Click(object sender, EventArgs e)
        {
            UyeEkle uyeekle = new UyeEkle();
            uyeekle.ShowDialog();
        }

        private void btnÜyeListele_Click(object sender, EventArgs e)
        {
            UyeListeleme uyeliste = new UyeListeleme();
            uyeliste.ShowDialog();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            KitapEkle kitapekle = new KitapEkle();
            kitapekle.ShowDialog();
        }

        private void btnKitapListele_Click(object sender, EventArgs e)
        {
            KitapListele kitapliste = new KitapListele();
            kitapliste.ShowDialog();
        }

        private void btnEmanetVer_Click(object sender, EventArgs e)
        {
            EmanetKitapVer emanetkitapver = new EmanetKitapVer();
            emanetkitapver.ShowDialog();

        }

        private void btnEmanetListele_Click(object sender, EventArgs e)
        {
            EmanetKitapListeleme listele = new EmanetKitapListeleme();
            listele.ShowDialog();
        }

        private void btnEmanetİade_Click(object sender, EventArgs e)
        {
            EmanetKitapİade iade = new EmanetKitapİade();
            iade.ShowDialog();
        }

        private void btnSıralama_Click(object sender, EventArgs e)
        {
            istatistikveri istatistik = new istatistikveri();
            istatistik.ShowDialog();
        }

        private void btnGrafik_Click(object sender, EventArgs e)
        {
            Grafikler grafik = new Grafikler();
            grafik.ShowDialog();
        }
    }
}
