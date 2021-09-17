using BankingLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BankLibrary.Tests
{
    [TestClass]
    public class CalcInterestTests
    {
        [TestMethod]
        public void Calculate_AcceptsPNR_Returns()
        {
            int ExpectedResult = 1000;
            CalcInterest calc = new CalcInterest();
            int ActualResult = calc.Calculate(10000, 10, 1);
            Assert.AreEqual(ExpectedResult, ActualResult);
;       }
    }
}
