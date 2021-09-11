using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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


            String query = "insert into gainer values (@dt, @company, @high, @low, @lastprice, @prevclose, @change, @gain)";
           
            SqlCommand command = new SqlCommand(query, dal.returnConnection());
            
            command.Parameters.Add("@dt", SqlDbType.DateTime);
            command.Parameters["@dt"].Value = gainer.ScrapDate;

            command.Parameters.Add("@company", SqlDbType.VarChar);
            command.Parameters["@company"].Value = gainer.CompanyName;

            command.Parameters.Add("@high", SqlDbType.Float);
            command.Parameters["@high"].Value = gainer.High;

            command.Parameters.Add("@low", SqlDbType.Float);
            command.Parameters["@low"].Value = gainer.Low;

            command.Parameters.Add("@lastprice", SqlDbType.Float);
            command.Parameters["@lastprice"].Value = gainer.LastPrice;

            command.Parameters.Add("@prevclose", SqlDbType.Float);
            command.Parameters["@prevclose"].Value = gainer.PrevClose;

            command.Parameters.Add("@change", SqlDbType.Float);
            command.Parameters["@change"].Value = gainer.Change;

            command.Parameters.Add("@gain", SqlDbType.Float);
            command.Parameters["@gain"].Value = gainer.Gain;

            dal.MyExecuteNonQuery(command, query);


        }
    }
}
