using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskAssessorLib.Entities;

namespace RiskAssessorLib.Logic
{
    public static class RiskExtensions
    {
        public static bool CustomerHasUnusualWinningOdds(this ICustomer customer)
        {
            return customer.WinningPercentage > 60;
        }
    }
}
