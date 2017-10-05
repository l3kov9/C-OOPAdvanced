using _01.Cards.Enums;
using System;

namespace _01.Cards.Models
{
    public class Card : IComparable<Card>
    {
        public Card(string rank, string suit)
        {
            this.Rank = (Rank)Enum.Parse(typeof(Rank), rank);
            this.Suit = (Suit)Enum.Parse(typeof(Suit), suit);
            this.Power = (int)this.Rank + (int)this.Suit;
        }

        public Rank Rank { get; set; }

        public Suit Suit { get; set; }

        public int Power { get; set; }

        public int CompareTo(Card other)
        {
            var result = (this.Rank.ToString().CompareTo(other.Rank.ToString()));
            if (result != 0)
            {
                return result;
            }

            return this.Suit.ToString().CompareTo(other.Suit.ToString());
        }

        public override string ToString()
        {
            return $"Card name: {Rank} of {Suit}; Card power: {this.Power}";
        }
    }
}
