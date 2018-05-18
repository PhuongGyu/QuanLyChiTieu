using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            Hide();
            Login login = new Login();
            login.FormClosed += Login_FormClosed;
            login.ShowDialog();
        }

        private void Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Config.Username != "")
                Close();
            else
                Show();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Hide();
            Register register = new Register();
            register.FormClosed += Register_FormClosed;
            register.ShowDialog();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            Show();
        }
    }
}
