using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Blackjack
{
    public partial class Form1 : Form
    {
        private Deck Deck = new Deck();
        private int currentIndex = 0;
        private List<Player> players = new List<Player>();
        private int numberOfPlayers = 4;
        private Card lastDrawnCard;

        public Form1()
        {
            InitializeComponent();
            Deck.ShuffleDeck();
            this.WindowState = FormWindowState.Maximized;
            trackBar1.Value = numberOfPlayers;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Deck.PrintDeck();
            label1.Hide();
            button1.Hide();
            button2.Hide();
            playerButton1.Hide();
            playerButton2.Hide();
            playerButton3.Hide();
            playerButton4.Hide();
            listBoxPlayerDetails.Hide();
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click_1(object sender, EventArgs e) { }
        private void pictureBox2_Click_1(object sender, EventArgs e) { }
        private void pictureBox3_Click(object sender, EventArgs e) { }
        private void pictureBox4_Click(object sender, EventArgs e) { }
        private void labelPlayer1_Click(object sender, EventArgs e) { }
        private void labelPlayer2_Click(object sender, EventArgs e) { }
        private void labelPlayer3_Click(object sender, EventArgs e) { }
        private void labelPlayer4_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 52)
            {
                label1.Text = "Geen kaarten meer";
                lastDrawnCard = null;
                return;
            }
            lastDrawnCard = Deck.GetCard(currentIndex);
            label1.Text = "Huidige Kaart: " + lastDrawnCard.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deck.ShuffleDeck();
            currentIndex = 0;
            lastDrawnCard = null;
            Deck.PrintDeck();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            numberOfPlayers = trackBar1.Value;
            pictureBox1.Visible = numberOfPlayers >= 1;
            pictureBox2.Visible = numberOfPlayers >= 2;
            pictureBox3.Visible = numberOfPlayers >= 3;
            pictureBox4.Visible = numberOfPlayers >= 4;

            labelPlayer1.Visible = numberOfPlayers >= 1;
            labelPlayer2.Visible = numberOfPlayers >= 2;
            labelPlayer3.Visible = numberOfPlayers >= 3;
            labelPlayer4.Visible = numberOfPlayers >= 4;

            playerButton1.Visible = numberOfPlayers >= 1;
            playerButton2.Visible = numberOfPlayers >= 2;
            playerButton3.Visible = numberOfPlayers >= 3;
            playerButton4.Visible = numberOfPlayers >= 4;
        }

        private void buttonSelectPlayers_Click(object sender, EventArgs e)
        {
            listBoxPlayerDetails.Show();
            players.Clear();
            for (int i = 1; i <= numberOfPlayers; i++)
                players.Add(new Player($"Player {i}"));

            label1.Show();
            button1.Show();
            button2.Show();
            trackBar1.Hide();
            buttonSelectPlayers.Hide();

            playerButton1.Visible = numberOfPlayers >= 1;
            playerButton2.Visible = numberOfPlayers >= 2;
            playerButton3.Visible = numberOfPlayers >= 3;
            playerButton4.Visible = numberOfPlayers >= 4;

            DisplayPlayerDetails();
        }

        private void DisplayPlayerDetails()
        {
            listBoxPlayerDetails.Items.Clear();
            foreach (var p in players)
                listBoxPlayerDetails.Items.Add(p.GetPlayerDetails());
        }

        private void GiveCardToPlayer(int idx)
        {
            if (lastDrawnCard == null)
            {
                MessageBox.Show("Trek eerst een kaart met de 'Pak Bovenste Kaart' knop.");
                return;
            }
            players[idx].AddCard(lastDrawnCard);
            currentIndex++;
            lastDrawnCard = null;
            DisplayPlayerDetails();
        }


        private void playerButton2_Click(object sender, EventArgs e) => GiveCardToPlayer(1);
        private void playerButton3_Click(object sender, EventArgs e) => GiveCardToPlayer(2);
        private void playerButton4_Click(object sender, EventArgs e) => GiveCardToPlayer(3);

        private void playerButton1_Click_2(object sender, EventArgs e)
        {
            GiveCardToPlayer(0);

        }

        private void playerButton2_Click_1(object sender, EventArgs e)
        {
            GiveCardToPlayer(1);
        }

        private void playerButton3_Click_1(object sender, EventArgs e)
        {
            GiveCardToPlayer(2);
        }

        private void playerButton4_Click_1(object sender, EventArgs e)
        {
            GiveCardToPlayer(3);
        }

    }
}
