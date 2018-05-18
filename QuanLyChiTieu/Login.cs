using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // login vào hệ thống
        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if (txbPassword.Text != "" && txbUsername.Text != "")
            {
                if (DatabaseHelper.DatabaseProcess.login(txbUsername.Text, txbPassword.Text))
                {
                    Config.Username = txbUsername.Text;
                    Close(); // đóng form
                }
                else
                {
                    MessageBox.Show("Sai tên tài khoản hoặc mật khẩu");
                }
            }
            else
            {
                MessageBox.Show("Không được để trống trường nào");
            }
        }

        // đăng ký tài khoản
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Hide(); // ẩn form đăng nhập
            Register register = new Register();
            register.FormClosed += Register_FormClosed;
            register.ShowDialog();
        }

        private void Register_FormClosed(object sender, FormClosedEventArgs e)
        {
            txbUsername.Text = "";
            txbPassword.Text = "";
            Show(); // hiển thị lại form đăng nhập
        }
    }
}
