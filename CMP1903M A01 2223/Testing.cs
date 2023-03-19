using System;

namespace CMP1903M_A01_2223
{
    class Testing
    {
        static void Main(string[] args)
        {
            // Creates a Pack object
            Pack pack = new Pack();

            // Testing Fisher-Yates Shuffle
            Pack.ShuffleCardPack(1);
            Console.WriteLine("Fisher-Yates Shuffle:");
            for (int i = 0; i < 5; i++)
            {
                Card card = Pack.Deal();
                Console.WriteLine("Dealt card {0} of suit {1}", card.Value, card.Suit);
            }

            // Testing Riffle Shuffle
            Pack.ShuffleCardPack(2);
            Console.WriteLine("\nRiffle Shuffle:");
            for (int i = 0; i < 5; i++)
            {
                Card card = Pack.Deal();
                Console.WriteLine("Dealt card {0} of suit {1}", card.Value, card.Suit);
            }

            // Testing No Shuffle
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