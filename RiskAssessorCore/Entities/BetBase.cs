using RiskAssessorLib.Entities;

namespace RiskAssessorCore.Entities
{
    internal abstract class BetBase: IBet
    {
        public int BetId { get; set; }

        public int ParticipantId { get; set; }       

        public int EventId { get; set; }

        public int CustomerId { get; set; }

        public double Stake { get; set; }
    }
}
