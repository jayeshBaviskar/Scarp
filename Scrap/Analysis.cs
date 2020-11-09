using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrap
{
    public class Analysis
    {
        String share;
        decimal gainer;
        decimal looser;
        decimal totalAmountGained;
        decimal totalPercentage;
        decimal low;
        decimal current;
        decimal high;

        public string Share { get => share; set => share = value; }
        public decimal Gainer { get => gainer; set => gainer = value; }
        public decimal Looser { get => looser; set => looser = value; }
        public decimal TotalAmountGained { get => totalAmountGained; set => totalAmountGained = value; }
        public decimal TotalPercentage { get => totalPercentage; set => totalPercentage = value; }
        public decimal High { get => high; set => high = value; }
        public decimal Low { get => low; set => low = value; }
        public decimal Current { get => current; set => current = value; }
    }
}
