using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kassa
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (usernameInput.Text == "Admin" &&
                passwordInput.Text == "123")
            {
                // Load new form
                Hide();
                RegisterForm register = new RegisterForm();
                register.Show();
            }
            else
            {
                MessageBox.Show("Invalid username and password combination!");
            }
        }
    }
}
