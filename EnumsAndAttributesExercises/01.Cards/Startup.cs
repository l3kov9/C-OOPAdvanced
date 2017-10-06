using _01.Cards.Enums;
using _01.Cards.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Cards
{
    public class Startup
    {
        public static void Main()
        {
            ReadCards();
        }

        private static void ReadCards()
        {
            var firstPlayer = Console.ReadLine();
            var secondPlayer = Console.ReadLine();

            var firstPlayerDeck = new HashSet<Card>();
            var secondPlayerDeck = new HashSet<Card>();

            GetPlayerDeck(firstPlayerDeck);
            GetPlayerDeck(secondPlayerDeck);

            string winner = GetWinner(firstPlayerDeck, secondPlayerDeck);
            Console.WriteLine(winner);
        }

        private static string GetWinner(HashSet<Card> firstPlayerDeck, HashSet<Card> secondPlayerDeck)
        {
            var firstPlayerPoints = firstPlayerDeck.ToList().Select(x => x.Power).Sum();
            var secondPlayerPoints = secondPlayerDeck.ToList().Select(x => x.Power).Sum();

            return firstPlayerPoints > secondPlayerPoints ? $"First Player wins." : "Second Player wins.";
        }

        private static void GetPlayerDeck(HashSet<Card> playerDeck)
        {
            while (playerDeck.Count < 5)
            {
                var currentLenght = playerDeck.Count;
                var card = ReadCard();
                if (card != null)
                {
                    if (playerDeck.Any(x=>x.Rank==card.Rank && x.Suit==card.Suit))
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                    else
                    {
                        playerDeck.Add(card);
                    }
                }
            }
            string debug = "";
        }

        private static Card ReadCard()
        {
            var cardInfo = Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var rank = cardInfo[0];
            var suit = cardInfo[2];
            try
            {
                var card = new Card(rank, suit);
                return card;
            }
            catch (Exception)
            {
                Console.WriteLine("No such card exists.");
            }
            return null;
        }

        private static void GetEnumAttributeInfo()
        {
            Console.WriteLine("Rank or Suit");
            var enumeration = Console.ReadLine();
            Type type = enumeration == "Suit" ? typeof(Suit) : typeof(Rank);
            var result = type.GetCustomAttributes(false);
            Console.WriteLine(string.Join(Environment.NewLine, result));
        }

        private static void PrintAllCards()
        {
            var cardSuits = Enum.GetValues(typeof(Suit));
            var cardRanks = Enum.GetValues(typeof(Rank));

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
