using System;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Scrap.Graphs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateGraph_JapaneseCandleStick(zedGraphControl1);
        }

        private static void CreateGraph_JapaneseCandleStick(ZedGraphControl z1)
        {
            GraphPane myPane = z1.GraphPane;

            myPane.Title.Text = "Japanese Candlestick Chart Demo";
            myPane.XAxis.Title.Text = "Trading Date";
            myPane.YAxis.Title.Text = "Share Price, $US";

            StockPointList spl = new StockPointList();
            Random rand = new Random();

            // First day is feb 1st
            XDate xDate = new XDate(2006, 2, 1);
            double open = 50.0;

            for (int i = 0; i < 100; i++)
            {
                double x = xDate.XLDate;
                double close = open + rand.NextDouble() * 10.0 - 5.0;
                double hi = Math.Max(open, close) + rand.NextDouble() * 5.0;
                double low = Math.Min(open, close) - rand.NextDouble() * 5.0;

                StockPt pt = new StockPt(x, hi, low, open, close, 1);
                spl.Add(pt);

                open = close;
                // Advance one day
                xDate.AddDays(1.0);
                // but skip the weekends
                if (XDate.XLDateToDayOfWeek(xDate.XLDate) == 6)
                    xDate.AddDays(2.0);
            }

            //CandleStickItem myCurve = myPane.AddCandleStick( "trades", spl, Color.Black );
            JapaneseCandleStickItem myCurve = myPane.AddJapaneseCandleStick("trades", spl);
            myCurve.Stick.IsAutoSize = true;
            myCurve.Stick.Color = Color.Blue;

            // Use DateAsOrdinal to skip weekend gaps
            myPane.XAxis.Type = AxisType.DateAsOrdinal;

            // pretty it up a little
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);
            myPane.Fill = new Fill(Color.White, Color.FromArgb(220, 220, 255), 45.0f);

            // Tell ZedGraph to calculate the axis ranges
            z1.AxisChange();
            z1.Invalidate();
        }
    }
}