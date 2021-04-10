using ScarpLib;
using Scrap.Graphs;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Scrap
{
    public partial class Options : Form
    {
        private DAL dal;

        public Options()
        {
            InitializeComponent();
            dal = new DAL();
        }

        private int year = 0;
        private int month = 0;
        private int day = 0;
        private int time = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            year = dateTimePicker1.Value.Year;
            month = dateTimePicker1.Value.Month;
            day = dateTimePicker1.Value.Day;

            time = Convert.ToInt32(cmbTime.SelectedItem.ToString());
            MessageBox.Show("Running at Interval of " + time + " Minutes \n Expiry " + year + "-" + month + "-" + day);
            time = time * 60 * 1000;

            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = time;
            lblLastExecutedOn.Text = DateTime.Now.ToString();
            BankNiftyOptionController controller = new BankNiftyOptionController();

            List<List<BankNiftyOptions>> options = controller.GetData(year, month, day);
            List<BankNiftyOptions> calls = options[0];
            List<BankNiftyOptions> puts = options[1];

            String op = "";
            int call_openInterest = 0;
            int put_openInterest = 0;

            String query = "";
            DateTime currenttime = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";

            foreach (BankNiftyOptions item in calls)
            {
                op += item.ToString() + "\n\n";
                call_openInterest += item.OpenInterest;

                query = "insert into BankNifty_Calls values('" + currenttime.ToString(format) + "'," + item.Strike + "," + item.Ltp + "," + item.NetChange + "," + item.Volume + "," + item.OpenInterest + "," + item.ChaneInOpenInterest + ")";
                int result = dal.MyExecuteNonQuery(query);
            }

            op = "";
            foreach (BankNiftyOptions item in puts)
            {
                op += item.ToString() + "\n\n";
                put_openInterest += item.OpenInterest;
                query = "insert into BankNifty_Puts values('" + currenttime.ToString(format) + "'," + item.Strike + "," + item.Ltp + "," + item.NetChange + "," + item.Volume + "," + item.OpenInterest + "," + item.ChaneInOpenInterest + ")";
                int result = dal.MyExecuteNonQuery(query);
            }

            lblCallOpenInterest.Text = call_openInterest.ToString();
            lblPutOpenInterest.Text = put_openInterest.ToString();

            if (call_openInterest > put_openInterest)
            {
                lblSignal.Text = "PUT";
            }
            else
            {
                lblSignal.Text = "CALL";
            }
        }

        private void Options_Load(object sender, EventArgs e)
        {
            cmbTime.SelectedIndex = 2;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private async void button3_Click(object sender, EventArgs e)
        {
            List<DateModel> models = new List<DateModel>();

            var data = await HistoricalSharedata.GetBankNifty(DateTime.Now.AddDays(-100), DateTime.Now);
            foreach (var item in data)
            {
                models.Add(new DateModel() { DateTime = item.DateTime, Value = (double)item.Close });
            }

            CustomGridView gv = new CustomGridView(data);
            gv.Show();

            Labels example = new Labels(models);
            example.AutoScaleMode = AutoScaleMode.None;
            example.AutoScaleDimensions = System.Drawing.SizeF.Empty;
            example.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ZedGraphWindow window = new ZedGraphWindow();
            window.Show();
        }
    }
}