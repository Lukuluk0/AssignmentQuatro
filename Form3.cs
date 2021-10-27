using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJackk
{
    public partial class Form3 : Form
    {
        private int numPlay;
        public Form3(int i)
        {
            InitializeComponent();
            numPlay = i;
        }

        public void GetPlayerName(ref Game game, int i)
        {
            if (string.IsNullOrEmpty(txt_player_name.Text))
            {
                game.setPlayerName("Player" + numPlay, i);
            }
            else
            {
                game.setPlayerName(txt_player_name.Text, i);
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            lbl_player_name.Text = "Player number " + numPlay + " chooses his name";
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
