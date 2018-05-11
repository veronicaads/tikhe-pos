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
    public partial class Supplier : Form
    {
        public Supplier()
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
            nama_txt.Text = "";
            alamat_txt.Text = "";
            email_txt.Text = "";
            hp_txt.Text = "";
            vendor_txt.Text = "";
        }
    }
}
