using HtmlAgilityPack;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ScarpLib
{
    public class BankNiftyOptionController
    {
        private String URL = "https://www.moneycontrol.com/stocks/fno/view_option_chain.php?ind_id=23&sel_exp_date=2020-12-10/";
        //private String URL = "https://www.moneycontrol.com/stocks/fno/view_option_chain.php?ind_id=23&sel_exp_date=";

        private ScrapingBrowser Browser;
        private HtmlAgilityPack.HtmlDocument doc;
        private HtmlWeb web;

        public BankNiftyOptionController()
        {
        }

        public List<List<BankNiftyOptions>> GetData(int year, int month, int date)
        {
            Browser = new ScrapingBrowser();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = true;
            doc = new HtmlAgilityPack.HtmlDocument();
            web = new HtmlWeb();
            // URL += year + "-" + month + "-" + date;
            doc = web.Load(URL);

            List <List<BankNiftyOptions>> lst = new List<List<BankNiftyOptions>>();
            List<BankNiftyOptions> lstCallData = new List<BankNiftyOptions>();
            List<BankNiftyOptions> lstPutData = new List<BankNiftyOptions>();


            Clipboard.SetText(doc.DocumentNode.OuterHtml);

            HtmlNodeCollection tblNodes =  doc.DocumentNode.SelectNodes("//table[@class='tblopt']");

            HtmlNodeCollection nodes = tblNodes[1].SelectNodes("tr");

            foreach (HtmlNode tr in nodes)
            {
                BankNiftyOptions call = new BankNiftyOptions();
                BankNiftyOptions put = new BankNiftyOptions();

                
                HtmlNodeCollection tds = tr.SelectNodes("td");

                if (float.TryParse(tds[0].InnerText.Replace(",",""), out float ltp))
                {
                    call.Ltp = ltp;
                }
                else
                {
                    call.Ltp = 0;
                }

                if (float.TryParse(tds[1].InnerText.Replace(",", ""), out float netChange))
                {
                    call.NetChange = netChange;
                }
                else
                {
                    call.NetChange = 0;
                }

                if (int.TryParse(tds[2].InnerText.Replace(",", ""), out int volumne))
                {
                    call.Volume = volumne;
                }
                else
                {
                    call.Volume = 0;
                }

                if (int.TryParse(tds[3].InnerText.Replace(",", ""), out int openInt))
                {
                    call.OpenInterest = openInt;
                }
                else
                {
                    call.OpenInterest = 0;
                }

                if (int.TryParse(tds[4].InnerText.Replace(",", ""), out int changeInOpenInterest))
                {
                    call.ChaneInOpenInterest = changeInOpenInterest;
                }
                else
                {
                    call.ChaneInOpenInterest = 0;
                }

                if (int.TryParse(tds[5].InnerText.Replace(",","").Replace(".00",""), out int strike))
                {
                    call.Strike = strike;
                    put.Strike = strike;
                }
                else
                {
                    throw new Exception();
                }

                if (float.TryParse(tds[6].InnerText.Replace(",", ""), out float p_ltp))
                {
                    put.Ltp = p_ltp;
                }
                else
                {
                    put.Ltp = 0;
                }

                if (float.TryParse(tds[7].InnerText.Replace(",", ""), out float p_netChange))
                {
                    put.NetChange = p_netChange;
                }
                else
                {
                    put.NetChange = 0;
                }

                if (int.TryParse(tds[8].InnerText.Replace(",", ""), out int p_volumne))
                {
                    put.Volume = p_volumne;
                }
                else
                {
                    put.Volume = 0;
                }

                if (int.TryParse(tds[9].InnerText.Replace(",", ""), out int p_openInt))
                {
                    put.OpenInterest = p_openInt;
                }
                else
                {
                    put.OpenInterest = 0;
                }

                if (int.TryParse(tds[10].InnerText.Replace(",", ""), out int p_changeInOpenInterest))
                {
                    put.ChaneInOpenInterest = p_changeInOpenInterest;
                }
                else
                {
                    put.ChaneInOpenInterest = 0;
                }

                lstCallData.Add(call);
                lstPutData.Add(put);
            }

            lst.Add(lstCallData);
            lst.Add(lstPutData);
            return lst;
        }
    }
}