using BSECron.DataAccess;
using LiveCharts;
using Skender.Stock.Indicators;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
            dateToPicker.Value = bSEMSSQLDAL.GetMostRecentDateFromDB();

            foreach (var item in ViewModelsSamples.Index.Samples)
            {
                _ = listBox1.Items.Add(item);
            }
        }

        IEnumerable<Quote> quotes = null;
        private void button1_Click(object sender, EventArgs e)
        {
            if(quotes == null)
            {
                quotes = bSEMSSQLDAL.GetHistoricalQuotes(comboBox1.Text, dateFromPicker.Value, dateToPicker.Value);
            }
            
            int lookbackPeriods = 25;
            IEnumerable<AroonResult> result  = quotes.GetAroon(lookbackPeriods);

            List<String> xAxis = new List<string>();
            ChartValues<double> series1 = new ChartValues<double>();
            ChartValues<double> series2 = new ChartValues<double>();
            ChartValues<double> series3 = new ChartValues<double>();

            foreach (AroonResult item in result)
            {
                if(item.AroonDown != null && item.AroonDown != null)
                {
                    xAxis.Add(item.Date.ToShortDateString());
                    series1.Add((double) item.AroonUp);
                    series2.Add((double)item.AroonDown);
                    series3.Add((double)item.Oscillator);
                }
            }

            

            BSECron.UI.CustomCharts.LineSeriesForm chart = new CustomCharts.LineSeriesForm(xAxis, series1, series2, series3, 
                "AroonUp" , "AroonDown", "Oscillator");
            chart.ShowDialog();

        }


        private void comboBox1_TextChanged(object sender, EventArgs e)
        { }

        private void Indicators_Home_Load_1(object sender, EventArgs e)
        { }

        private void button2_Click(object sender, EventArgs e)
        {
            if (quotes == null)
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
    }
}