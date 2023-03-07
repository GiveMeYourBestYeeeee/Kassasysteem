using kassa.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace kassa
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            navigate(new OrderForm());
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            Hide();
            LoginForm login = new LoginForm();
            login.Show();
        }

        private void customerNavButton_Click(object sender, EventArgs e)
        {
            navigate(new CustomerForm());
        }

        private void orderNavButton_Click(object sender, EventArgs e)
        {
            navigate(new OrderForm());
        }

        private void navigate(Form form)
        {
            form.FormBorderStyle = FormBorderStyle.None;
            form.TopLevel = false;
            form.AutoScroll = true;

            if (!display.Controls.Contains(form))
            {
                display.Controls.Add(form);
            }

            foreach (Control control in display.Controls)
            {
                if (control != form) 
                { 
                    control.Hide();
                }
                else 
                { 
                    control.Show();
                }
            }
        }
    }
}
