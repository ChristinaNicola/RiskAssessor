using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiskAssessorCore.Data;

namespace RiskAssessorTest
{
    [TestClass]
    public class RiskAssessorDataAdapterTest
    {
        [TestMethod]
        public void AllSettledBets_RetrievesAllRecords()
        {
             Assert.AreEqual(50, RiskAssessorDataAdapter.GetInstance().AllSettledBets.Count);
        }

        [TestMethod]
        public void AllUnsettledBets_RetrievesAllRecords()
        {
            Assert.AreEqual(22, RiskAssessorDataAdapter.GetInstance().AllUnsettledBets.Count);
        }

        [TestMethod]
        public void AllCustomers_RetrievesAllRecords()
        {
            Assert.AreEqual(6, RiskAssessorDataAdapter.GetInstance().AllCustomers.Count);
        }
    }
}
