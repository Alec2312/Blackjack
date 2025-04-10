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
        private List<Label> playerLabels = new List<Label>();

        public Form1()
        {
            InitializeComponent();
            Deck.ShuffleDeck();
            this.WindowState = FormWindowState.Maximized;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Deck.PrintDeck();
            label1.Hide();
            button1.Hide();
            button2.Hide();
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void button1_Click(object sender, EventArgs e)
        {
            if (currentIndex >= 52)
            {
                label1.Text = "Geen kaarten meer";
            }
            else
            {
                Card drawnCard = Deck.GetCard(currentIndex);

                label1.Text = drawnCard.ToString();

                currentIndex++;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Deck.ShuffleDeck();
            currentIndex = 0;
            Deck.PrintDeck();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Visible = trackBar1.Value >= 1;
            pictureBox2.Visible = trackBar1.Value >= 2;
            pictureBox3.Visible = trackBar1.Value >= 3;
            pictureBox4.Visible = trackBar1.Value >= 4;

            labelPlayer1.Visible = trackBar1.Value >= 1;
            labelPlayer2.Visible = trackBar1.Value >= 2;
            labelPlayer3.Visible = trackBar1.Value >= 3;
            labelPlayer4.Visible = trackBar1.Value >= 4;
        }

        private void buttonSelectPlayers_Click(object sender, EventArgs e)
        {
            label1.Show();
            button1.Show();
            button2.Show();
            buttonSelectPlayers.Hide();
            trackBar1.Hide();
        }

        private void labelPlayer1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
