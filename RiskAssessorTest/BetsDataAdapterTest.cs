using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiskAssessorCore.Data;

namespace RiskAssessorTest
{
    [TestClass]
    public class BetsDataAdapterTest
    {
        [TestMethod]
        public void AllSettledBets_RetrievesAllRecords()
        {
             Assert.AreEqual(50, BetsDataAdapter.GetInstance().AllSettledBets.Count);
        }

        [TestMethod]
        public void AllUnsettledBets_RetrievesAllRecords()
        {
            Assert.AreEqual(22, BetsDataAdapter.GetInstance().AllUnsettledBets.Count);
        }
    }
}
