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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void GetInfo(ref Game game)
        {
            int i = 0;
            if (string.IsNullOrEmpty(txt_nbr_deck.Text)|| string.IsNullOrEmpty(txt_nbr_player.Text))
            {
                MessageBox.Show("invalid input");
                this.ShowDialog();
            }
            else { game.Nbr_deck = Int32.Parse(txt_nbr_deck.Text);
                game.Nbr_player = Int32.Parse(txt_nbr_player.Text);
            }
           
        }
    }
}
