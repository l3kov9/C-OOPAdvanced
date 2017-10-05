using _01.Cards.Attributes;
using System;

namespace _01.Cards.Enums
{
    [Flags]
    [Type("Enumeration", "Suit", "Provides suit constants for a Card class.")]
    public enum Suit
    {
        Clubs = 0,
        Diamonds = 13,
        Hearts = 26,
        Spades = 39
    }
}
