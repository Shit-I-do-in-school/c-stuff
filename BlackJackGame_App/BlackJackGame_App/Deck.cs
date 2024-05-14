using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJackGame_App
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
                        Console.WriteLine(drawnCards[pos]);
                        pos++;
                    }
                }
            }

            pickedCard1 = drawnCards[pos - 1];
            for (int i = 0; i < drawnCards.Length; i++)
            {
                pos = rng.Next(0, 208);
                pickedCard2 = drawnCards[pos];

                drawnCards[pos] = pickedCard1;

                pos = rng.Next(0, 208);
                pickedCard1 = drawnCards[pos];

                drawnCards[pos] = pickedCard2;
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
