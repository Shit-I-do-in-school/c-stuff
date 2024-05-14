using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame_App
{
    internal class Cards
    {
        public string[] CardSuit = { "klöver", "ruter", "hjärter", "spader" };
        public int[] Value = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

        public string getCardSuit(int pos)
        {
            return CardSuit[pos];
        }

        public int getValue(int pos)
        {
            return Value[pos];
        }
    }
}
