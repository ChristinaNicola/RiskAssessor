using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RiskAssessorCore.Data;

namespace RiskAssessorTest
{
    [TestClass]
    public class SettledBetTest
    {
        [TestMethod]
        public void IsAWinningBet_UsesCorrectLogic()
        {
            //Check to see that the count of settled bets that have an amount greater than zero and are considered winning bets 
            //plus that of the bets that do not have such an amount and are considered non winning bets 
            //is equal to the total count of settled bets. 
            //This will ensure all settled bets fall under the right category.
            Assert.AreEqual( RiskAssessorDataAdapter.GetInstance().AllSettledBets.Count,
                RiskAssessorDataAdapter.GetInstance().AllSettledBets.Count(b =>
                (b.AmountWon > 0 && b.IsAWinningBet) ||
                ((b.AmountWon == null || b.AmountWon <= 0) && !b.IsAWinningBet)));
        }
    }
}
