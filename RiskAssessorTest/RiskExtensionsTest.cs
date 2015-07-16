using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiskAssessorLib.Logic;
using RiskAssessorTest.MockEntities;

namespace RiskAssessorTest
{
    [TestClass]
    public class RiskExtensionsTest
    {
        [TestMethod]
        public void CustomerHasUnusualWinningOdds_HandlesPercentagesCorrectly()
        {
            FakeCustomer customer = new FakeCustomer() {WinningPercentage = 90};
            Assert.IsTrue(customer.CustomerHasUnusualWinningOdds());

            customer.WinningPercentage = 10;
            Assert.IsFalse(customer.CustomerHasUnusualWinningOdds());

            customer.WinningPercentage = 60;
            Assert.IsFalse(customer.CustomerHasUnusualWinningOdds());
        }
    }
}
