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
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }
        
        SqlConnection baglanti = new SqlConnection("Data Source=rahime;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Grafikler_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select adsoyad, okukitapsayisi from Uye", baglanti);
            SqlDataReader read = komut.ExecuteReader();

            while (read.Read()) 
            {
                chart1.Series["Okunan Kitap Sayısı"].Points.AddXY(read["adsoyad"], read["okukitapsayisi"]);

            }
            baglanti.Close();
        }
    }
}
