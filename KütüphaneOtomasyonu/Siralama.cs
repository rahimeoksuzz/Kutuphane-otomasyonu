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
    public partial class Siralama : Form
    {
        public Siralama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=rahime;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void Siralama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("OkumaDurumu", baglanti);
            //SqlDataAdapter adtr = new SqlDataAdapter("select Uye.ogrencino order by okukitapsayisi desc", baglanti);
            adtr.Fill(daset, "Uye");
            dataGridView1.DataSource = daset.Tables["Uye"];
            baglanti.Close();
            label2.Text = "";
            label4.Text = "";
            label2.Text = daset.Tables["Uye"].Rows[0]["adsoyad"].ToString() + "=";
            label2.Text += daset.Tables["Uye"].Rows[0]["okukitapsayisi"];
            label4.Text = daset.Tables["Uye"].Rows[dataGridView1.Rows.Count - 2]["adsoyad"].ToString() + "=";
            label4.Text += daset.Tables["Uye"].Rows[dataGridView1.Rows.Count - 2]["okukitapsayisi"];
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
