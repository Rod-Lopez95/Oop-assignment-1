using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Pack
    {
        // Creates the card pack
        private List<Card> CardList = new List<Card>();

        public Pack()
        {
            for (int suit = 1; suit <= 4; suit++) // Suits can be attributed to each integer i.e 1 = spades
            {
                for (int card_value = 1; card_value <= 13; card_value++) // Card value can represent specific cards i.e 1 = ace
                {
                    CardList.Add(new Card { Suit = suit, Value = card_value });
                }
            }
        }

        public void ShuffleCardPack(int typeOfShuffle)
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

        private void FisherYatesShuffle()
        {
            Random rand = new Random();

            for (int x = 0; x < CardList.Count; x++)
            {
                int y = rand.Next(x, CardList.Count);
                Card temp = CardList[y];
                CardList[x] = CardList[y];
                CardList[y] = temp;
            }
        }

        private void RiffleShuffle()
        {
            Random rand = new Random();

            int halfCount = CardList.Count / 2;
            List<Card> leftHalf = CardList.GetRange(0, halfCount);
            List<Card> rightHalf = CardList.GetRange(halfCount, halfCount);

            CardList.Clear();

            while (leftHalf.Count > 0 && rightHalf.Count > 0)
            {
                if (rand.NextDouble() < 0.5)
                {
                    CardList.Add(leftHalf[0]);
                    leftHalf.RemoveAt(0);
                }
                else
                {
                    CardList.Add(rightHalf[0]);
                    rightHalf.RemoveAt(0);
                }
            }

            if (leftHalf.Count > 0)
            {
                CardList.AddRange(leftHalf);
            }
            else if (rightHalf.Count > 0)
            {
                CardList.AddRange(rightHalf);
            }
        }

        public Card Deal()
        {
            // Deals a single card
            if (CardList.Count == 0)
            {
                throw new InvalidOperationException("No more cards in the pack");
            }

            Card card = CardList[0];
            CardList.RemoveAt(0);

            return card;
        }

        public List<Card> DealCard(int amount)
        {
            // Deals cards according to specific amount
            if (amount > CardList.Count)
            {
                throw new ArgumentException("Not enough cards in the pack");
            }

            List<Card> cards = CardList.GetRange(0, amount);
            CardList.RemoveRange(0, amount);

            return cards;
        }
    }
}
