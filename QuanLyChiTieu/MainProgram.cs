using System;
using System.Windows.Forms;

namespace Demo
{
    public partial class MainProgram : Form
    {
        public MainProgram()
        {
            InitializeComponent();

            if (Config.Username == "")
            {
                Account accountManager = new Account();
                accountManager.FormClosed += AccountManager_FormClosed;
                accountManager.ShowDialog();
            }
            else
            {
                SpendUI spendUI = new SpendUI();
                showControl(spendUI);
            }
        }

        private void AccountManager_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Config.Username != "")
            {
                SpendUI spendUI = new SpendUI();
                showControl(spendUI);
            }
            else
            {
                Application.Exit();
            }
        }

        private void btnSpend_Click(object sender, EventArgs e)
        {
            SpendUI spendUI = new SpendUI();
            showControl(spendUI);
        }

        private void btnPresent_Click(object sender, EventArgs e)
        {
            PresentUI presentUI = new PresentUI();
            showControl(presentUI);
        }

        private void btnDiary_Click(object sender, EventArgs e)
        {
            DiaryUI diaryUI = new DiaryUI();
            showControl(diaryUI);
        }

        private void btnInput_Click(object sender, EventArgs e)
        {
            InputUI inputUI = new InputUI();
            showControl(inputUI);
        }

        private void showControl(UserControl control)
        {
            pnlMain.Controls.Clear();
            pnlMain.Controls.Add(control);
        }
    }
}
