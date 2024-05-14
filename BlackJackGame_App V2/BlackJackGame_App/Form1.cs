using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace BlackJackGame_App// version 2
{
    public partial class Form1 : Form
    {
        Deck deck = null;
        BasicOps basicOps = null;

        string[] faceCards = { "kung", "drotning", "knäkt", "10" };

        int dealer = 0;
        string[] dealerCards = new string[20];

        int player = 0;
        string[] playerCards = new string[20];
        int drawpos = 0; 

        public Form1()
        {
            InitializeComponent();
            deck = new Deck();
            basicOps = new BasicOps();
            Random rand = new Random();

            deck.shuffle();

            dealerCards[0] = deck.draw();
            dealerCards[1] = deck.draw();
            dealer = basicOps.checkCard(dealerCards, dealer, 0);
            if (int.Parse(dealerCards[0].Split(' ')[1]) == 10)
            {
                dealerCards[0] = dealerCards[0].Split(' ')[0] + " " + faceCards[rand.Next(0, faceCards.Count())];
            }

            playerCards[0] = deck.draw();
            player = int.Parse(playerCards[0].Split(' ')[1]);
            if (int.Parse(playerCards[0].Split(' ')[1]) == 10)
            {
                playerCards[0] = playerCards[0].Split(' ')[0] + " " + faceCards[rand.Next(0, faceCards.Count())];
            }


            dealer_card.Text = "Delaer Cards: " + dealerCards[0] + "\n";
            dealer_score.Text = "Dealer points: " + dealer.ToString();

            player_card.Text = "Your Cards: " + playerCards[0] + "\n";
            player_score.Text = "Your points: " + player.ToString();
        }


        private void button1_Click(object sender, EventArgs e)//draw card button
        {
            try
            {
            Random rand = new Random();
            drawpos++;

            playerCards[drawpos] = deck.draw();
            player = basicOps.checkCard(playerCards, player, drawpos);

            if (int.Parse(playerCards[drawpos].Split(' ')[1]) == 10)
            {
                playerCards[drawpos] = playerCards[drawpos].Split(' ')[0] + " " + faceCards[rand.Next(0, faceCards.Count())];
            }


            player_score.Text = "Your points: " + player.ToString();
            player_card.Text = player_card.Text + "Your Cards: " + playerCards[drawpos] + "\n";


            if (player > 21)// player lost, no need for dealer to draw cards
            {
                dealer = basicOps.checkCard(dealerCards, dealer, 1);
                if (int.Parse(dealerCards[1].Split(' ')[1]) == 10)// check if held card is face
                {
                    dealerCards[1] = dealerCards[1].Split(' ')[0] + " " + faceCards[rand.Next(0, faceCards.Count())];
                }
                dealer_score.Text = "Dealer points: " + dealer.ToString();
                dealer_card.Text = dealer_card.Text + "Delaer Cards: " + dealerCards[1] + "\n";


                MessageBox.Show(basicOps.isWin(player, dealer));
                System.Windows.Forms.Application.Exit();
            }
            }
            catch { }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)//dealer points
        {

        }

        private void player_score_Click(object sender, EventArgs e)//player points
        {

        }

        private void stand_Click(object sender, EventArgs e)//stand button
        {
            Random rand = new Random();

            dealer = basicOps.checkCard(dealerCards, dealer, 1);// check if held card is ace
            if (int.Parse(dealerCards[1].Split(' ')[1]) == 10)// check if held card is face
            {
                dealerCards[1] = dealerCards[1].Split(' ')[0] + " " + faceCards[rand.Next(0, faceCards.Count())];
            }

            drawpos = 2;
            while (dealer <= 16)// dealer draws cards until its above 13
            {
                dealerCards[drawpos] = deck.draw();
                dealer = basicOps.checkCard(dealerCards, dealer, drawpos);
                if (int.Parse(dealerCards[drawpos].Split(' ')[1]) == 10)
                {
                    dealerCards[drawpos] = dealerCards[drawpos].Split(' ')[0] + " " + faceCards[rand.Next(0, faceCards.Count())];
                }
                drawpos++;
            }

            // add every dealer held card to label
            dealer_score.Text = "Dealer points: " + dealer.ToString();
            for (int i = 1; i < drawpos; i++)
            {
                dealer_card.Text = dealer_card.Text + "Delaer Cards: " + dealerCards[i] + "\n";
            }


            MessageBox.Show(basicOps.isWin(player, dealer));
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click_1(object sender, EventArgs e)//button 1
        {
            
        }

        private void button2_Click(object sender, EventArgs e)//button 11
        {
            
        }

        private void ace_chose_label_Click(object sender, EventArgs e)
        {

        }
    }
}
