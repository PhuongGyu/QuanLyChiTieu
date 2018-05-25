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
    public partial class DiaryUI : UserControl
    {

        public DiaryUI()
        {
            InitializeComponent();

            dtpkDate.ValueChanged += DtpkDate_ValueChanged; // su kien thay doi ngay tren datetimepicker
            dtpkDate.Value = DateTime.Now;
        }

        private void DtpkDate_ValueChanged(object sender, EventArgs e)
        {
            loadSpend(dtpkDate.Value);
        }


        void loadSpend(DateTime date)
        {
            flpShow.Controls.Clear();
            // lấy các chi tiêu của ngày date lên và load vào view
            List<Spend> spends = DatabaseHelper.DatabaseProcess.loadSpend(date);
            // hien thi ra lich su chi tieu
            if (spends != null && spends.Count > 0)
            {
                foreach(var spend in spends)
                {
                    SpendShow spendShow = new SpendShow(spend.Name, spend.Money);
                    if (spendShow != null)
                        flpShow.Controls.Add(spendShow);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // xóa tất cả lịch sử trong ngày đang hiển thị
            if (DatabaseHelper.DatabaseProcess.deleteSpends(dtpkDate.Value))
            {
                MessageBox.Show("Xóa thành công");
            }
            else
            {
                MessageBox.Show("Xóa thất bại");
            }

            loadSpend(dtpkDate.Value);

        }
    }
}
