using System.Collections.Generic;
using System.Linq;

namespace Blackjack
{
    public class Player
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
            Hand = new List<Card>();
            ResetStatus();
        }

        public void AddCard(Card card)
        {
            Hand.Add(card);
            CalculatePoints();
        }

        public void CalculatePoints()
        {
            Points = Hand.Sum(card => (int)card.faceValue);
        }

        public string GetPlayerDetails()
        {
            string handDetails = string.Join(", ", Hand.Select(c => c.ToString()));
            return $"{Name} - Points: {Points}, Cards: {handDetails}";
        }

        public void ResetHand()
        {
            Hand.Clear();
            ResetStatus();
        }

        private void ResetStatus()
        {
            Points = 0;
            IsBusted = false;
            IsStanding = false;
            IsDoublingDown = false;
            IsSplitting = false;
        }
    }
}
