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
    public partial class SpendShow : UserControl
    {
        private string name;
        private string money;

        public SpendShow(string name, int money)
        {
            InitializeComponent();

            NameDiary = name;
            Money = money.ToString();

            txbName.DataBindings.Add(new Binding("Text", this, "NameDiary"));
            txbMoney.DataBindings.Add(new Binding("Text", this, "Money"));
        }

        public string NameDiary
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Money
        {
            get
            {
                return money;
            }

            set
            {
                money = value;
            }
        }
    }
}
