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
    public partial class My_fitness_plan : UserControl
    {
        public My_fitness_plan()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.active.com/fitness/articles/10-ways-to-get-in-shape-faster");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.healthline.com/nutrition/best-exercise-for-weight-loss");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.healthline.com/health/exercise-to-gain-weight");

        }
    }
}
