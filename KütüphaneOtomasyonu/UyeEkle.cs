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
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=rahime;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into uye (ogrencino, adsoyad, yas, cinsiyet, telefon, adres, email,okukitapsayisi) values(@ogrencino, @adsoyad, @yas, @cinsiyet, @telefon, @adres, @email, @okukitapsayisi)", baglanti);
            komut.Parameters.AddWithValue("@ogrencino", txtNo.Text);
            komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut.Parameters.AddWithValue("@yas", txtYas.Text);
            komut.Parameters.AddWithValue("@cinsiyet", comboCinsiyet.Text);
            komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut.Parameters.AddWithValue("@email", txtEmail.Text);
            komut.Parameters.AddWithValue("@okukitapsayisi", txtOkunanSayi.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("uye kaydı yapıldı");
            foreach (Control item in Controls)
            {
                if (Controls is TextBox)
                {
                    if (item != txtOkunanSayi)
                    {
                        item.Text = "";
                    }
                }

            }

        }
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UyeEkle_Load(object sender, EventArgs e)
        {

        }

        private void txtYas_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtOkunanSayi_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
