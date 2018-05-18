using System;
using System.Drawing;
using System.Windows.Forms;

namespace Demo
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            txbPasswordRepeat.TextChanged += TxbPasswordRepeat_TextChanged;
        }

        private void TxbPasswordRepeat_TextChanged(object sender, EventArgs e)
        {
            if (txbPassword.Text != txbPasswordRepeat.Text)
                txbPasswordRepeat.ForeColor = Color.Red;
            else
                txbPasswordRepeat.ForeColor = Color.Green;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txbUsername.Text == "" || txbPassword.Text == "" || txbPasswordRepeat.Text == "")
            {
                MessageBox.Show("Không được để trống username và password");
            }
            else
            {
                if (txbPassword.Text != txbPasswordRepeat.Text)
                {
                    txbPasswordRepeat.Focus();
                    MessageBox.Show("Mật khẩu không giống nhau");
                    return;
                }


                int money = 0;
                if (txbMoney.Text != "")
                {
                    if (!Int32.TryParse(txbMoney.Text, out money))
                    {
                        MessageBox.Show("Số tiền phải là chữ số");
                        return;
                    }
                }

                if (DatabaseHelper.DatabaseProcess.isExistsUsername(txbUsername.Text)) // kiểm tra xem tên tài khoản đã tồn tại hay chưa
                {
                    MessageBox.Show("Tên tài khoản đã tồn tại");
                    return;
                }
                else
                {
                    if (DatabaseHelper.DatabaseProcess.register(txbUsername.Text, txbPassword.Text, money))
                    {
                        MessageBox.Show("Đăng ký thành công");
                        Close(); // đóng form đăng ký
                    }
                    else
                    {
                        MessageBox.Show("Đăng ký thất bại");
                    }

                }

            }
        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
