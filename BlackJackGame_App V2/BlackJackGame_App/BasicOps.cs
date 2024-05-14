using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackGame_App
{
    internal class BasicOps
    {
        public int checkCard(string[] cards, int sum, int pos)
        {
            if (int.Parse(cards[pos].Split(' ')[1]) == 1)// kolla om kort är ace
            {
                cards[pos] = "ace";// byta namn från 1 till ace
                if ((sum + 11) < 22)// välje ett värde att ge till ace
                {
                    sum += 11;
                }
                else
                {
                    sum++;
                }
            }
            else
            {
                sum += int.Parse(cards[pos].Split(' ')[1]);
            }
            return sum;

        }

        public string isWin(int player, int dealer)
        {
            if (player == dealer)
            {
                return "Tie";
            }
            else if ((dealer > player || player > 21) && dealer < 22)
            {
                return "You lost";
            }
            else
            {
                return "You win!";
            }
        }
    }
}
