using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RiskAssessorLib.Entities
{
    public interface IBet
    {
        int BetId { get; }
        int ParticipantId { get; }
        int EventId { get; }
        int CustomerId { get; }
        double Stake { get; }
    }
}
