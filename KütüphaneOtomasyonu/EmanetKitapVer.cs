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
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;


namespace KütüphaneOtomasyonu
{
    public partial class EmanetKitapVer : Form
    {
        public EmanetKitapVer()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=rahime;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblKitapSayi_Click(object sender, EventArgs e)
        {

        }

        private void lblKayıtliKitapSayi_Click(object sender, EventArgs e)
        {

        }

        DataSet daset = new DataSet();

        private void btnEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into Sepet(barkodno, kitapadi, yazari, yayinevi, sayfasayisi, kitapsayisi, teslimtarihi, iadetarihi) values (@barkodno, @kitapadi, @yazari, @yayinevi, @sayfasayisi, @kitapsayisi, @teslimtarihi, @iadetarihi)", baglanti);
            komut.Parameters.AddWithValue("@barkodno", txtBarkodNo.Text);
            komut.Parameters.AddWithValue("@kitapadi", txtKitapAdi.Text);
            komut.Parameters.AddWithValue("@yazari", txtYazar.Text);
            komut.Parameters.AddWithValue("@yayinevi", txtYayinevi.Text);
            komut.Parameters.AddWithValue("@sayfasayisi", txtSayfaSayisi.Text);
            komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(txtKitapSayisi.Text));
            komut.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@iadetarihi", dateTimePicker2.Text);

            komut.ExecuteNonQuery();
            baglanti.Close();

            MessageBox.Show("Kitapları sepete ekleme işlemi gerçekleşti", "Ekleme işlemi gerçekleştirildi");

            daset.Tables["Sepet"].Clear();
            depolistele();
            lblKitapSayi.Text = "";
            kitapsayisi();

