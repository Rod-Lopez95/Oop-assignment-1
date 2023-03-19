using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        private List<Card> pack;

        public Pack()
        {
            // Creates the card pack
            pack = new List<Card>();
            for (int suit = 1; suit <= 4; suit++) // Suits can be attributed to each integer i.e 1 = spades
            {
                for (int card_value = 1; card_value <= 13; card_value++) // Card value can represent specific cards i.e 1 = ace
                {
                    pack.Add(new Card { Suit = suit, Value = card_value });
                }
            }
        }

        public static void ShuffleCardPack(int typeOfShuffle)
        {
            // Shuffles the pack based on the type of shuffle

            switch (typeOfShuffle)
            {
                case 1: // Fisher-Yates Shuffle
                    FisherYatesShuffle();
                    break;
                case 2: // Riffle Shuffle
                    RiffleShuffle();
                    break;
                case 3: // No Shuffle
                    // Do nothing
                    break;
                default:
                    throw new ArgumentException("Invalid type of shuffle specified");
            }
        }

        private static void FisherYatesShuffle()
        {
            Random rand = new Random();

            for (int x = 0; x < pack.Count; x++)
            {
                int y = rand.Next(x, pack.Count);
                Card temp = pack[y];
                pack[x] = pack[y];
                pack[y] = temp;
            }
        }

        private static void RiffleShuffle()
        {
            Random rand = new Random();

            int halfCount = pack.Count / 2;
            List<Card> leftHalf = pack.GetRange(0, halfCount);
            List<Card> rightHalf = pack.GetRange(halfCount, halfCount);

            pack.Clear();

            while (leftHalf.Count > 0 && rightHalf.Count > 0)
            {
                if (rand.NextDouble() < 0.5)
                {
                    pack.Add(leftHalf[0]);
                    leftHalf.RemoveAt(0);
                }
                else
                {
                    pack.Add(rightHalf[0]);
                    rightHalf.RemoveAt(0);
                }
            }

            if (leftHalf.Count > 0)
            {
                pack.AddRange(leftHalf);
            }
            else if (rightHalf.Count > 0)
            {
                pack.AddRange(rightHalf);
            }
        }

        public static Card Deal()
        {
            // Deals a single card
            if (pack.Count == 0)
            {
                throw new InvalidOperationException("No more cards in the pack");
            }

            Card card = pack[0];
            pack.RemoveAt(0);

            return card;
        }

        public static List<Card> DealCard(int amount)
        {
            // Deals cards according to specific amount
            if (amount > pack.Count)
            {
                throw new ArgumentException("Not enough cards in the pack");
            }

            List<Card> cards = pack.GetRange(0, amount);
            pack.RemoveRange(0, amount);

            return cards;
        }
    }
}
