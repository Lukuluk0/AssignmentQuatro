using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackk
{
    public class Game
    {
        private List<Player> players;
        private Deck decks;
        private int nbr_deck;
        private int nbr_player;

        public int Nbr_deck { get { return nbr_deck; } set { nbr_deck = value; } }
        public int Nbr_player { get { return nbr_player; } set { nbr_player = value; } }
        public void setPlayerName(string txt_player_name,int i)
        {
            players[i].Name = txt_player_name;
        }
        
        public void initialize()
        {
            players = new List<Player>();
            decks = new Deck();
            
            decks.CreateDeck(nbr_deck);
            
            for (int i = 0; i < nbr_player; i++)///METTRE LA LE FORM  3
            {
                Player player = new Player();
                player.Name = "player" + (i + 1).ToString();
                players.Add(player);
            }
        }

        public Player PlayerAt(int i)
        {
            return players[i];
        }

        public Card TopDeck()
        {
            Card draw = new Card();
            draw = decks.GetAt((decks.Count) - 1);
            decks.RemoveCard((decks.Count) - 1);
            return draw;
        }
    }
}