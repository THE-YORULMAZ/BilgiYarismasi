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

namespace BilgiYarismasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglan = new SqlConnection("Data Source=THEYORULMAZZ;Initial Catalog=BilgiYarismasi;Integrated Security=True");
        int sayac = 0;
        int puan = 0;
        int zaman = 21;
        int dogru = 0;
        int yanlis = 0;
        int bos = 0;

        private void btnbasla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            zaman = 21;
            btnA.BackColor = Color.White;
            btnB.BackColor = Color.White;
            btnC.BackColor = Color.White;
            btnD.BackColor = Color.White;
            btnbasla.Enabled = false;
            btnA.Enabled = true;
            btnB.Enabled = true;
            btnC.Enabled = true;
            btnD.Enabled = true;
            btnbasla.Text = "SONRAKİ";
            sayac++;
            lblsoru.Text = sayac.ToString();

            if (sayac == 1)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular1 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogrucvp.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac == 2)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular2 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogrucvp.Text = (oku["dogru"].ToString());                }
                baglan.Close();
            }
            if (sayac == 3)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular3 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogrucvp.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac == 4)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular4 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogrucvp.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac == 5)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular5 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogrucvp.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac == 6)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular6 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogrucvp.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac == 7)
            {
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular7 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogrucvp.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac == 8)
            {

                btnbasla.Enabled = false;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular8 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogrucvp.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac == 9)
            {
                btnbasla.Enabled = false;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorular9 order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogrucvp.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac == 10)
            {
                btnbasla.Enabled = false;
                baglan.Open();
                SqlCommand komut = new SqlCommand("Select * from sorularon order by NEWID()", baglan);
                SqlDataReader oku = komut.ExecuteReader();
                while (oku.Read())
                {
                    btnA.Text = (oku["a"].ToString());
                    btnB.Text = (oku["b"].ToString());
                    btnC.Text = (oku["c"].ToString());
                    btnD.Text = (oku["d"].ToString());
                    textBox1.Text = (oku["soru"].ToString());
                    lbldogrucvp.Text = (oku["dogru"].ToString());

                }
                baglan.Close();
            }
            if (sayac == 11)
            {
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                timer1.Enabled = false;
                btnbasla.Text = "OYUN BİTTİ";
            }

        
    }

        private void timer1_Tick(object sender, EventArgs e)
        {
            zaman = zaman - 1;
            lblsayac.Text = zaman.ToString();
            if (zaman == 0)
            {
                timer1.Enabled = false;
                btnA.Enabled = false;
                btnB.Enabled = false;
                btnC.Enabled = false;
                btnD.Enabled = false;
                btnbasla.Enabled = true;
                bos++;
                lblbos.Text = bos.ToString();
            }
        }

        private void btnA_Click(object sender, EventArgs e)
        {
            if (btnA.Text == lbldogrucvp.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                btnA.BackColor = Color.Green;
                dogru++;
                lbldogru.Text = dogru.ToString();
            }
            else
            {
                btnA.BackColor = Color.Red;
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
            btnbasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnB_Click(object sender, EventArgs e)
        {
            if (btnB.Text == lbldogrucvp.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                btnB.BackColor = Color.Green;
                dogru++;
                lbldogru.Text = dogru.ToString();
            }
            else
            {
                btnB.BackColor = Color.Red;
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
            btnbasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            if (btnC.Text == lbldogrucvp.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                btnC.BackColor = Color.Green;
                dogru++;
                lbldogru.Text = dogru.ToString();
            }
            else
            {
                btnC.BackColor = Color.Red;
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
            btnbasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            if (btnD.Text == lbldogrucvp.Text)
            {
                puan = puan + 10;
                lblpuan.Text = puan.ToString();
                btnD.BackColor = Color.Green;
                dogru++;
                lbldogru.Text = dogru.ToString();
            }
            else
            {
                btnD.BackColor = Color.Red;
                yanlis++;
                lblyanlis.Text = yanlis.ToString();
            }
            btnbasla.Enabled = true;
            btnA.Enabled = false;
            btnB.Enabled = false;
            btnC.Enabled = false;
            btnD.Enabled = false;
        }


    }
}
