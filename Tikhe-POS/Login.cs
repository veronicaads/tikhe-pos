using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FirebaseNet.Database;
using Newtonsoft.Json.Linq;

namespace Tikhe_POS
{
    
    public partial class Login : Form
    {
        
        public Login()
        {
            InitializeComponent();
            // Set to no text.  
            password_edit.Text = "";
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
            if (String.Compare(username, "superadmin") == 0 && String.Compare(password, "shoebox555") == 0)
            {
                MainMenu form = new MainMenu();
                form.Show(); Hide();
            }
            else
            {
                try
                {
                    FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Employees");
                    FirebaseDB firebaseDBEmployees = firebaseDB.Node(username);
                    FirebaseResponse getResponse = firebaseDBEmployees.Get();
                    dynamic stuff = JObject.Parse(getResponse.JSONContent);
                    String usernameDB = stuff.username;
                    String passwordDB = stuff.password;
                    MessageBox.Show(usernameDB + passwordDB);
                    if (String.Compare(password, passwordDB) == 0)
                    {
                        MenuNormal form = new MenuNormal();
                        form.Show(); Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username atau Password Tidak Sesuai. Silangkan Ulangi!");
                    }                 
                }
                catch (Exception error)
                {
                    MessageBox.Show("Username atau Password Tidak Sesuai. Silangkan Ulangi!"+error.StackTrace);
                }
            }
        }
            
           
        

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void password_edit_TextChanged(object sender, EventArgs e)
        {

        }
        int TogMove;
        int SumbuX, SumbuY;
        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            SumbuX = e.X;
            SumbuY = e.Y;
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            SumbuX = e.X;
            SumbuY = e.Y;
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - SumbuX, MousePosition.Y - SumbuY);
            }
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - SumbuX, MousePosition.Y - SumbuY);
            }
        }
    }
}
