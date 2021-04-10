using System;

namespace ScarpLib
{
    public class BankNiftyOptions
    {
        private DateTime sDate;
        private int strike;
        private float ltp;
        private float netChange;
        private int volume;
        private int openInterest;
        private int chaneInOpenInterest;

        public DateTime SDate { get => sDate; set => sDate = value; }
        public float Ltp { get => ltp; set => ltp = value; }
        public float NetChange { get => netChange; set => netChange = value; }
        public int Volume { get => volume; set => volume = value; }
        public int OpenInterest { get => openInterest; set => openInterest = value; }
        public int ChaneInOpenInterest { get => chaneInOpenInterest; set => chaneInOpenInterest = value; }
        public int Strike { get => strike; set => strike = value; }

        public override string ToString()
        {
            return strike + "|" + ltp + "|" + NetChange + "|" + volume + "|" + openInterest + "|" + chaneInOpenInterest;
        }
    }
}