using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackk
{
    public class Deck
    {
        private List<Card> deck;
        private static Random rng = new Random();

        public Deck()
        {
            deck = new List<Card>();
        }

        public void Randomize()
        {
            int n = deck.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                Card value = deck[k];
                deck[k] = deck[n];
                deck[n] = value;
            }
        }
        public void CreateDeck(int nbr_deck)
        {
            deck = new List<Card>();
           
            for (int i = 0; i < nbr_deck; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    for (int l = 0; l < 13; l++)
                    {
                        Card card = new Card();
                        card.Colour = (Color)j;
                        card.Num = (Number)l;
                        card.Picture = "C:/Users/zamra/Desktop/AssignmentQuatro/images/" + card.Num.ToString() + "_" + card.Colour.ToString() + ".png";
                        deck.Add(card);
                    }
                }
            }
            Randomize();
        }

        
        public int Count { get { return deck.Count; } }
        public void Add(Card card) { deck.Add(card); }

        public Card GetAt(int index) { return deck[index]; }

        public void RemoveCard() { deck.Remove(deck.Last()); }
    }
}