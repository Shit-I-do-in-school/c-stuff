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

namespace BlackJackGame_App// version 1
{
    public partial class Form1 : Form
    {
        Deck deck = null;
        BasicOps basicOps = null;

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

            deck.shuffle();

            dealerCards[0] = deck.draw();
            dealerCards[1] = deck.draw();
            dealer = basicOps.checkCard(dealerCards, dealer, 0);

            playerCards[0] = deck.draw();
            player = int.Parse(playerCards[0].Split(' ')[1]);


            dealer_card.Text = "Delaer Cards: " + dealerCards[0] + "\n";
            dealer_score.Text = "Dealer points: " + dealer.ToString();

            player_card.Text = "Your Cards: " + playerCards[0] + "\n";
            player_score.Text = "Your points: " + player.ToString();
        }


        private void button1_Click(object sender, EventArgs e)//draw card button
        {
            drawpos++;

            playerCards[drawpos] = deck.draw();
            player = basicOps.checkCard(playerCards, player, drawpos);


            player_score.Text = "Your points: " + player.ToString();
            player_card.Text = player_card.Text + "Your Cards: " + playerCards[drawpos] + "\n";


            if (player > 21)// player lost, no need for dealer to draw cards
            {
                dealer = basicOps.checkCard(dealerCards, dealer, 1);
                dealer_score.Text = "Dealer points: " + dealer.ToString();
                dealer_card.Text = dealer_card.Text + "Delaer Cards: " + dealerCards[1] + "\n";


                MessageBox.Show(basicOps.isWin(player, dealer));
                System.Windows.Forms.Application.Exit();
            }
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
            dealer = basicOps.checkCard(dealerCards, dealer, 1);// check if held card is ace

            drawpos = 2;
            while (dealer < 14)// dealer draws cards until its above 13
            {
                dealerCards[drawpos] = deck.draw();
                dealer = basicOps.checkCard(dealerCards, dealer, drawpos);
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
