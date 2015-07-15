using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAssessorLib.Entities
{
    internal class UnsettledBet:BetBase,IUnsettledBet
    {
        public double AmountToWin { get; set; }
    }
}
