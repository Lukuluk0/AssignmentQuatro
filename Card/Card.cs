using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackk
{
    public class Card
    {
        private Color colour;
        private Number number;
        private string picture;

        public Color Colour { get { return colour; } set { colour = value; } }
        public Number Num { get { return number; } set { number = value; } }
        public string Picture { set { picture = value; } }
    }
}