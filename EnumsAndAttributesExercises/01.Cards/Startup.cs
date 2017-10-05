using _01.Cards.Enums;
using _01.Cards.Models;
using System;

namespace _01.Cards
{
    public class Startup
    {
        public static void Main()
        {
            var cardSuits = Enum.GetValues(typeof(Suit));
            var cardRanks = Enum.GetValues(typeof(Rank));

            PrintAllCards(cardSuits, cardRanks);

            var enumeration = Console.ReadLine();
            Type type = enumeration == "Suit" ? typeof(Suit) : typeof(Rank);
            var result = type.GetCustomAttributes(false);
            Console.WriteLine(string.Join(Environment.NewLine,result));
        }

        private static void PrintAllCards(Array cardSuits, Array cardRanks)
        {
            foreach (var suit in cardSuits)
            {
                foreach (var rank in cardRanks)
                {
                    var card = new Card(rank.ToString(), suit.ToString());
                    Console.WriteLine($"{rank} of {suit}");
                }
            }
        }

        private static Card GetBiggerCard(Card firstCard, Card secondCard)
        {
            return firstCard.CompareTo(secondCard) < 0 ? firstCard : secondCard;
        }

        private static Card GetCard()
        {
            var rank = Console.ReadLine();
            var suit = Console.ReadLine();
            return new Card(rank, suit);
        }
    }
}
