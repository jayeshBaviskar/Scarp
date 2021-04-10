using HtmlAgilityPack;
using ScrapySharp.Network;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ScarpLib
{
    public class MoneyControlIndices
    {
        private String path_Nifty50 = "/html/body/section[2]/div/div[1]/div[2]/div[1]/div/div[1]/div[1]/table/tbody/tr[1]/td[2]";
        private String path_Sensex = "/html/body/section[2]/div/div[1]/div[2]/div[1]/div/div[1]/div[1]/table/tbody/tr[2]/td[2]";
        private String path_BankNifty = "/html/body/section[2]/div/div[1]/div[2]/div[1]/div/div[1]/div[1]/table/tbody/tr[3]/td[2]";
        private String URL = "";
        private ScrapingBrowser Browser;
        private HtmlAgilityPack.HtmlDocument doc;
        private HtmlWeb web;

        public MoneyControlIndices()
        {
            URL = "https://www.moneycontrol.com/stocksmarketsindia/";
            Browser = new ScrapingBrowser();
            Browser.AllowAutoRedirect = true;
            Browser.AllowMetaRedirect = true;

            doc = new HtmlAgilityPack.HtmlDocument();
            web = new HtmlWeb();
            doc = web.Load(URL);
        }

        private ShareData dataNifty50 = new ShareData();
        private ShareData dataSensex = new ShareData();
        private ShareData dataBankNifty = new ShareData();

        public ShareData GetNifty50()
        {
            HtmlNode node = doc.DocumentNode.SelectSingleNode(path_Nifty50);

            IEnumerable<HtmlNode> nodes = node.ParentNode.SelectNodes("td");
            dataNifty50.Price = Convert.ToDouble(nodes.ElementAt(1).InnerText.Trim());
            dataNifty50.Rise = Convert.ToDouble(nodes.ElementAt(2).InnerText.Trim());
            dataNifty50.ChangePerc = Convert.ToDouble(nodes.ElementAt(3).InnerText.Trim());

            return dataNifty50;
        }

        public ShareData GetSensex()
        {
            HtmlNode node = doc.DocumentNode.SelectSingleNode(path_Sensex);

            IEnumerable<HtmlNode> nodes = node.ParentNode.SelectNodes("td");
            dataSensex.Price = Convert.ToDouble(nodes.ElementAt(1).InnerText.Trim());
            dataSensex.Rise = Convert.ToDouble(nodes.ElementAt(2).InnerText.Trim());
            dataSensex.ChangePerc = Convert.ToDouble(nodes.ElementAt(3).InnerText.Trim());

            return dataSensex;
        }

        public ShareData GetBankNifty()
        {
            HtmlNode node = doc.DocumentNode.SelectSingleNode(path_BankNifty);

            IEnumerable<HtmlNode> nodes = node.ParentNode.SelectNodes("td");
            dataBankNifty.Price = Convert.ToDouble(nodes.ElementAt(1).InnerText.Trim());
            dataBankNifty.Rise = Convert.ToDouble(nodes.ElementAt(2).InnerText.Trim());
            dataBankNifty.ChangePerc = Convert.ToDouble(nodes.ElementAt(3).InnerText.Trim());

            return dataBankNifty;
        }
    }
}