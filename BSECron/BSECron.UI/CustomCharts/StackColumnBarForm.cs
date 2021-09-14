using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BSECron.UI.CustomCharts
{
    public partial class StackColumnBarForm : Form
    {
        private ChartValues<double> series1;
        private ChartValues<double> series2;
        private List<string> XAxisLabels;

        public StackColumnBarForm()
        {
            InitializeComponent();
        }

        public StackColumnBarForm(ChartValues<double> series1, ChartValues<double> series2, List<string> XAxisLabels)
        {
            InitializeComponent();

            this.series1 = series1;
            this.series2 = series2;
            this.XAxisLabels = XAxisLabels;
        }

        private void StackColumnBarForm_Load(object sender, EventArgs e)
        {
            cartesianChart1.Series = new SeriesCollection
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

            cartesianChart1.AxisX.Add(new Axis
            {
                Title = "Bull and Bear Power",
                Labels = XAxisLabels,
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
    }
}