using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarismasi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bnbasla_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Hide();
            Form1 ac = new Form1();
            ac.Show();
        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
