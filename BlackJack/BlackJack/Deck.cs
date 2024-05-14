using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Deck
    {
        Card card = new Card();
        private Random rng = new Random();

        private string[] drawnCards = new string[208];
        private string tempCard;
        private int pos = 0;
        private string pickedCard1;
        private string pickedCard2;

        public void shuffle()
        {
            pos = 0;
            //generate cards
            for (int x = 0; x < 4; x++) 
            {
                for (int i = 0; i < card.CardSuit.Length; i++)
                {
                    for (int j = 0; j < card.Value.Length; j++)
                    {
                        tempCard = card.getCardSuit(i) + " " + card.getValue(j);
                        drawnCards[pos] = tempCard;
                        //Console.WriteLine(drawnCards[pos]);
                        pos++;
                    }
                }
            }

            pickedCard1 = drawnCards[pos-1];

            for (int i = 0; i < drawnCards.Length; i++)
            {
                pos = rng.Next(i, 208);
                (drawnCards[pos], drawnCards[i]) = (drawnCards[i], drawnCards[pos]);
            }

            foreach (string y in drawnCards)
            {
                Console.WriteLine(y);
            }
            pos = -1;
        }

        public string draw()
        {
            pos++;
            return drawnCards[pos];
        }
    }
}
