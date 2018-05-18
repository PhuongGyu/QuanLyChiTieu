using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class SpendUI : UserControl
    {
        public SpendUI()
        {
            InitializeComponent();

            txbMoney.Text = "";
            txbNameSpend.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txbMoney.Text != "" && txbNameSpend.Text != "")
            {
                int money = 0;
                if (Int32.TryParse(txbMoney.Text, out money))
                {
                    Spend spend = new Spend();
                    spend.Name = txbNameSpend.Text;
                    spend.Money = money;
                    spend.Date = DateTime.Now;

                    if (DatabaseHelper.DatabaseProcess.addSpend(spend))
                    {
                        MessageBox.Show("Lưu thành công");
                    }
                    else
                    {
                        MessageBox.Show("Lưu thất bại");
                    }

                    txbMoney.Text = "";
                    txbNameSpend.Text = "";
                }
                else
                {
                    MessageBox.Show("Tiền nhập vào phải là chữ số");
                }

            }
            else
            {
                MessageBox.Show("Vui lòng không để trống bất kỳ ô nào");
            }
        }
    }
}
