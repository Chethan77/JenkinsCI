using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingLibrary
{
    public class CalcInterest:ICalcInterest
    {
        public int Calculate(int principle,int RateOfInt,int years)
        {
            int SimpInt = (principle * years * RateOfInt) / 100;
            return SimpInt;
        }
    }
}
