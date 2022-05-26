using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPGArtifactsManager
{
    public partial class LoginControl : UserControl
    {
        public LoginControl()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (tbx_username.Text.Equals(""))
            {
                MessageBox.Show("Nazwa użytkownika nie może być pusta", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (tbx_password.Text.Equals(""))
            {
                MessageBox.Show("Hasło nie może być puste", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }
    }
}
