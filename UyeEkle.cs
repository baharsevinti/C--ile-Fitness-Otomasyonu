using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class UyeEkle : Form
    {
        public UyeEkle()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; user ID = postgres; password=40667144136; Database= SporDb");

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            String query = "Insert into UyeTbl (UAdSoyad,UTelefon,UCinsiyet,UYas,UOdeme,UZamanlama) values (@p1,@p2,@p3,@p4,@p5,@p6)";
            NpgsqlCommand cmd = new NpgsqlCommand(query, baglanti);

            cmd.Parameters.AddWithValue("@p1", guna2TextBox1.Text);
            cmd.Parameters.AddWithValue("@p2", guna2TextBox2.Text);
            cmd.Parameters.AddWithValue("@p3", comboBox1.Text);
            cmd.Parameters.AddWithValue("@p4", guna2TextBox3.Text);
            cmd.Parameters.AddWithValue("@p5", guna2TextBox4.Text);
            cmd.Parameters.AddWithValue("@p6", comboBox2.Text);
            cmd.ExecuteNonQuery();


            baglanti.Close();

        }
    }
}
