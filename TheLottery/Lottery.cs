using System;
using System.Collections;
using System.Security.Policy;

namespace TheLottery
{
    internal class Lottery
    {
        private static Random _randomNumberGenerator = new Random();


        public int GenerateLotteryNumber()
        {
            var lotteryNumber = _randomNumberGenerator.Next(1, 100);
            return lotteryNumber;
        }

        public int[] GetWinningNumbers()
        {
            
            var winningNumbers = new int[5];
            do
            {
                winningNumbers[0] = GenerateLotteryNumber();
                winningNumbers[1] = GenerateLotteryNumber();
                winningNumbers[2] = GenerateLotteryNumber();
                winningNumbers[3] = GenerateLotteryNumber();
                winningNumbers[4] = GenerateLotteryNumber();
            } while (!AreTicketNumbersOk(winningNumbers));

            Array.Sort(winningNumbers);
            return winningNumbers;
        }
        public int CheckTicket(int[] winningNumbers,int[] ticketNumbers)
        {
            // sort the winning numbers
           
            Array.Sort(ticketNumbers);

            // See how many matches the ticket has compared to the winning ticket
            int matches = 0;
            for (int i = 0; i < ticketNumbers.Length; i++)
            {
                if (Array.BinarySearch(winningNumbers, ticketNumbers[i]) >= 0)
                {
                    matches++;
                }
            }

            return matches;

        }

        public bool AreTicketNumbersOk(int[] ticketNumbers)
        {
            Hashtable hashtable = new Hashtable();
            foreach (int number in ticketNumbers)
            {
                if (hashtable.ContainsKey(number))
                {
                    return false;
                }
                else
                {
                    if (number < 0)
                    {
                        return false;
                    }

                    hashtable.Add(number, null);
                }
            }

            return true;
        }
    }
}
