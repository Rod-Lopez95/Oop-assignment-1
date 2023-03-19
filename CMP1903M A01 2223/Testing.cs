using System;

namespace CMP1903M_A01_2223
{
    class Testing
    {

        public static bool TestProgram()
        {
            // Creates a Pack object
            Pack pack = new Pack();

            var FisherYatesResult = ShuffleTest(pack, 1);
            if (!FisherYatesResult)
            {
                return false;
            }
            var RiffleShuffleResult = ShuffleTest(pack, 2);
            if (!RiffleShuffleResult)
            {
                return false;
            }
            var NoShuffleResult = ShuffleTest(pack, 3);
            if (!NoShuffleResult)
            {
                return false;
            }
            return true;

        }

        private static bool ShuffleTest(Pack CardPack ,int typeOfShuffle)
        {
            // Testing Shuffle Types
            CardPack.ShuffleCardPack(typeOfShuffle);
            Console.WriteLine("Fisher-Yates Shuffle:");
            for (int i = 0; i < 5; i++)
            {
                Card card = CardPack.Deal();
                if (card.Value > 13 || card.Value < 1)
                    return false;
                if (card.Suit > 4 || card.Suit < 1)
                    return false;
                Console.WriteLine("Dealt card {0} of suit {1}", card.Value, card.Suit);
            }
            return true;
        }
    }
}