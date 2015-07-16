using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAssessorLib.Entities
{
    public interface ICustomer
    {
        int Id { get; }
        IEnumerable<IUnsettledBet> UnsettledBets { get; }
        IEnumerable<ISettledBet> SettledBets { get; }
        int WinningBetsCount { get; }
        float WinningPercentage { get; }
    }
}
