using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackk
{
    public class Hand
    {
        private List<Card> m_hand;

        public Hand()
        {
            m_hand = new List<Card>();
        }
        public List<Card> Main
        {
            get { return m_hand; }
            set { m_hand = value; }
        }
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

        public int CalculPoint()
        {
            int point = 0;
            for(int i=0; i<m_hand.Count(); i++)
            {
                point += m_hand[i].Point;
            }
            return point;
        }
    }
}