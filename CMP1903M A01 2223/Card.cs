using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M_A01_2223
{
    class Card
    {
        // Value: numbers 1 - 13
        private int _value;
        public int Value
        {
            get { return _value; }
            set
            {
                if (value < 1 || value > 13)
                {
                    throw new ArgumentException("Value must be between 1 and 13.");
                }
                _value = value;
            }
        }

        // Suit: numbers 1 - 4
        private int _suit;
        public int Suit
        {
            get { return _suit; }
            set
            {
                if (value < 1 || value > 4)
                {
                    throw new ArgumentException("Suit must be between 1 and 4.");
                }
                _suit = value;
            }
        }
    }
}