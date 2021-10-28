using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackk
{
    public class Card
    {
        private Color colour;
        private int point;
        private Number number;
        private string picture;

        public Color Colour { get { return colour; } set { colour = value; } }
        public Number Num 
        {
            get { return number; } 
            set 
            { 
                number = value;
                point = (int)number; 
            }
        }

        public int Point
        {
            get { return point; }
        }
        public string Picture { get { return picture; } set { picture = value; } }
    }
}