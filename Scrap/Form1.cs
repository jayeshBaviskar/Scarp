using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;
using YahooFinanceApi;

namespace Scrap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String URL = "http://letscode.in/";
            List<String> lst = Scrapper.GetMainPageLinks(URL);
            foreach (var item in lst)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MoneyControl obj = new MoneyControl();
            obj.Gainers(dataGridView1, lblLogs, false);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MoneyControl obj = new MoneyControl();
            obj.Gainers(dataGridView1, lblLogs, true);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DAL dal = new DAL();
            String query = "select distinct(companyName) from gainer";
            SqlDataReader dr =  dal.MyExecuteReader(query);
            cmbCompanies.Items.Clear();
            while (dr.Read())
            {
                cmbCompanies.Items.Add(dr.GetString(0));
            }
            dal.CloseConnection();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // MessageBox.Show(cmbCompanies.Items.Count.ToString());
            var query = "SELECT * FROM gainer where companyname like '"+cmbCompanies.SelectedItem.ToString()+"' ";

            DAL dal = new DAL();
            DataAdapter dataAdapter =  dal.getAdapter(query);

            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void button4_Click(object sender, EventArgs e)
        {
            News news = new News(cmbCompanies.SelectedItem.ToString());
            news.ShowDialog();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private async void button5_Click(object sender, EventArgs e)
        {
            //// You could query multiple symbols with multiple fields through the following steps:
            //var securities = await Yahoo.Symbols("ACC", "GOOG").Fields(Field.Symbol, Field.RegularMarketPrice, Field.FiftyTwoWeekHigh).QueryAsync();
            //var aapl = securities["ACC"];
            //var price = aapl[Field.RegularMarketPreviousClose];


            var history = await Yahoo.GetHistoricalAsync("RELIANCE.NS", new DateTime(2020, 11, 1), new DateTime(2020, 11, 6), Period.Daily);

            foreach (var candle in history)
            {
                MessageBox.Show($"DateTime: {candle.DateTime}, Open: {candle.Open}, High: {candle.High}, Low: {candle.Low}, Close: {candle.Close}, Volume: {candle.Volume}, AdjustedClose: {candle.AdjustedClose}");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            YahooAnalysis yahooAnalysis = new YahooAnalysis();
            yahooAnalysis.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Options opt = new Options();
            opt.Show();
        }
    }
}