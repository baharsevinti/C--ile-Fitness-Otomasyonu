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
    public partial class Odeme : Form
    {
        public Odeme()
        {
            InitializeComponent();
        }

        NpgsqlConnection baglanti = new NpgsqlConnection("server=localhost;port=5432; user ID = postgres; password=40667144136; Database= SporDb"); 
        private void Odeme_Load(object sender, EventArgs e)
        {

         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string sorgu = "select * from UyeTbl";
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(sorgu, baglanti);
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            guna2DataGridView1.DataSource = dataSet.Tables[0];
        }
    }
}
