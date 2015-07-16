﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAssessorLib.Entities
{
    public interface IUnsettledBet: IBet
    {
        double AmountToWin { get; }
    }
}
