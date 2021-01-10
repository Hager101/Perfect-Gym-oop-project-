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
    public partial class Sign_up : UserControl
    {
        public Sign_up()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Font f1 = new Font("Arial", 10, FontStyle.Regular);
            textBox1.Font = f1;
            textBox1.ForeColor = Color.Black;

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Font f1 = new Font("Arial", 10, FontStyle.Regular);
            textBox2.Font = f1;
            textBox2.ForeColor = Color.Black;

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            Font f1 = new Font("Arial", 10, FontStyle.Regular);
            textBox4.Font = f1;
            textBox1.ForeColor = Color.Black;

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            Font f1 = new Font("Arial", 10, FontStyle.Regular);
            textBox7.Font = f1;
            textBox7.ForeColor = Color.Black;

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            Font f1 = new Font("Arial", 10, FontStyle.Regular);
            textBox6.Font = f1;
            textBox6.ForeColor = Color.Black;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            Font f1 = new Font("Arial", 10, FontStyle.Regular);
            textBox5.Font = f1;
            textBox5.ForeColor = Color.Black;

        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox4.Text == "" || textBox5.Text == "" || textBox6.Text == "" || textBox7.Text == "")
            {
                MessageBox.Show("Please Fill Your Form", "Error in Register", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


            else 
            {


                MessageBox.Show("Welcome to Perfect Gym!");

                Home h = new Home();
                this.Hide();
                h.Show();
            }
            

        }
    }
}
