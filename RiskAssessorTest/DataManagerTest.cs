using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiskAssessorData;

namespace RiskAssessorTest
{
    [TestClass]
    public class DataManagerTest
    {
        [TestMethod]
        public void RetrieveSettledBetsData_RetrievesAllRecords()
        {
            Assert.AreEqual(50, DataManager.RetrieveSettledBetsData().Count);
        }

        [TestMethod]
        public void RetrieveUnsettledBetsData_RetrievesAllRecords()
        {
            Assert.AreEqual(22, DataManager.RetrieveUnsettledBetsData().Count);
        }
    }
}
