using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAssessorLib.Entities
{
    internal class SettledBet:BetBase,ISettledBet
    {
        public double AmountWon { get; set; }
    }
}
