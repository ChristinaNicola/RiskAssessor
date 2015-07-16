using System.Collections.Generic;
using System.IO;
using RiskAssessorLib.Entities;

namespace RiskAssessorCore.Data
{
    internal static class BetsDataReader
    {
        public static List<ISettledBet> RetrieveSettledBetsData()
        {
            var reader = new StreamReader(File.OpenRead(@"Settled.csv"));
            
            var settledBets = new List<ISettledBet>();

            //skip header line
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                
                //will skip checking nulls, white spaces, whether the value is actually an int/double and array length to save some time 
                settledBets.Add(BetsFactory.CreateSettledBet(
                    customerId: int.Parse(values[0]), eventId: int.Parse(values[1]), participantId: int.Parse(values[2]),
                    stake: double.Parse(values[3]), amountWon: double.Parse(values[4])));
            }

            return settledBets;
        }

        public static List<IUnsettledBet> RetrieveUnsettledBetsData()
        {
            var reader = new StreamReader(File.OpenRead( @"UnSettled.csv"));

            var unsettledBets = new List<IUnsettledBet>();

            //skip header line
            reader.ReadLine();

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');
                
                //will skip checking nulls, white spaces, whether the value is actually an int/double and array length to save some time 
                unsettledBets.Add(BetsFactory.CreateUnSettledBet(
                    customerId: int.Parse(values[0]), eventId: int.Parse(values[1]), participantId: int.Parse(values[2]),
                    stake: double.Parse(values[3]), amountToWin: double.Parse(values[4])));
            }

            return unsettledBets;
        }
    }
}
