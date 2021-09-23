using System;
using System.Collections.Generic;
using System.Text;

namespace SharedLogic
{
    public static class DateTimeSettings
    {
        public static DateTime lastSyncDate = null;
        private BSEMSSQLDAL bSEMSSQLDAL;
        public DateTimeSettings()
        {
            bSEMSSQLDAL = new BSEMSSQLDAL();
        }
        
    }
}
