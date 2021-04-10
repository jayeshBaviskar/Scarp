using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using YahooFinanceApi;

namespace ScarpLib
{
    public class HistoricalSharedata
    {
        public static async Task<IReadOnlyList<Candle>> GetBankNifty(DateTime dateFrom, DateTime dateTo)
        {
            var history = await Yahoo.GetHistoricalAsync("^NSEBANK", dateFrom, dateTo, Period.Daily);

            return history;
        }
    }
}