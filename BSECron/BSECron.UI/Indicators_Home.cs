using BSECron.DataAccess;
using BSECron.UI.CustomChartCombo;
using LiveCharts;
using Skender.Stock.Indicators;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BSECron.UI
{
    public partial class Indicators_Home : Form
    {
        private BSEMSSQLDAL bSEMSSQLDAL;

        public Indicators_Home()
        {
            InitializeComponent();
            bSEMSSQLDAL = new BSEMSSQLDAL();
        }

        private void Indicators_Home_Load(object sender, EventArgs e)
        {
            foreach (String str in File.ReadAllLines("Symbols.Config"))
            {
                comboBox1.Items.Add(str);
            }

            dateFromPicker.Value = new DateTime(2021, 01, 01);
            dateToPicker.Value = SharedClass.LastDateofDataAvailibility; // bSEMSSQLDAL.GetMostRecentDateFromDB();
            comboBox1.Text = SharedClass.SelectedStockInGrid;

    //foreach (var item in ViewModelsSamples.Index.Samples)
    //{
    //    _ = listBox1.Items.Add(item);
    //}
}

        private IEnumerable<Quote> quotes = null;

        private void button1_Click(object sender, EventArgs e)
        {
            if (quotes == null)
            {
                quotes = bSEMSSQLDAL.GetHistoricalQuotes(comboBox1.Text, dateFromPicker.Value, dateToPicker.Value);
            }

            int lookbackPeriods = 25;
            IEnumerable<AroonResult> result = quotes.GetAroon(lookbackPeriods);

            List<String> xAxis = new List<string>();
            ChartValues<double> series1 = new ChartValues<double>();
            ChartValues<double> series2 = new ChartValues<double>();
            ChartValues<double> series3 = new ChartValues<double>();

            foreach (AroonResult item in result)
            {
                if (item.AroonDown != null && item.AroonDown != null)
                {
                    xAxis.Add(item.Date.ToShortDateString());
                    series1.Add((double)item.AroonUp);
                    series2.Add((double)item.AroonDown);
                    series3.Add((double)item.Oscillator);
                }
            }

            BSECron.UI.CustomCharts.LineSeriesForm chart = new CustomCharts.LineSeriesForm(xAxis, series1, series2, series3,
                "AroonUp", "AroonDown", "Oscillator");
            chart.ShowDialog();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        { }

        private void Indicators_Home_Load_1(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            if (quotes == null || ((List<Quote>)quotes).Count == 0)
            {
                quotes = bSEMSSQLDAL.GetHistoricalQuotes(comboBox1.Text, dateFromPicker.Value, dateToPicker.Value);
            }

            int lookbackPeriods = 14;
            IEnumerable<AdxResult> result = quotes.GetAdx(lookbackPeriods);

            List<String> xAxis = new List<string>();
            ChartValues<double> series1 = new ChartValues<double>();
            ChartValues<double> series2 = new ChartValues<double>();
            ChartValues<double> series3 = new ChartValues<double>();

            foreach (AdxResult item in result)
            {
                if (item.Adx != null)
                {
                    xAxis.Add(item.Date.ToShortDateString());
                    series1.Add((double)item.Adx);
                    series2.Add((double)item.Mdi);
                    series3.Add((double)item.Pdi);
                }
            }

            BSECron.UI.CustomCharts.LineSeriesForm chart = new CustomCharts.LineSeriesForm(xAxis, series1, series2, series3,
                "Adx", "Mdi", "Pdi");
            chart.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            quotes = bSEMSSQLDAL.GetHistoricalQuotes(comboBox1.Text, dateFromPicker.Value, dateToPicker.Value);
            
            int lookbackPeriods = 13;
            IEnumerable<ElderRayResult> results = quotes.GetElderRay(lookbackPeriods);

            List<String> xAxis = new List<string>();
            ChartValues<double> series1 = new ChartValues<double>();
            ChartValues<double> series2 = new ChartValues<double>();

            ChartValues<double> series1_line = new ChartValues<double>();
            ChartValues<double> series2_line = new ChartValues<double>();
            int count = 0;
            List<Quote> q = (List<Quote>)quotes;

            foreach (ElderRayResult item in results)
            {
                if (item.Ema != null)
                {
                    xAxis.Add(item.Date.ToShortDateString());
                    series1.Add(Math.Round((double)item.BullPower, 2));
                    series2.Add(Math.Round((double)item.BearPower, 2));

                    series1_line.Add(Math.Round((double)item.Ema, 2));
                    series2_line.Add(Math.Round((double)q[count].Close, 2));
                }

                ++count;
            }

            LineSeries_and_ColumnStack frm = new LineSeries_and_ColumnStack(series1, series2, xAxis,
                series1_line, series2_line, xAxis, comboBox1.Text + " -  Elder-ray Index");
            // StackColumnBarForm frm = new StackColumnBarForm(series1, series2, xAxis);
            frm.ShowDialog();
        }

        private int total = 0;
        private int current = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;

            int lookbackPeriods = 13;
            IEnumerable<ElderRayResult> results;
            StringBuilder builder = new StringBuilder();
            builder.Append("Symbol,EMA,Close_Price,Rating");
            builder.Append("\n");

            total = comboBox1.Items.Count;
            current = 0;

            foreach (String symbol in File.ReadAllLines("Symbols.Config"))
            {
                quotes = bSEMSSQLDAL.GetHistoricalQuotes(symbol, dateFromPicker.Value, dateToPicker.Value);
                List<Quote> q = (List<Quote>)quotes;

                if (q.Count <= 115)
                {
                    ++current;
                    lblStatus.Text = current.ToString() + " of " + total;
                    
                    continue;
                }

                results = quotes.GetElderRay(lookbackPeriods);

                if (results.Last().Ema > (quotes.Last().Close + (quotes.Last().Close / 20)))
                {
                    builder.Append(symbol + "," + results.Last().Ema + "," + quotes.Last().Close + "," + "Strong Buy");
                    builder.Append("\n");
                }
                else if (results.Last().Ema > (quotes.Last().Close))
                {
                    builder.Append(symbol + "," + results.Last().Ema + "," + quotes.Last().Close + "," + "Buy");
                    builder.Append("\n");
                }
                else if ((quotes.Last().Close) > results.Last().Ema + (results.Last().Ema / 20))
                {
                    builder.Append(symbol + "," + results.Last().Ema + "," + quotes.Last().Close + "," + "Strong Sell");
                    builder.Append("\n");
                }
                else if ((quotes.Last().Close) > results.Last().Ema)
                {
                    builder.Append(symbol + "," + results.Last().Ema + "," + quotes.Last().Close + "," + "Sell");
                    builder.Append("\n");
                }
                else
                {
                    builder.Append(symbol + "," + results.Last().Ema + "," + quotes.Last().Close + "," + "Neutral");
                    builder.Append("\n");
                }
                ++current;
                lblStatus.Text = current.ToString() + " of " + total;
            }

            File.WriteAllText("EMA.csv", builder.ToString());
            lblStatus.Text = "File Write Completed";
        }
    }
}
