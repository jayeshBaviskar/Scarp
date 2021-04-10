using System;
using System.Collections.Generic;
using System.Windows.Forms;
using YahooFinanceApi;

namespace Scrap
{
    public partial class CustomGridView : Form
    {
        IReadOnlyList<Candle> obj;
        public CustomGridView(IReadOnlyList<Candle> obj)
        {
            InitializeComponent();
            this.obj = obj;
          
        }

        private void CustomGridView_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = obj;
            dataGridView1.Refresh();
        }

        private void CustomGridView_Resize(object sender, EventArgs e)
        {
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}