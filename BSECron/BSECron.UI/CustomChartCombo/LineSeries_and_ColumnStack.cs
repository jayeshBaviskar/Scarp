using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSECron.UI.CustomChartCombo
{
    public partial class LineSeries_and_ColumnStack : Form
    {
        public LineSeries_and_ColumnStack()
        {
            InitializeComponent();
        }

        private ChartValues<double> series1;
        private ChartValues<double> series2;
        private List<string> XAxisLabels;

        private ChartValues<double> series1_line;
        private ChartValues<double> series2_line;
        private List<string> XAxisLabels_line;

        public LineSeries_and_ColumnStack(ChartValues<double> series1, ChartValues<double> series2, List<string> XAxisLabels,
            ChartValues<double> series1_line, ChartValues<double> series2_line, List<string> XAxisLabels_line, String windowText)
        {
            InitializeComponent();

            this.Text = windowText;

            this.series1 = series1;
            this.series2 = series2;
            this.XAxisLabels = XAxisLabels;

            this.series1_line = series1_line;
            this.series2_line = series2_line;
            this.XAxisLabels_line = XAxisLabels_line;

        }
        private void LineSeries_and_ColumnStack_Load(object sender, EventArgs e)
        {
            ResizeControls();
            DrawbarChart();
            DrawLineChart();

        }

        private void DrawLineChart()
        {

         


            cartesianChart1.Series.Add(new LineSeries//StackedAreaSeries
            {
                Values = series2_line,
                Title = "Close Price",
                StrokeThickness = 1,
                //StrokeDashArray = new System.Windows.Media.DoubleCollection(new double[] { 2 }),
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 0, 0)),
                //Fill = System.Windows.Media.Brushes.LightCyan,
                LineSmoothness = 0,
                Opacity = 50,
                PointGeometrySize = 2,
                
            });

            cartesianChart1.Series.Add(new LineSeries
            {
                Values = series1_line,
                Title = "EMA",
                StrokeThickness = 2,
                Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)),
                //Fill = System.Windows.Media.Brushes.LightBlue,
                LineSmoothness = 1,
                PointGeometrySize = 2,
            });

            cartesianChart1.AxisX.Add(new Axis
            {
                Labels = XAxisLabels_line,
                 Separator = new Separator
                 {
                     StrokeThickness = 0.5,
                     Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                 }
            });

            cartesianChart1.AxisY.Add(new Axis
            {
                Separator = new Separator
                {
                    StrokeThickness = 0.5,
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            cartesianChart1.Zoom = ZoomingOptions.X;
        }


        private void DrawbarChart()
        {
            cartesianChart2.Series = new SeriesCollection
                {
                    new StackedColumnSeries
                    {
                        Values = series1,
                        Title="Bull",
                        Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0, 255, 0)),
                        StackMode = StackMode.Values, // this is not necessary, values is the default stack mode
                        DataLabels = false
                    },
                    new StackedColumnSeries
                    {
                        Values = series2,
                        Title = "Bear",
                        Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(255, 0, 0)),
                        StackMode = StackMode.Values,
                        DataLabels = false
                    }
                };

            cartesianChart2.AxisX.Add(new Axis
            {
                Title = "Bull and Bear Power",
                Labels = XAxisLabels,
                Separator = new Separator
                {
                    StrokeThickness = 0.5,
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });

            cartesianChart2.AxisY.Add(new Axis
            {
                Separator = new Separator
                {
                    StrokeThickness = 0.5,
                    Stroke = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(64, 79, 86))
                }
            });
            cartesianChart2.Zoom = ZoomingOptions.X;
        }
        private void ResizeControls()
        {
            panel1.Width = this.Width;
            panel2.Width = this.Width;

            panel1.Height = (this.Height) - (this.Height / 3) - 10;
            panel2.Height = (this.Height / 3);

            panel1.Location = new Point(0, 0);
            panel2.Location = new Point(0, panel1.Height + 5);

        }
        private void LineSeries_and_ColumnStack_Resize(object sender, EventArgs e)
        {
            ResizeControls();
        }
    }
}
