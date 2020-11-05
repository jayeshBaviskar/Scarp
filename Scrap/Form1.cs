using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using HtmlAgilityPack;

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
            String URL = "http://letscode.in/";
            List<String> lst =  Scrapper.GetMainPageLinks(URL);
            foreach (var item in lst)
            {
                MessageBox.Show(item.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HtmlScrapping obj = new HtmlScrapping();
           richTextBox1.Text =   obj.MoneyControl();


        }
    }
}
