using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();

            for (int i = 0; i < 208; i++)
            {
                Console.WriteLine(deck.Draw());
                
            }

            int dealer = 0;
            string[] dealerCards = new string[2];

            int player = 0;
            string[] playerCards = new string[20];

            dealerCards[0] = deck.draw();
            dealerCards[1] = deck.draw();
            dealer += int.Parse(dealerCards[0].Split(' ')[1]);

            playerCards[0] = deck.draw();
            player += int.Parse(playerCards[0].Split(' ')[1]);

        }
    }
}