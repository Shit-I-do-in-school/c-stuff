using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlackJack_optimised_ish
{
    internal class BasicOps
    {
        public bool IsAce(string[] cards, int pos)
        {
            try
            {
                if (int.Parse(cards[pos].Split(' ')[1]) == 1)// kolla om kort är ace
                {
                    return true;
                }
            } catch { return false; }
            return false;
        }

        public bool IsFace(string[] cards, int pos)
        {
            try {
                if (int.Parse(cards[0].Split(' ')[1]) == 10)
                {
                    return true;
                }
            }
            catch { return false; }
            return false;
        }


        public string IsWin(int player, int dealer)
        {
            if (player == dealer)
            {
                return "Tie";
            }
            else if (dealer > player || player > 21)
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
