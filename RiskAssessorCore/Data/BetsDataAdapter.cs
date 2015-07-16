using System;
using System.Collections.Generic;
using System.Linq;
using RiskAssessorLib.Entities;

namespace RiskAssessorCore.Data
{
    public class BetsDataAdapter
    {
        //singleton
        private  BetsDataAdapter()
        { }

        public static BetsDataAdapter GetInstance()
        {
            return new BetsDataAdapter();
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

        public List<ICustomer> AllCustomers
        {
            get
            {
                IEnumerable<int> customerIds =
                    AllSettledBets.Select(b => b.CustomerId)
                        .Union(AllUnsettledBets.Select(b => b.CustomerId))
                        .Distinct();

                List<ICustomer> customers = null;
                if (customerIds != null && customerIds.Any())
                {
                    customers = customerIds.Select(customerId => BetsFactory.CreateCustomer(customerId)).ToList();
                }

                return customers;
            }
        }

    }
}
