using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scrap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<String> mainPageLinks = Scrapper.GetMainPageLinks("https://newyork.craigslist.org/d/computer-gigs/search/cpg");
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < mainPageLinks.Count; i++)
            {
                builder.Append(mainPageLinks[i] +"\n");
            }

            richTextBox1.Text = builder.ToString();
        }
    }
}
