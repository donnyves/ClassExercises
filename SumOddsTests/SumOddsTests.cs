using Microsoft.VisualStudio.TestTools.UnitTesting;
using SumOdds;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOdds.Tests
{
    [TestClass()]
    public class SumOddsTests
    {
        [TestMethod()]
        public void CollectSumOddsTest_05()
        {
            Assert.AreEqual(9, SumOdds.CollectSumOdds(0,5));
        }
    }
}