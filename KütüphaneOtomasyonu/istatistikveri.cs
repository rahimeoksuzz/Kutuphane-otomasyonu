using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KütüphaneOtomasyonu
{
    public partial class istatistikveri : Form
    {
        public istatistikveri()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=rahime;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void button1_Click(object sender, EventArgs e)
        {
            Siralama siralamasi = new Siralama();
            siralamasi.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kiralayanlarsiralama ksiralamasi = new kiralayanlarsiralama();
            ksiralamasi.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CinsiyetSiralama cSiralama = new CinsiyetSiralama();
            cSiralama.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            YasSiralama sSiralama = new YasSiralama();
            sSiralama.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OkumaYasSiralama oSiralama = new OkumaYasSiralama();
            oSiralama.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            YayineviSiralama ySiralama = new YayineviSiralama();
            ySiralama.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            YayineviKiralama kSiralama = new YayineviKiralama();
            kSiralama.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            TurSiralama tSiralama = new TurSiralama();
            tSiralama.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            YazarSiralama yzSiralama = new YazarSiralama();
            yzSiralama.ShowDialog();
        }
    }
}
