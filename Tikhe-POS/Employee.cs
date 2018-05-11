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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            MainMenu form = new MainMenu();
            form.Show();Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            user_txt.Text = "";
            pass_txt.Text = "";
            nama_txt.Text = "";
            email_txt.Text = "";
            hp_txt.Text = "";
        }
    }
}
