using System;
using System.Collections.Generic;
using System.Drawing;
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
        char day1 = '-';
        char day2 = '-';
        char day3 = '-';
        char day4 = '-';
        char day5 = '-';


        public DateTime ScrapDate { get => scrapDate; set => scrapDate = value; }
        public string CompanyName { get => companyName; set => companyName = value; }
        public float High { get => high; set => high = value; }
        public float Low { get => low; set => low = value; }
        public float LastPrice { get => lastPrice; set => lastPrice = value; }
        public float PrevClose { get => prevClose; set => prevClose = value; }
        public float Change { get => change; set => change = value; }
        public float Gain { get => gain; set => gain = value; }
        public char Day1 { get => day1; set => day1 = value; }
        public char Day2 { get => day2; set => day2 = value; }
        public char  Day3 { get => day3; set => day3 = value; }
        public char Day4 { get => day4; set => day4 = value; }
        public char Day5 { get => day5; set => day5 = value; }
    }
}
