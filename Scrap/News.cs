using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;
using HtmlAgilityPack;

namespace Scrap
{
    public partial class News : Form
    {
        private string GS = "";

        public News(String shareName)
        {
            InitializeComponent();

            StringBuilder sb = new StringBuilder();

            // used on each read operation
            byte[] buf = new byte[8192];
            GS = "https://news.google.com/news/rss/search/section/q/" + shareName + " BSE Share";
            // prepare the web page we will be asking for
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(GS);

            // execute the request
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            // we will read data via the response stream
            Stream resStream = response.GetResponseStream();
            string tempString = null;
            int count = 0;
            do
            {
                // fill the buffer with data
                count = resStream.Read(buf, 0, buf.Length);
                // make sure we read some data
                if (count != 0)
                {
                    // translate from bytes to ASCII text
                    tempString = Encoding.ASCII.GetString(buf, 0, count);

                    // continue building the string
                    sb.Append(tempString + "\n");
                }
            }
            while (count > 0);
            richTextBox1.Text = sb.ToString();
        }

        private void News_Load(object sender, EventArgs e)
        {
            RSS();
        }

        private void RSS()
        {
            XDocument feedXML = XDocument.Load(GS);

            IEnumerable<XElement> feeds = feedXML.Descendants("item");
            List<RSS> listRss = new List<RSS>();
            foreach (var item in feeds)
            {
                RSS rss = new RSS();

                rss.Title = item.Element("title").Value;
                rss.Description= ParseHmlBody(item.Element("description").Value);
                //rss.Description = item.Element("description").Value;

                listRss.Add(rss);
                //gainer.ScrapDate = DateTime.ParseExact(strDate, "dd MMM HH:mm", CultureInfo.InvariantCulture);
            }

            //var feeds = from feed in feedXML.Descendants("item")
            //            select new
            //            {
            //                Title = feed.Element("title").Value,
            //                Link = feed.Element("link").Value,
            //                Description = feed.Element("description").Value,
            //                PublishedOn  = feed.Element("pubDate").Value
            //            };

            dataGridView1.DataSource = listRss;            
            dataGridView1.AutoResizeColumns();
            dataGridView1.Refresh();

       
        }

        private string ParseHmlBody(string html)
        {
            string body = string.Empty;
            try
            {
                var htmlDoc = new HtmlAgilityPack.HtmlDocument();
                htmlDoc.LoadHtml(html);
                var htmlBody = htmlDoc.DocumentNode;
                body = htmlBody.InnerText;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in ParseHmlBody" + ex.Message);
            }
            return body;
        }
    }
}