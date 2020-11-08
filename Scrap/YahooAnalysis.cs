using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using YahooFinanceApi;

namespace Scrap
{
    public partial class YahooAnalysis : Form
    {
        public YahooAnalysis()
        {
            InitializeComponent();
        }

        private void YahooAnalysis_Load(object sender, EventArgs e)
        {
            String[] lines =  File.ReadAllLines("YahooSymbols.txt");
            foreach (String  line in lines)
            {
                cmbShares.Items.Add(line);
            }

            dateFrom.Value = DateTime.Today.AddDays(-5);
            dateTo.Value = DateTime.Today;
        }

        private async void cmbShares_SelectedIndexChanged(object sender, EventArgs e)
        {
            var history = await Yahoo.GetHistoricalAsync(cmbShares.SelectedItem.ToString(), dateFrom.Value, dateTo.Value, Period.Daily);
            //List<Candle> candles = new List<Candle>();
            //foreach (Candle candle in history)
            //{
            //    //MessageBox.Show($"DateTime: {candle.DateTime}, Open: {candle.Open}, High: {candle.High}, Low: {candle.Low}, Close: {candle.Close}, Volume: {candle.Volume}, AdjustedClose: {candle.AdjustedClose}");

            //}

                dataGridView1.DataSource = history;

                foreach (DataGridViewRow row in dataGridView1.Rows)
                if (Convert.ToDecimal(row.Cells[1].Value) >= Convert.ToDecimal(row.Cells[4].Value))
                {
                    row.DefaultCellStyle.BackColor = Color.LightPink;
                }
                else
                {
                    row.DefaultCellStyle.BackColor = Color.LightGreen;
                }


            dataGridView1.Refresh();



        }


       
    }
}
