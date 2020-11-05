using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrap
{
    public class Gainer
    {
        DateTime scrapDate;
        String companyName;
        float high;
        float low;
        float lastPrice;
        float prevClose;
        float change;
        float gain;

        public DateTime ScrapDate { get => scrapDate; set => scrapDate = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public float High { get => high; set => high = value; }
        public float Low { get => low; set => low = value; }
        public float LastPrice { get => lastPrice; set => lastPrice = value; }
        public float PrevClose { get => prevClose; set => prevClose = value; }
        public float Change { get => change; set => change = value; }
        public float Gain { get => gain; set => gain = value; }
    }
}
