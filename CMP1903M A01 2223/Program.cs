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
            // Generates a new card pack
            Pack pack = new Pack();

            // Shuffles the pack using Fisher-Yates Shuffle
            Pack.ShuffleCardPack(1);

            // Dealing method
            Console.WriteLine("Fisher-Yates Shuffle:");
            for (int i = 0; i < 5; i++)
            {
                Card card = Pack.Deal();
                Console.WriteLine("Dealt card {0} of suit {1}", card.Value, card.Suit);
            }

            // Shuffles the pack using Riffle Shuffle
            Pack.ShuffleCardPack(2);

            Console.WriteLine("\nRiffle Shuffle:");
            for (int i = 0; i < 5; i++)
            {
                Card card = Pack.Deal();
                Console.WriteLine("Dealt card {0} of suit {1}", card.Value, card.Suit);
            }

            // Shuffles the pack using No Shuffle
            Pack.ShuffleCardPack(3);

            Console.WriteLine("\nNo Shuffle:");
            for (int i = 0; i < 5; i++)
            {
                Card card = Pack.Deal();
                Console.WriteLine("Dealt card {0} of suit {1}", card.Value, card.Suit);
            }

            Console.ReadLine();
        }
    }
}