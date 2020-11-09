using System;

namespace YahooFinanceApi
{
    public class Candle: ITick
    {
        public DateTime DateTime { get; internal set; }

        public decimal Open { get; internal set; }

        public decimal High { get; internal set; }

        public decimal Low { get; internal set; }

        public decimal Close { get; internal set; }

        public long Volume { get; internal set; }

        public decimal AdjustedClose { get; internal set; }

        decimal change;
        decimal changePercentage;

        public decimal Change { get => (Close - Open); }
        public decimal ChangePercentage { get => Open==0? 0:Decimal.Round((((Close - Open) * 100) / Open),2); }
    }
}
