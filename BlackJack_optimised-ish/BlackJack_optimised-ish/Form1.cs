using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BlackJack_optimised_ish
{
    public partial class Form1 : Form
    {
        Deck deck = null;
        BasicOps basicOps = null;

        string[] face_cards = { "kung", "drotning", "knäkt", "10" };

        int dealer_score = 0;
        string[] dealer_cards = new string[20];

        int player_score = 0;
        string[] player_cards = new string[20];

        int drawpos = 0;


        public Form1()
        {
            InitializeComponent();

            deck = new Deck();
            basicOps = new BasicOps();
            Random rand = new Random();

            deck.Shuffle();

            //skapa dealer hand
            dealer_cards[0] = deck.Draw();
            dealer_cards[1] = deck.Draw();

            if (basicOps.IsAce(dealer_cards, 0))
            {
                dealer_cards[0] = "ace";
                dealer_score += 10; 
            }
            if (basicOps.IsAce(dealer_cards, 1))
            {
                dealer_cards[1] = "ace";
            }


            if (basicOps.IsFace(dealer_cards, 0))
            {
                dealer_cards[0] = face_cards[rand.Next(0, face_cards.Length)];
                dealer_score += 10;
            } 
            if (basicOps.IsFace(dealer_cards, 1))
            {
                dealer_cards[1] = face_cards[rand.Next(0, face_cards.Length)];
            }


            //skapa player hand
            player_cards[0] = deck.Draw();

            if (basicOps.IsAce(player_cards, 0))
            {
                player_cards[0] = "ace";
                player_score += 11;
            }
            else if (basicOps.IsFace(player_cards, 0))
            {
                player_cards[0] = face_cards[rand.Next(0, face_cards.Length)];
                player_score += 10;
            }


            label_dealer_cards.Text = "Dealer cards: " + dealer_cards[0] + "\n";
            label_dealer_score.Text = "Dealer points: " + dealer_score.ToString();

            label_player_cards.Text = "Your cards: " + player_cards[0] + "\n";
            label_player_score.Text = "Your points: " + player_score.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button_draw_Click(object sender, EventArgs e)//draw card
        {
            Random random = new Random();

            drawpos++;

            player_cards[drawpos] = deck.Draw();
            player_score = basicOps.checkCard(playerCards, player_score, drawpos);

            if (int.Parse(playerCards[drawpos].Split(' ')[1]) == 10)
            {
                playerCards[drawpos] = playerCards[drawpos].Split(' ')[0] + " " + faceCards[random.Next(0, faceCards.Count())];
            }


            player_score.Text = "Your points: " + player_score.ToString();
            player_card.Text = player_card.Text + "Your Cards: " + playerCards[drawpos] + "\n";


            if (player_score > 21)// player lost, no need for dealer to draw cards
            {
                dealer = basicOps.checkCard(dealerCards, dealer, 1);
                if (int.Parse(dealerCards[1].Split(' ')[1]) == 10)// check if held card is face
                {
                    dealerCards[1] = dealerCards[1].Split(' ')[0] + " " + faceCards[random.Next(0, faceCards.Count())];
                }
                dealer_score.Text = "Dealer points: " + dealer.ToString();
                dealer_card.Text = dealer_card.Text + "Delaer Cards: " + dealerCards[1] + "\n";


                MessageBox.Show(basicOps.isWin(player, dealer));
                System.Windows.Forms.Application.Exit();
            }
        }
    }
    }
}
