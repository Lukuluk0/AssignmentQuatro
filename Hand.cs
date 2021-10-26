using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackk
{
    public class Hand
    {
        private List<Card> m_hand;

        public void Add(Card a)
        {
            m_hand.Add(a);
        }

        public int Size()
        {
            return m_hand.Count();
        }
    }
}