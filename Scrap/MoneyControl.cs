using HtmlAgilityPack;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace Scrap
{
    internal class MoneyControl
    {
        private DAL dal = new DAL();
        List<Gainer> gainers;

        public String Gainers(DataGridView dg, System.Windows.Forms.Label lbl,  bool isDisplay = false)
        {
            gainers = new List<Gainer>();
            String str = "";
            String URL = "https://www.moneycontrol.com/stocks/marketstats/bse-gainer/bse-500_12/";
            ScrapingBrowser Browser = new ScrapingBrowser();
            Browser.AllowAutoRedirect = true; // Browser has many settings you can access in setup
            Browser.AllowMetaRedirect = true;

            //WebPage PageResult = Browser.NavigateToPage(new Uri(URL));

            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            HtmlWeb web = new HtmlWeb();
            doc = web.Load(URL);
            //doc.LoadHtml(URL);
            HtmlNode div = doc.GetElementbyId("data_table_ajax_loading");

           

            String rootTable = "/html/body/section/section/section/div[1]/div[2]/div/div/div[2]/table/tbody";

            String root_LastFivePerfomance = "/html/body/section/section/section/div[1]/div[2]/div/div/div[2]/table/tbody/tr[1]/td[15]";


            HtmlNode rootNode = div.SelectSingleNode(rootTable);

            // TO REMOVE
            HtmlNode lastFiveDays = div.SelectSingleNode(root_LastFivePerfomance);
            IEnumerable<HtmlNode> lastNodes =  lastFiveDays.SelectNodes("div");


            HtmlNode dateField =  div.SelectSingleNode("/html/body/section/section/div[2]/span");
            String strDate = dateField.InnerText.Replace("|", "").Trim();

            IEnumerable <HtmlNode> trs = rootNode.SelectNodes("tr");

            String shareNamePath = rootTable + "/tr[1]/td[1]/span/a";

            int count = 1;
            foreach (HtmlNode tr in trs)
            {
                Gainer gainer = new Gainer();                
                gainer.ScrapDate = DateTime.ParseExact(strDate, "dd MMM HH:mm", CultureInfo.InvariantCulture);
                

                IEnumerable<HtmlNode> tds = tr.SelectNodes("descendant::td");

                for (int i = 0; i < 7; ++i)
                {
                    if (i == 0)  // First Element
                    {
                        gainer.CompanyName = tr.SelectSingleNode("td[1]/span/a").InnerText;
                        str += count + "\t" + gainer.CompanyName;
                    }
                    else
                    {
                        switch (i)
                        {
                            case 1:
                                gainer.High = (float)Convert.ToDouble(tds.ElementAt(i).InnerText.Trim());
                                break;

                            case 2:
                                gainer.Low = (float)Convert.ToDouble(tds.ElementAt(i).InnerText.Trim());
                                break;

                            case 3:
                                gainer.LastPrice = (float)Convert.ToDouble(tds.ElementAt(i).InnerText.Trim());
                                break;

                            case 4:
                                gainer.PrevClose = (float)Convert.ToDouble(tds.ElementAt(i).InnerText.Trim());
                                break;

                            case 5:
                                gainer.Change = (float)Convert.ToDouble(tds.ElementAt(i).InnerText.Trim());
                                break;

                            case 6:
                                gainer.Gain = (float)Convert.ToDouble(tds.ElementAt(i).InnerText.Trim());
                                break;

                            default:
                                break;
                        }

                        str += "\t" + tds.ElementAt(i).InnerText;
                       
                    }
                }
                if(isDisplay == false)
                {
                    DBHelper.InsertGainer(gainer);
                }
                
                gainers.Add(gainer);
             
                
                str += "\n";
            }

            dg.DataSource = gainers;
            dg.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dg.AutoResizeColumns();
            dg.Refresh();
            lbl.Text = "Total Gainers: " + gainers.Count;
            return str;
        }


    }
}