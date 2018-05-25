using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class InputUI : UserControl
    {
        public InputUI()
        {
            InitializeComponent();
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            int money = 0;
            if (txbMoney.Text == "")
            {
                MessageBox.Show("Vui lòng nhập số tiền muốn thêm");
                return;
            }

            if (Int32.TryParse(txbMoney.Text, out money))
            {
                if (DatabaseHelper.DatabaseProcess.updateMoney(money)) // goi ham su ly database
                {
                    MessageBox.Show("Thêm thành công");
                }
                else
                {
                    MessageBox.Show("Thêm thất bại");
                }
                txbMoney.Text = "";

            }
            else
            {
                MessageBox.Show("Tiền nhập vào phải là chữ số");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if (!DatabaseHelper.DatabaseProcess.setMoney(0))
            { 
                MessageBox.Show("Reset thất bại");
            }
        }
    }
}
