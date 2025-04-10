using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace Blackjack
{
    public class Deck
    {
        private List<Card> decks = new List<Card>();
        private Random random = new Random();

        public Deck()
        {
            foreach (Card.Suit suit in Enum.GetValues(typeof(Card.Suit)))
            {
                foreach (Card.FaceValue faceValue in Enum.GetValues(typeof(Card.FaceValue)))
                {
                    Card card = new Card(suit, faceValue);
                    decks.Add(card);
                }
            }
        }

        public void ShuffleDeck()
        {
            decks = decks.OrderBy(c => random.Next()).ToList();
        }

        public Card GetCard(int index)
        {
            return decks[index];
        }

        public void PrintDeck()
        {
            foreach (var card in decks)
            {
                Debug.WriteLine(card.ToString());
            }
        }
    }
}
