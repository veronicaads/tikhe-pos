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
            
        }

        private void button22_Click(object sender, EventArgs e)
        {
            String username = user_txt.Text;
            String password = pass_txt.Text;
            String nama = nama_txt.Text;
            String email = email_txt.Text;
            String hp = hp_txt.Text;
            FirebaseDB firebaseDB = new FirebaseDB("https://mobile-shoebox.firebaseio.com/Employees");
            FirebaseDB firebaseDBEmployees = firebaseDB.Node(username);
            var data = @"{'username' : '" + username + "','password' : '" + password +"'}";
            firebaseDBEmployees.Put(data);
        }
        int TogMove;
        int X, Y;
        private void Employee_MouseDown(object sender, MouseEventArgs e)
        {
            TogMove = 1;
            X = e.X;
            Y = e.Y;
        }

        private void Employee_MouseMove(object sender, MouseEventArgs e)
        {
            if (TogMove == 1)
            {
                this.SetDesktopLocation(MousePosition.X - X, MousePosition.Y - Y);
            }
        }

        private void Employee_MouseUp(object sender, MouseEventArgs e)
        {
            TogMove = 0;
        }
    }
}
