using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskAssessorLib.Entities;

namespace RiskAssessorTest.MockEntities
{
    internal class FakeCustomer:ICustomer
    {
        public int Id { get; set; }
        public IEnumerable<IUnsettledBet> UnsettledBets { get; set; }
        public IEnumerable<ISettledBet> SettledBets{ get; set; }
        public int WinningBetsCount{ get; set; }
        public float WinningPercentage{ get; set; }
    }
}
