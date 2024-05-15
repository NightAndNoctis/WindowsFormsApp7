using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con;
        SqlDataReader dr;
        SqlCommand com;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
      

        private void button1_Click_1(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            con = new SqlConnection("Data Source=LAPTOP-K6C5492N;Initial Catalog=Manav;Integrated Security=True;Trust Server Certificate=True");
            com = new SqlCommand();
            con.Open();

            com.Connection = con;
        com.CommandText = "Select*From Hesap where kullanici_adi='" + textBox1.Text +
            "'And sifre='" + textBox2.Text + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                MessageBox.Show("Giriş Başarılı");
                Secenektler gecis = new Secenektler();
                gecis.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı kullanıcı Adı veya Şifre");
            }
            con.Close();
        }
    }
}
