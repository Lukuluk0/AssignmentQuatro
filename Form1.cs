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
        Hand croupier;
        public Form1()
        {
            InitializeComponent();
        }

        private void iniHand()
        {
            play_pic = new List<PictureBox>();
            deal_pic = new List<PictureBox>();
            play_pic.Add(pic_croupier1);
            play_pic.Add(pic_croupier2);
            play_pic.Add(pic_croupier3);
            play_pic.Add(pic_croupier4);
            play_pic.Add(pic_croupier5);
            play_pic.Add(pic_croupier6);
            deal_pic.Add(pic_player1);
            deal_pic.Add(pic_player4);
            deal_pic.Add(pic_player3);
            deal_pic.Add(pic_player2);
            deal_pic.Add(pic_player5);
            deal_pic.Add(pic_player6);
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
            croupier = new Hand();
            //croupier.Add(game.TopDeck(game.nbrCardDeck() - 1));
            f2.GetInfo(ref game);
            game.initialize();
            for (int i = 0; i < game.Nbr_player; i++)
            {
                Form3 f3 = new Form3(i + 1);
                f3.ShowDialog();
                f3.GetPlayerName(ref game, i);
            }
            lbl_TotalDeck.Text = (game.nbrCardDeck()).ToString();
            btn_hit.Enabled = true;
            btn_stand.Enabled = true;
            btn_shuffle.Enabled = true;
            Crouplar();
        }
        
        private bool GameOver()
        {
            bool cbon = true;
            for (int i = 0; i < game.Nbr_player; i++)
            {
                if (game.PlayerAt(i).IsFinished == false)
                {
                    cbon = false;
                }
            }
            return cbon;
        }
        
        private void EndGame()
        {
            lbl_player.Text = "";
            lbl_point.Text = "";
            lbl_TotalDeck.Text = "";
            lbl_CardRemaining.Text = "";
            btn_hit.Enabled = false;
            btn_ok.Enabled = false;
            btn_stand.Enabled = false;
            btn_shuffle.Enabled = false;
            for (int i = 0; i < game.PlayerAt(turn).hand.Size(); i++)
            {
                play_pic[i].ImageLocation = null;
            }
        }
        private void Turn(int i)
        {
            Hand playerHand = new Hand();
            lbl_player.Text = game.PlayerAt(turn).Name;
            playerHand = (game.PlayerAt(turn)).hand;
            lbl_point.Text = game.PlayerAt(turn).hand.CalculPoint().ToString();
            if(game.PlayerAt(turn).hand.CalculPoint() >= 21)
            {
                game.PlayerAt(turn).IsFinished = true;
            }
            DisplayCard(playerHand);
            if(GameOver() == true)
            {
                BestPlayer();
                Restart();
            }
        }
        private void BestPlayer()
        {
            Player player = new Player();
            int temoin = 0;
            for (int i = 0; i < game.Nbr_player; i++)
            {
                if (game.PlayerAt(i).hand.CalculPoint() < 22)
                {
                    if ((game.PlayerAt(i).hand.CalculPoint() > temoin))
                    {
                        temoin = game.PlayerAt(i).hand.CalculPoint();
                        player = game.PlayerAt(i);
                    }
                }
            }
            MessageBox.Show("The best player is : " + player.Name);
        }
        private void DisplayCard(Hand playHand)
        {
            for (int j = playHand.Size()-1; j >=0 ; j--)
            {
                play_pic[j].Visible = true;
                play_pic[j].ImageLocation = playHand.At(playHand.Size()-1 - j).Picture;
            }
        }

        private void btn_hit_Click(object sender, EventArgs e)
        {
            Turn(turn);
            if (game.PlayerAt(turn).IsFinished == false)
            {
                game.PlayerAt(turn).AddInHand(game.TopDeck(game.nbrCardDeck() - 1));
            }
            lbl_CardRemaining.Text = (game.nbrCardDeck()).ToString();
            btn_stand.Enabled = false;
            btn_hit.Enabled = false;
            btn_ok.Enabled = true;
            Turn(turn);
        }

        private void btn_stand_Click(object sender, EventArgs e)
        {
            Turn(turn);
            game.PlayerAt(turn).IsFinished = true;
            btn_stand.Enabled = false;
            btn_hit.Enabled = false;
            btn_ok.Enabled = true;
            Turn(turn);
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < game.PlayerAt(turn).hand.Size(); i++)
            {
                play_pic[i].ImageLocation = null;
            }
            turn++;
            if (turn == game.Nbr_player)
            {
                Crouplar();
                turn = 0;
            }
            if (game.PlayerAt(turn).IsFinished == false)
            {
                btn_stand.Enabled = true;
                btn_hit.Enabled = true;
                btn_ok.Enabled = false;
            }
            else
            {
                btn_ok.Enabled = true;
            }
            Turn(turn);
        }

        private void Restart()
        {
            lbl_player.Text = "";
            lbl_point.Text = "0";
            lbl_CardRemaining.Text = "";
            lbl_point_croup.Text = "0";
            for (int i = 0; i < game.PlayerAt(turn).hand.Size(); i++)
            {
                play_pic[i].ImageLocation = null;
            }
            for (int i = 0; i < croupier.Size(); i++)
            {
                deal_pic[i].ImageLocation = null;
            }
            for (int j = 0; j < game.Nbr_player; j++)
            {
                game.PlayerAt(j).hand.Clear();
                game.PlayerAt(j).IsFinished = false;
            }
            croupier.Clear();
            turn = 0;
            btn_hit.Enabled = true;
            btn_ok.Enabled = false;
            btn_stand.Enabled = true;
            btn_shuffle.Enabled = true;
        }
        private void Crouplar()
        {
            if (croupier.CalculPoint() <= 17)
            {
                croupier.Add(game.TopDeck(game.nbrCardDeck() - 1));
            }
            lbl_point_croup.Text = croupier.CalculPoint().ToString();
            DisplayCrouplard();
        }
        private void DisplayCrouplard()
        {
            for (int j = croupier.Size() - 1; j >= 0; j--)
            {
                deal_pic[j].Visible = true;
                deal_pic[j].ImageLocation = croupier.At(croupier.Size() - 1 - j).Picture;
            }
        }
    }
}
