using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RiskAssessorLib.Entities;

namespace RiskAssessorLib
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
