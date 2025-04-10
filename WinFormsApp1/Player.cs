using System;
using System.Collections.Generic;

namespace Blackjack
{
    class Player
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public List<Card> Hand { get; set; }
        public bool IsBusted { get; set; }
        public bool IsStanding { get; set; }
        public bool IsDoublingDown { get; set; }
        public bool IsSplitting { get; set; }

        public Player(string name)
        {
            Name = name;
            Points = 0;
            Hand = new List<Card>();
            IsBusted = false;
            IsStanding = false;
            IsDoublingDown = false;
            IsSplitting = false;
        }

        public void AddCard(Card card)
        {
            Hand.Add(card);
            CalculatePoints();
        }

        public void CalculatePoints()
        {
            Points = 0;
            foreach (var card in Hand)
            {
                Points += (int)card.faceValue;
            }
        }

        public void ResetHand()
        {
            Hand.Clear();
            Points = 0;
            IsBusted = false;
            IsStanding = false;
            IsDoublingDown = false;
            IsSplitting = false;
        }
    }
}