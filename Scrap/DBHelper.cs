using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scrap
{
    public class DBHelper
    {
        static DAL dal = new DAL();
        public static void InsertGainer(Gainer gainer)
        {
            String query = "insert into Gainer values('"+gainer.ScrapDate+"','"+gainer.CompanyName+"',"+ gainer.High+","+gainer.Low+","+gainer.LastPrice+","+gainer.PrevClose+","+gainer.Change+","+gainer.Gain+")";
            dal.MyExecuteNonQuery(query);
        }
    }
}
