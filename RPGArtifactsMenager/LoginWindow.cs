using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RPGArtifactsManager;
using RPGArtifactsMenager.DatabaseRPG;

namespace RPGArtifactsMenager
{
    public partial class LoginWindow : Form
    {
        private Viewer viewer;
        private UserDatabaseHandler databaseHandler;
        public enum UserRole { ADMIN, USER, GUEST }
        public UserRole loggedUser;
        public LoginWindow()
        {
            InitializeComponent();
            databaseHandler = new UserDatabaseHandler();
            CenterToScreen();
        }

        private void btn_login_signin_Click(object sender, EventArgs e)
        {
            if (tbx_login_name.Text.Equals("") || tbx_login_pwd.Text.Equals(""))
            {
                MessageBox.Show("Passowrd or Name not given");
                return;
            }

            if (!databaseHandler.GetUsers().Contains(tbx_login_name.Text.TrimEnd(' ')))
            {
                MessageBox.Show("Given name does not exist in database");
                return;
            }

            string hashedPassword = databaseHandler.GenerateSHA256Hash(tbx_login_pwd.Text);

            if (!databaseHandler.FetchPassword(tbx_login_name.Text).Equals(hashedPassword))
            {
                MessageBox.Show("Incorrect password");
                return;
            }
            loggedUser = (UserRole)databaseHandler.GetUserRole(tbx_login_name.Text);
            viewer = new Viewer(this);
            viewer.Show();
            this.Hide();
        }

        private void btn_login_signup_Click(object sender, EventArgs e)
        {
            this.Size = new Size(this.Size.Width, this.Size.Width + 170);
        }

        private void btn_login_guest_Click(object sender, EventArgs e)
        {
            loggedUser = UserRole.GUEST;
            viewer = new Viewer(this);
            viewer.Show();
            this.Hide();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (tbx_create_name.Text.Equals(""))
            {
                MessageBox.Show("Name not given.");
                return;
            }

            if (tbx_create_pwd.Text.Equals("") || tbx_create_pwd2.Text.Equals(""))
            {
                MessageBox.Show("Password not given.");
                return;
            }

            if (!tbx_create_pwd.Text.Equals(tbx_create_pwd2.Text))
            {
                MessageBox.Show("Passwords are not the same.");
                return;
            }

            if (databaseHandler.GetUsers().Contains(tbx_create_name.Text.TrimEnd(' ')))
            {
                MessageBox.Show("Name has been already taken. Please change it.");
                return;
            }

            bool isCreated = databaseHandler.AddUser(tbx_create_name.Text, tbx_create_pwd.Text);

            if (isCreated)
            {
                MessageBox.Show("Account successfully created. You can log in now.");
            }

            else
            {
                MessageBox.Show("An error occurred while creating an account.");
            }
        }
    }
}
