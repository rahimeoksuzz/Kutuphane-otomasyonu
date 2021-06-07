﻿using System;
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
    public partial class EmanetKitapİade : Form
    {
        public EmanetKitapİade()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=rahime;Initial Catalog=KütüphaneOtomasyonu;Integrated Security=True");
        DataSet daset = new DataSet();
        private void EmanetListele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            dataGridView1.DataSource = daset.Tables["EmanetKitaplar"];
            baglanti.Close();
        }

        private void EmanetKitapİade_Load(object sender, EventArgs e)
        {
            EmanetListele();

        }

        private void btnTeslimAl_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from EmanetKitaplar where ogrencino=@ogrencino and barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@ogrencino", dataGridView1.CurrentRow.Cells["ogrencino"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            SqlCommand komut2 = new SqlCommand("update Kitap set stoksayisi=stoksayisi + '" + dataGridView1.CurrentRow.Cells["kitapsayisi"].Value.ToString() + "' where barkodno = @barkodno", baglanti);
            komut2.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut2.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("kitap iade edildi");
            daset.Tables["EmanetKitaplar"].Clear();
            EmanetListele();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTcAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where ogrencino like '%" + txtOgrenciNoAra.Text + "%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txtOgrenciNoAra.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }
        private void txtBarkodNoAra_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["EmanetKitaplar"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from EmanetKitaplar where barkodno like '%" + txtBarkodNoAra.Text + "%'", baglanti);
            adtr.Fill(daset, "EmanetKitaplar");
            baglanti.Close();
            if (txtBarkodNoAra.Text == "")
            {
                daset.Tables["EmanetKitaplar"].Clear();
                EmanetListele();
            }
        }
    }

}
