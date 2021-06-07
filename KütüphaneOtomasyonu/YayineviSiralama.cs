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
    public partial class YayineviSiralama : Form
    {
        public YayineviSiralama()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=rahime;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void YayineviSiralama_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("KitapYayineviSiralama", baglanti);
            adtr.Fill(daset, "Kitap");
            dataGridView1.DataSource = daset.Tables["Kitap"];
            baglanti.Close();
        }
    }
}
