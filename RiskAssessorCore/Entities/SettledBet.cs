using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskAssessorLib.Entities;

namespace RiskAssessorCore.Entities
{
    internal class SettledBet:BetBase,ISettledBet
    {
        public double AmountWon { get; set; }

        public bool IsAWinningBet
        {
            get { return AmountWon > 0; }
        }
    }
}
