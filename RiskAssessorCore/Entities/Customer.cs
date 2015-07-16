using System.Collections.Generic;
using System.Linq;
using RiskAssessorCore.Data;
using RiskAssessorLib.Entities;

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
                    _UnsettledBets = BetsDataAdapter.GetInstance().AllUnsettledBets.Where(b => b.CustomerId == this.Id);
                return _UnsettledBets;
            }
        }

        private IEnumerable<ISettledBet> _SettledBets = null;

        public IEnumerable<ISettledBet> SettledBets
        {
            get
            {
                if (_SettledBets == null)
                    _SettledBets = BetsDataAdapter.GetInstance().AllSettledBets.Where(b => b.CustomerId == this.Id);
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
                    _WinningPercentage = this.WinningBetsCount/this.SettledBets.Count()*100;
                    return (float) _WinningPercentage;
            }
        }

        private bool? _HasUnusualWinningOdds = null;

        public bool HasUnusualWinningOdds
        {
            get
            {
                if (_HasUnusualWinningOdds == null)
                {
                    _HasUnusualWinningOdds = this.WinningBetsCount > 60;
                }
                return (bool) _HasUnusualWinningOdds;
            }
        }
    }
}
