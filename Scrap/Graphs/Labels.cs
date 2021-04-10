using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using ScarpLib;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Scrap.Graphs
{
    
    public partial class Labels : Form
    {
        private List<DateModel> models;

        [DllImport("shcore.dll")]
        private static extern int SetProcessDpiAwareness(_Process_DPI_Awareness value);

        private enum _Process_DPI_Awareness
        {
            Process_DPI_Unaware = 0,
            Process_System_DPI_Aware = 1,
            Process_Per_Monitor_DPI_Aware = 2
        }

        public Labels(List<DateModel> models)
        {
            InitializeComponent();
            this.models = models;

            // High resolution monitor
            SetProcessDpiAwareness(_Process_DPI_Awareness.Process_DPI_Unaware);
        }

        private void Labels_Load(object sender, EventArgs e)
        {
            ColumnSeries series = new ColumnSeries();

            ChartValues<ObservableValue> cvalues = new ChartValues<ObservableValue>();

            List<String> labels = new List<string>();
            foreach (var item in models)
            {
                if (item.Value > 0)
                {
                    cvalues.Add(new ObservableValue(item.Value));
                    labels.Add(item.DateTime.ToString("d"));
                }
            }

            series.Values = cvalues;
            series.DataLabels = false;
            series.LabelPoint = point => point.Y + "";
            series.MinHeight = 1000;
            series.Title = "Bank Nifty";

            cartesianChart1.Series.Add(series);

            Axis axis = new Axis();
            axis.Labels = labels;
            axis.LabelsRotation = 5;

            cartesianChart1.AutoSize = false;

            cartesianChart1.AxisX.Add(axis);

            cartesianChart1.AxisY.Add(new Axis
            {
                LabelFormatter = value => (value + 100).ToString(),

                Separator = new Separator()
            });
        }
    }
}