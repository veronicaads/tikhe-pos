using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tikhe_POS
{
    public partial class ReportInput : Form
    {
        public ReportInput()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox3.SelectedIndex == 0) {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("All");
                comboBox2.Items.Add("Deep Clean");
                comboBox2.Items.Add("Fast Clean");
                comboBox2.Items.Add("Unyellowing");
            }
            else if (comboBox3.SelectedIndex == 1)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("All");
                comboBox2.Items.Add("Dress Shoes");
                comboBox2.Items.Add("Casual Shoes");
                comboBox2.Items.Add("Workshoes");
                comboBox2.Items.Add("Dance Shoes");
                comboBox2.Items.Add("Boots");
                comboBox2.Items.Add("Sandals");
                comboBox2.Items.Add("Slippers");
                comboBox2.Items.Add("Running Shoes");
                comboBox2.Items.Add("BasketBall Shoes");
            }
            else if (comboBox3.SelectedIndex == 2)
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("All");
                comboBox2.Items.Add("Ordinary Sizing");
                comboBox2.Items.Add("Full Sizing");
                comboBox2.Items.Add("Ordinary Sewing");
                comboBox2.Items.Add("Full Sewing");
                comboBox2.Items.Add("Remove Out Sol");
                comboBox2.Items.Add("Leather Patch");
                comboBox2.Items.Add("Remove In Sol");
                comboBox2.Items.Add("Leather Pressing");
            }
            
        }
    }
}
