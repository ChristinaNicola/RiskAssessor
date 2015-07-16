using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskAssessorLib.Entities;

namespace RiskAssessorData
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
    }
}
