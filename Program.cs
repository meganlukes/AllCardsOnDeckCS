using System;
using System.Collections.Generic;

namespace AllCardsOnDeckCS
{
    class Program
    {
        static void Main(string[] args)
        {

            //Instantiate deck using aces as initial values
            var deck = new List<string>() { "Ace of Hearts", "Ace of Clubs", "Ace of Diamonds", "Ace of Spades" };

            //Suits to simplify creation of new cards
            var suits = new string[] { " of Hearts", " of Clubs", " of Diamonds", " of Spades" };

            //Add numbered cards to deck
            for (var i = 2; i < 11; i++)
            {
                String newCard = i.ToString() + suits[0];
                deck.Add(newCard);
            }
            for (var i = 2; i < 11; i++)
            {
                String newCard = i.ToString() + suits[1];
                deck.Add(newCard);
            }
            for (var i = 2; i < 11; i++)
            {
                String newCard = i.ToString() + suits[2];
                deck.Add(newCard);
            }
            for (var i = 2; i < 11; i++)
            {
                String newCard = i.ToString() + suits[3];
                deck.Add(newCard);
            }

            //Add Face Cards to Deck
            for (var i = 0; i < 4; i++)
            {
                String newJack = "Jack" + suits[i];
                String newQueen = "Queen" + suits[i];
                String newKing = "King" + suits[i];
                deck.Add(newJack);
                deck.Add(newQueen);
                deck.Add(newKing);
            }

            //Number of cards in deck
            var deckSize = deck.Count;

            //Shuffle Deck
            for (var rightIndex = deckSize - 1; rightIndex >= 0; rightIndex--)
            {
                var leftIndex = new Random().Next(0, rightIndex);
                var rightCard = deck[rightIndex];
                deck[rightIndex] = deck[leftIndex];
                deck[leftIndex] = rightCard;
            }

            //Reveal Two Cards
            Console.WriteLine(deck[0]);
            Console.WriteLine(deck[1]);

            //Hand
            var hand = new List<string>() { deck[0], deck[1] };
        }
    }
}

