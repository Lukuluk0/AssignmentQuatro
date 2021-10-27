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
        Game game;
        public Form1()
        {
            InitializeComponent();
            
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        private void Form1_Load(object sender, EventArgs e)
        {
            
            AllocConsole();
            //Console.WriteLine("test");
           
            /*Card card = new Card();
            card.Picture = "C:/Users/zamra/Desktop/AssignmentQuatro/images/Ace_Clubs.png";
            pic_croupier1.ImageLocation = card.Picture;*/
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
                Form3 f3 = new Form3(i+1);
                f3.ShowDialog();
                f3.GetPlayerName(ref game,i);
                
            }

            // MessageBox.Show(game.Nbr_deck.ToString());
        }
        private void Start()
        {
            //game.start();
        }
    }
}
