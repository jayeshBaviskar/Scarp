using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using XTS.Base.Data;
using XTS.Base.Data.TI;
using XTS.FinancialChart;



namespace Scrap.XFinChart
{
    public partial class CandleStick : Form
    {
        public CandleStick()
        {
            InitializeComponent();
        }

        private void CandleStick_Load(object sender, EventArgs e)
        {
            XFinChartControl candleStickChart = new XFinChartControl();
            candleStickChart.OwnerControl = this;
            candleStickChart.Dock = DockStyle.Fill;            
            candleStickChart.Symbol = "ACC";
            candleStickChart.CompressionString = "1 Min";
            this.Controls.Add(candleStickChart);
        }
    }
}
