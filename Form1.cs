using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace BlackJackk
{
    public partial class Form1 : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private List<PictureBox> play_pic;
        private List<PictureBox> deal_pic;
        private int turn = 0;

        Game game;
        public Form1()
        {
            InitializeComponent();
        }

        private void iniHand()
        {
            play_pic = new List<PictureBox>();
            deal_pic = new List<PictureBox>();
            play_pic.Add(pic_player1);
            play_pic.Add(pic_player2);
            play_pic.Add(pic_player3);
            play_pic.Add(pic_player4);
            deal_pic.Add(pic_croupier1);
            deal_pic.Add(pic_croupier2);
            deal_pic.Add(pic_croupier3);
            deal_pic.Add(pic_croupier4);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            iniHand();
            AllocConsole();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            game = new Game();
            f2.GetInfo(ref game);
            game.initialize();
            for (int i = 0; i < game.Nbr_player; i++)
            {
                Form3 f3 = new Form3(i + 1);
                f3.ShowDialog();
                f3.GetPlayerName(ref game, i);
            }
        }
        private void Start()
        {
     
        }

        private void Turn(int i)
        {
           
            Hand playerHand = new Hand();
            playerHand = (game.PlayerAt(i)).hand;
            //MessageBox.Show(playerHand.Size().ToString());
            DisplayCard(playerHand);
            
        }

        private void DisplayCard(Hand playHand)
        {
            for(int j=0; j<playHand.Size(); j++)
            {
                //pic_player1.ImageLocation = playHand.At(j).Picture; 
                play_pic[j].ImageLocation = playHand.At(j).Picture;
            }
        }

        private void btn_hit_Click(object sender, EventArgs e)
        {
            Turn(turn);
            game.PlayerAt(turn).AddInHand(game.TopDeck());
            turn++;
            if (turn >= game.Nbr_player) { turn = 0; }
            Turn(turn);
            //MessageBox.Show(game.PlayerAt(0).hand.At(0).Colour.ToString());
            //MessageBox.Show(game.PlayerAt(0).hand.At(0).Picture);
            //MessageBox.Show(haha.Size().ToString());
        }

        private void btn_stand_Click(object sender, EventArgs e)
        {
            
            Turn(turn);
            game.PlayerAt(turn).IsFinished = true;
            turn++;
            if (turn >= game.Nbr_player) { turn = 0; }
            Turn(turn);
        }
    }
}
