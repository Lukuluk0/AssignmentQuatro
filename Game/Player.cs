﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackJackk
{
    public class Player
    {
        private string name;
        private int Hand_score;
        private int point;
        private Hand main;
        private bool isfinished;
        private int nbrPartie;
        private int nbrWin;

        public Player()
        {
            main = new Hand();
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public void AddInHand(Card a)
        {
            main.Add(a);
        }
        public void ctpHandScore()
        {
            Hand_score = 0;
            for (int a = 0; a < main.Size(); a++)
            {
                //Hand_score += main[a].Num;
            }
        }

        public Hand hand
        {
            get { return main; }
            set { main = value; }
        }

        public bool IsFinished
        {
            get { return isfinished; }
            set { isfinished = value; }
        }
    }
}