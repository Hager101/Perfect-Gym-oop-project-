using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace perfectgem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sidepanel.Height = button6.Height;
            Sidepanel.Top = button6.Top;
            home1.BringToFront();

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button7.Height;
            Sidepanel.Top = button7.Top;
            about_us1.BringToFront();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 H = new Form1();
            this.Hide();
            H.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button3.Height;
            Sidepanel.Top = button3.Top;
            my_fitness_plan1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button2.Height;
            Sidepanel.Top = button2.Top;
            feedback1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = button1.Height;
            Sidepanel.Top = button1.Top;
            health_advice1.BringToFront();
        }

        private void sign_up1_Load(object sender, EventArgs e)
        {

        }

        private void sign_up1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Sidepanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
