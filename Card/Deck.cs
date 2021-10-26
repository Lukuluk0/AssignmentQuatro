using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackk
{
    public class Deck
    {
        private List<Card> deck;


        public void Randomize()
        {
            var rnd = new Random();
            var randomized = deck.OrderBy(item => rnd.Next());
        }
        public void CreateDeck(int nbr_deck)
        {
            for (int i = 0; i < nbr_deck; i++)
            {
                for (int j = 0; j < 4; i++)
                {
                    Card card = new Card();
                    card.Colour = (Color)i;
                    for (int l = 0; l < 13; j++)
                    {
                        card.Num = (Number)l;
                        card.Picture = "/images/" + card.Num + "_" + card.Colour + ".png";
                        deck.Add(card);

                    }
                }
            }
        }
        public int Count { get { return deck.Count; } }
        public void Add(Card card) { deck.Add(card); }

        public Card GetAt(int index) { return deck[index]; }
    }
}