using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BSECron.UI.CustomCharts
{
    public partial class LineSeriesForm : Form
    {
        List<String> xAxis;
        ChartValues<double> series1;
        ChartValues<double> series2;
        ChartValues<double> series3;
        String series1_title = "AroonUp";
        String series2_title = "AroonDown";
        String series3_title = "Oscillator";


        public LineSeriesForm()
        {
            InitializeComponent();

            xAxis = new List<string>();
            xAxis.Add("Jan");
            xAxis.Add("Feb");
            xAxis.Add("Mar");
            xAxis.Add("Apr");
            xAxis.Add("May");
            xAxis.Add("Jun" );

            series1 = new ChartValues<double> { 3, 4, 6, 3, 2, 6 };
            series2 = new ChartValues<double> { 5, 3, 5, 7, 3, 9 };
            series3 = new ChartValues<double> { 10, 7, 5, 2, 3, 9 };
        }


        public LineSeriesForm(List<String> xAxis, ChartValues<double> series1,ChartValues<double> series2,
            ChartValues<double> series3, String series1_title, String series2_title, String series3_title)
        {
            InitializeComponent();

            this.xAxis = xAxis;
            this.series1 = series1;
            this.series2 = series2;
            this.series3 = series3;

            this.series1_title = series1_title;
            this.series2_title = series2_title;
            this.series3_title = series3_title;
        }
        
        

        private void LineSeriesForm_Load(object sender, EventArgs e)
        {
        }

        private void LineSeriesForm_Load_1(object sender, EventArgs e)
        {
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = series1,
                Title = series1_title,
                StrokeThickness = 1,
                //StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 2 }),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(107, 185, 69)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 0,
                PointGeometrySize = 5
            });
            cartesianChart1.Series.Add(new LineSeries
            {
                Values = series2,
                Title = series2_title,
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(28, 142, 196)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 1,
                PointGeometrySize = 5,
            });

            cartesianChart1.Series.Add(new LineSeries
            {
                Values = series3,
                Title = series3_title,
                StrokeThickness = 1,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)),
                Fill = System.Windows.Media.Brushes.Transparent,
                LineSmoothness = 1,
                PointGeometrySize = 5,
            });

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Month",
                Labels = xAxis
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                IsMerged = true,
                Separator = new Separator
                {
                    StrokeThickness = 1.5,
                    StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 4 }),
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            cartesianChart1.Zoom = ZoomingOptions.X;
        }
    }
}