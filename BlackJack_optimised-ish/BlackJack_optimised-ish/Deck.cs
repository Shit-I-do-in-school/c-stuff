using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_optimised_ish
{
    internal class Cards
    {
        protected string[] cardType = { "klöver", "ruter", "hjärter", "spader" };
        protected int[] cardNr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 10, 10, 10 };

        /*
        public string GetCardType(int pos)
        {
            return cardType[pos];
        }
        public int TetCardNr(int pos)
        {
            return cardNr[pos];
        }
        */
    }

    class Deck : Cards
    {
        List<string> cardDeck = new List<string>();

        public void CreateDeck()
        {
            for (int x = 0; x < 4; x++)// skpa 4 decks genom att loopa 4 gånger
            {
                foreach (string type in cardType)
                {
                    foreach (int number in cardNr)
                    {
                        cardDeck.Add(type + " " + number);
                    }
                }
            }
        }

        public void Shuffle()
        {
            Random rng = new Random();
            int pos;
            for (int i = 0; i < cardDeck.Count; i++)
            {
                pos = rng.Next(i, 208);
                (cardDeck[pos], cardDeck[i]) = (cardDeck[i], cardDeck[pos]);
            }
        }

        int pos = -1;
        public string Draw()
        {
            try
            {
                pos++;
                return cardDeck[pos];
            }
            catch { return ""; }
            
        }
    }
}
