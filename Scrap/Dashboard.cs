using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScarpLib;

namespace Scrap
{
    public partial class Dashboard : Form
    {
        MoneyControlIndices mci;
        public Dashboard()
        {
            InitializeComponent();
            mci = new MoneyControlIndices();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_Nifty50_Tick(object sender, EventArgs e)
        {
           ShareData data = mci.GetNifty50();
           lbl_val__Nifty50.Text =   data.Price.ToString();
           lbl_rise_Nifty50.Text = data.Rise.ToString() + "  ("+ data.ChangePerc.ToString() + " %)";

           pnl_Nifty50.BackColor = data.Rise > 0 ? Constants.colorPositive : Constants.colorNegative;            

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void timer_Sensex_Tick(object sender, EventArgs e)
        {
            ShareData data = mci.GetSensex();
            lbl_Val__Sensex.Text = data.Price.ToString();
            lbl_rise_Sensex.Text = data.Rise.ToString() + "  (" + data.ChangePerc.ToString() + " %)";

            pnl_Sensex.BackColor = data.Rise > 0 ? Constants.colorPositive : Constants.colorNegative;

        }

        private void timer_BankNifty_Tick(object sender, EventArgs e)
        {
            ShareData data = mci.GetBankNifty();
            lbl_val_BankNifty.Text = data.Price.ToString();
            lbl_rise_BankNifty.Text = data.Rise.ToString() + "  (" + data.ChangePerc.ToString() + " %)";

            pnl_BankNifty.BackColor = data.Rise > 0 ? Constants.colorPositive : Constants.colorNegative;

        }
    }
}
