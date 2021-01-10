using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perfectgem
{
    public partial class Feedback : UserControl
    {
        public Feedback()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Font f1 = new Font("Arial", 11, FontStyle.Bold);
            textBox1.Font = f1;
            textBox1.ForeColor = Color.Black;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Font f2 = new Font("Arial", 11, FontStyle.Bold);
            textBox2.Font = f2;
            textBox2.ForeColor = Color.Black;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            Font f3 = new Font("Arial", 11, FontStyle.Bold);
            textBox3.Font = f3;
            textBox3.ForeColor = Color.Black;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Please Fill your form");
            }
            else
            {
                MessageBox.Show("Thanks For your Feedback");
                Home h = new Home();
                this.Hide();
                h.Show();
            }
        }
    }
}
