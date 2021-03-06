﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS0105 // The using directive for 'System.Collections.Generic' appeared previously in this namespace
using System.Collections.Generic;
#pragma warning restore CS0105 // The using directive for 'System.Collections.Generic' appeared previously in this namespace
using HtmlAgilityPack;
using ScrapySharp.Extensions;
using ScrapySharp.Network;

namespace Scrap
{


    public class Scrapper
    {
        static ScrapingBrowser _browser = new ScrapingBrowser();
        public static HtmlNode GetHtml(string url)
        {
            WebPage webpage = _browser.NavigateToPage(new Uri(url));
            return webpage.Html;
        }

        public static List<string> GetMainPageLinks(string url)
        {
            var homePageLinks = new List<string>();
            HtmlNode html = GetHtml(url);
            IEnumerable<HtmlNode> links = html.CssSelect("a");

            foreach (var link in links)
            {
                if (link.Attributes["href"].Value.Contains(".html"))
                {
                    homePageLinks.Add(link.Attributes["href"].Value);
                }
            }
            return homePageLinks;
        }
    }
}
