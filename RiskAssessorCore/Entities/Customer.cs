using System.Collections.Generic;
using System.Linq;
using RiskAssessorCore.Data;
using RiskAssessorLib.Entities;
using RiskAssessorLib.Logic;

namespace RiskAssessorCore.Entities
{
    internal class Customer : ICustomer
    {
        public Customer(int customerId)
        {
            _Id = customerId;
        }

        private int _Id;
        public int Id { get { return _Id; } }

        private IEnumerable<IUnsettledBet> _UnsettledBets = null;

        public IEnumerable<IUnsettledBet> UnsettledBets
        {
            get
            {
                if (_UnsettledBets == null)
                    _UnsettledBets = RiskAssessorDataAdapter.GetInstance().AllUnsettledBets.Where(b => b.CustomerId == this.Id);
                return _UnsettledBets;
            }
        }

        private IEnumerable<ISettledBet> _SettledBets = null;

        public IEnumerable<ISettledBet> SettledBets
        {
            get
            {
                if (_SettledBets == null)
                    _SettledBets = RiskAssessorDataAdapter.GetInstance().AllSettledBets.Where(b => b.CustomerId == this.Id);
                return _SettledBets;
            }
        }

        private int? _WinningBetsCount = null;

        public int WinningBetsCount
        {
            get
            {
                if (_WinningBetsCount == null)
                    _WinningBetsCount = this.SettledBets.Count(b => b.IsAWinningBet);
                return (int) _WinningBetsCount;
            }
        }

        private float? _WinningPercentage = null;

        public float WinningPercentage
        {
            get
            {
                if (_WinningPercentage == null)
                    _WinningPercentage = ((float)this.WinningBetsCount/(float)this.SettledBets.Count())*100;
                return (float) _WinningPercentage;
            }
        }
    }
}
