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
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cairogyms.com/category/nutrition/");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cairogyms.com/category/women-workouts/");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://cairogyms.com/category/men-workouts/");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.verywellfit.com/simple-yoga-exercises-3567193");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lets Go!");
            
            Sign_up s = new Sign_up();
            this.Hide();
            s.Show();
           
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