            foreach (Control item in grpKitapBilgi.Controls)
            {
                if (item is TextBox)
                {

                    if (item != txtKitapSayisi)
                    {
                        item.Text = "";
                    }
                }
            }

        }

        private void kitapsayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayisi) from Sepet ", baglanti);
            lblKitapSayi.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();

        }

        private void depolistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from Sepet", baglanti);

            adtr.Fill(daset, "Sepet");
            dataGridView1.DataSource = daset.Tables["Sepet"];
            baglanti.Close();


        }

        private void txtTc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uye where ogrencino like '" + txtOgrenciNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtAdSoyad.Text = read["adsoyad"].ToString();
                txtYas.Text = read["yas"].ToString();
                txtTelefon.Text = read["telefon"].ToString();
            }

            baglanti.Close();

            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayisi) from EmanetKitaplar where ogrencino = '" + txtOgrenciNo.Text +"' ", baglanti);
            lblKayıtliKitapSayi.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();

            if (txtOgrenciNo.Text == "")
            {
                foreach (Control item in grpKitapBilgi.Controls)
                {
                    if (item is TextBox)
                    {

                        item.Text = "";
                        lblKayıtliKitapSayi.Text = "";

                    }


                }
            }
        }

        private void EmanetKitapVer_Load(object sender, EventArgs e)
        {
            depolistele();
            kitapsayisi();
        }

        private void txtBarkodNo_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from kitap where barkodno like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                txtKitapAdi.Text = read["kitapadi"].ToString();
                txtYazar.Text = read["yazari"].ToString();
                txtYayinevi.Text = read["yayinevi"].ToString();
                txtSayfaSayisi.Text = read["sayfasayisi"].ToString();


            }

            baglanti.Close();
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in grpKitapBilgi.Controls)
                {
                    if (item is TextBox)
                    {

                        if (item != txtKitapSayisi)
                        {
                            item.Text = "";

                        }
                    }

                }
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult dialog;
            dialog = MessageBox.Show("kayit silinsin mi?", "Uyarı!!", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (dialog == DialogResult.Yes)
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Sepet where barkodno = '" + dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString() + "'", baglanti);
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Silme işlemi gerçekleştirldi", "Silme İşlemi");
                daset.Tables["Sepet"].Clear();
                depolistele();
                lblKitapSayi.Text = "";
                kitapsayisi();
            }


        }

        private void btnTeslimEt_Click(object sender, EventArgs e)
        {
            if (lblKitapSayi.Text != "")
            {

            if (txtOgrenciNo.Text != "" && txtAdSoyad.Text != "" && txtYas.Text != "" && txtTelefon.Text != "")
            {
                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        baglanti.Open();
                        //SqlCommand komut = new SqlCommand("insert into EmanetKitaplar (ogrencino, adsoyad, yas, telefon, barkodno, kitapadi, yazari, yayinevi, sayfasayisi, kitapsayisi, teslimtarihi, iadetarihi) values(@ogrencino, @adsoyad, @yas, @telefon, @barkodno, @kitapadi, @yazari, @yayinevi, @sayfasayisi, @kitapsayisi, @teslimtarihi, @iadetarihi) '" + txtTc.Text + "'", baglanti);
                        SqlCommand komut = new SqlCommand("insert into EmanetKitaplar (ogrencino, adsoyad, yas, telefon, barkodno, kitapadi, yazari, yayinevi, sayfasayisi, kitapsayisi, teslimtarihi, iadetarihi) values(@ogrencino, @adsoyad, @yas, @telefon, @barkodno, @kitapadi, @yazari, @yayinevi, @sayfasayisi, @kitapsayisi, @teslimtarihi, @iadetarihi)", baglanti);
                        komut.Parameters.AddWithValue("@ogrencino", txtOgrenciNo.Text);
                        komut.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
                        komut.Parameters.AddWithValue("@yas", txtYas.Text);
                        komut.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                        komut.Parameters.AddWithValue("barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                        komut.Parameters.AddWithValue("kitapadi", dataGridView1.Rows[i].Cells["kitapadi"].Value.ToString());
                        komut.Parameters.AddWithValue("yazari", dataGridView1.Rows[i].Cells["yazari"].Value.ToString());
                        komut.Parameters.AddWithValue("yayinevi", dataGridView1.Rows[i].Cells["yayinevi"].Value.ToString());
                        komut.Parameters.AddWithValue("sayfasayisi", dataGridView1.Rows[i].Cells["sayfasayisi"].Value.ToString());
                        komut.Parameters.AddWithValue("kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                        komut.Parameters.AddWithValue("teslimtarihi", dataGridView1.Rows[i].Cells["teslimtarihi"].Value.ToString());
                        komut.Parameters.AddWithValue("iadetarihi", dataGridView1.Rows[i].Cells["iadetarihi"].Value.ToString());                         
                        komut.ExecuteNonQuery();
                        SqlCommand komut2 = new SqlCommand(" update Uye set okukitapsayisi = okukitapsayisi + '" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "'where ogrencino = '" + txtOgrenciNo.Text + "' ", baglanti);
                        komut2.ExecuteNonQuery();

                        SqlCommand komut3 = new SqlCommand(" update Kitap set stoksayisi = stoksayisi- '" + int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()) + "' where barkodno = '" + dataGridView1.Rows[i].Cells["barkodno"].Value.ToString() + "' ", baglanti);
                        komut3.ExecuteNonQuery();


                        baglanti.Close();



                    }

                    baglanti.Open();
                    SqlCommand komut4 = new SqlCommand("delete from Sepet", baglanti);
                    komut4.ExecuteNonQuery();
                    baglanti.Close();

                    MessageBox.Show("kitap kiralandı");
                    daset.Tables["Sepet"].Clear();
                    depolistele();
                    txtOgrenciNo.Text = "";
                    lblKitapSayi.Text = "";
                    kitapsayisi();

                    lblKayıtliKitapSayi.Text = "";
                    //komut satırları
                }

                else
                {
                    MessageBox.Show("önce üye bilgisi girilmelidir.", "Uyarı!");

                }
            }

            else
            {
                MessageBox.Show("Önce sepete kitap eklenmelidir", "Uyarı!");

            }
        }


        private void grpUyeBilgi_Enter(object sender, EventArgs e)
        {

        }

        private void grpKitapBilgi_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }
    }
}
