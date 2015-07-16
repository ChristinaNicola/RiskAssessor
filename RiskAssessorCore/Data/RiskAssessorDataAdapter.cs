using System;
using System.Collections.Generic;
using System.Linq;
using RiskAssessorLib.Entities;

namespace RiskAssessorCore.Data
{
    public class RiskAssessorDataAdapter
    {
        //singleton
        private  RiskAssessorDataAdapter()
        { }

        public static RiskAssessorDataAdapter GetInstance()
        {
            return new RiskAssessorDataAdapter();
        }

        private List<IUnsettledBet> _AllUnsettledBets = null;

        public List<IUnsettledBet> AllUnsettledBets
        {
            get
            {
                if (_AllUnsettledBets == null)
                    _AllUnsettledBets = BetsDataReader.RetrieveUnsettledBetsData();
                return _AllUnsettledBets;
            }
        }

        private List<ISettledBet> _AllSettledBets = null;

        public List<ISettledBet> AllSettledBets
        {
            get
            {
                if (_AllSettledBets == null)
                    _AllSettledBets = BetsDataReader.RetrieveSettledBetsData();
                return _AllSettledBets;
            }
        }

        private List<ICustomer> _AllCustomers = null;
        
        public List<ICustomer> AllCustomers
        {
            get
            {
                if (_AllCustomers == null)
                {
                    IEnumerable<int> customerIds =
                        AllSettledBets.Select(b => b.CustomerId)
                            .Union(AllUnsettledBets.Select(b => b.CustomerId))
                            .Distinct();

                    if (customerIds != null && customerIds.Any())
                    {
                        _AllCustomers = customerIds.Select(customerId => EntitiesFactory.CreateCustomer(customerId)).ToList();
                    }
                }

                return _AllCustomers;
            }
        }

    }
}
