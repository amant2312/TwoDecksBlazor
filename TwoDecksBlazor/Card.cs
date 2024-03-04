using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoDecksBlazor
{
    internal class Card
    {
        public values Value { get; private set; }
        public suits Suit { get; private set; }
        /*public string Name { get { return $"{Value} of {Suit}"; } }*/
        public Card(values value, suits suit)
        {
            Value = value;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Value} of {Suit}";
        }


    }
}
