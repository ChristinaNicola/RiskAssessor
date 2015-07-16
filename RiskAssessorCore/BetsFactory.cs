using RiskAssessorCore.Entities;
using RiskAssessorLib.Entities;

namespace RiskAssessorCore
{
    public static class BetsFactory
    {
        public static ISettledBet CreateSettledBet(int customerId, int eventId, int participantId, double stake, double amountWon)
        {
            return new SettledBet()
            {
                CustomerId = customerId,
                EventId = eventId,
                ParticipantId = participantId,
                Stake = stake,
                AmountWon = amountWon
            };
        } 

        public static IUnsettledBet CreateUnSettledBet(int customerId, int eventId, int participantId, double stake, double amountToWin )
        {
            return new UnsettledBet()
            {
                CustomerId = customerId,
                EventId = eventId,
                ParticipantId = participantId,
                Stake = stake,
                AmountToWin = amountToWin
            };
        } 
    }
}
