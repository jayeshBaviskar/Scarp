using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BSECron.DataAccess;

namespace BSECron.UI
{
    public class SharedClass
    {
        private static DateTime lastDateofDataAvailibility;
        private BSEMSSQLDAL bSEMSSQLDAL;
        private static String selectedStockInGrid;

        public SharedClass()
        {
            bSEMSSQLDAL = new BSEMSSQLDAL();
            LastDateofDataAvailibility = bSEMSSQLDAL.GetMostRecentDateFromDB();

        }

        public static DateTime LastDateofDataAvailibility { get => lastDateofDataAvailibility; set => lastDateofDataAvailibility = value; }
        public static string SelectedStockInGrid { get => selectedStockInGrid; set => selectedStockInGrid = value; }
    }
}
