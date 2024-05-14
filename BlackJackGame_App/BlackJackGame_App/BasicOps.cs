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
            if (int.Parse(cards[pos].Split(' ')[1]) == 1)// check if card is ace
            {
                cards[pos] = "ace";// rename from "1" to "ace"
                if ((sum + 11) < 22)// chose value to give
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
            string value;
            if (player == dealer)
            {
                value = "Tie";
            }

            else if ((dealer > player && dealer < 22) || player > 21)
            {
                value = "You lost";
            }
            else
            {
                value = "You win!";
            }
            return value;
        }
    }
}
