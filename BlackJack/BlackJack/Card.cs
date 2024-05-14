using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Card
    {
        public string[] CardSuit = { "klöver", "ruter", "hjärter", "spader" };
        public int[] Value = {1,2,3,4,5,6,7,8,9,10, 10,10,10};//ace (ess) is 1 or 11, 3st 10s are people cards

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
