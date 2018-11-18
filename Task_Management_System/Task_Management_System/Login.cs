using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_Management_System
{
    public partial class Login : Form
    {
        protected string connectString = "Data Source=199.103.60.77;Initial Catalog=aresendeviana683;Persist Security Info=True;User ID=aresendeviana683;Password=4577695275537560";
        int loggedUserId;


        public Login()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text != "" && PasswordTextBox.Text != "")
            {
                loggedUserId = LinqToSQLCRUD.LoginUser(UserNameTextBox.Text, PasswordTextBox.Text, connectString);

                if (loggedUserId == 0)
                {
                    MessageBox.Show("Invalid Credentials.");
                }
                else
                {
                    MessageBox.Show("Login successful.");
                    UserNameTextBox.Text = "";
                    PasswordTextBox.Text = "";
                    Home home = new Home(loggedUserId);
                    home.Show();
                }
            }
            else
            {
                MessageBox.Show("Enter UserName and Password.");
            }

            

        }
    }
}
