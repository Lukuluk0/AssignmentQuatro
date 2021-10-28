using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackk
{
    public class Hand
    {
        private List<Card> m_hand;

        public Hand() { m_hand = new List<Card>(); }
        public void Add(Card a)
        {
            m_hand.Add(a);
        }

        public int Size()
        {
            try
            {
                return m_hand.Count();
            }catch
            {
                return 0;
            }
        }
        
        public Card At(int i)
        {
            return m_hand[i];
        }
    }
}