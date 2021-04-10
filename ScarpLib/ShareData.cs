using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScarpLib
{
    public class ShareData
    {
        private double price;
        private double rise;
        private double changePerc;

        public double Price { get => price; set => price = value; }
        public double Rise { get => rise; set => rise = value; }
        public double ChangePerc { get => changePerc; set => changePerc = value; }


    }
}
