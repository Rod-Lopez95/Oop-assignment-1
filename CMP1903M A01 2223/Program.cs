using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Program
    {
        static void Main(string[] args)
        {
            // Menu option for user
            Console.WriteLine("Select 1 for testing or 2 to start the pack shuffle.");
            int userDecision = 0;
            try
            {
                userDecision = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error Alert: Input must be 1 or 2. /n" + ex.Message);
                Console.ReadLine();
                Environment.Exit(1);
            }
            if (userDecision == 1)
            {
                Testing.TestProgram();
            }
            else if (userDecision == 2)
            {
                Pack CardPack = new Pack();
                // Shuffles the pack using Fisher-Yates Shuffle
                CardPack.ShuffleCardPack(1);

                // Dealing method
                Console.WriteLine("Fisher-Yates Shuffle:");
                for (int i = 0; i < 5; i++)
                {
                    Card card = CardPack.Deal();
                    Console.WriteLine("Dealt card {0} of suit {1}", card.Value, card.Suit);
                }

                // Shuffles the pack using Riffle Shuffle
                CardPack.ShuffleCardPack(2);

                Console.WriteLine("\nRiffle Shuffle:");
                for (int i = 0; i < 5; i++)
                {
                    Card card = CardPack.Deal();
                    Console.WriteLine("Dealt card {0} of suit {1}", card.Value, card.Suit);
                }

                // Shuffles the pack using No Shuffle
                CardPack.ShuffleCardPack(3);

                Console.WriteLine("\nNo Shuffle:");
                for (int i = 0; i < 5; i++)
                {
                    Card card = CardPack.Deal();
                    Console.WriteLine("Dealt card {0} of suit {1}", card.Value, card.Suit);
                }

                Console.ReadLine();
            }
        }
    }
}