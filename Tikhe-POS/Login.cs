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
    
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            // Set to no text.  
            password_edit.Text = "";
            // The password character is an asterisk.  
            password_edit.PasswordChar = '*';
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            String username = username_edit.Text;
            String password = password_edit.Text;
            if (String.Compare(username,"superadmin")==0 && String.Compare(password,"shoebox555")==0)
            {
                MainMenu form = new MainMenu();
                form.Show(); Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password tidak sesuai. Silahkan ulangi!");

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
