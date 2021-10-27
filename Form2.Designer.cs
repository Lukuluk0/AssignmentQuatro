
namespace BlackJackk
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_nbr_player = new System.Windows.Forms.TextBox();
            this.txt_nbr_deck = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.PlayerNumber = new System.Windows.Forms.Label();
            this.NumberDecks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_nbr_player
            // 
            this.txt_nbr_player.Location = new System.Drawing.Point(58, 100);
            this.txt_nbr_player.Name = "txt_nbr_player";
            this.txt_nbr_player.Size = new System.Drawing.Size(206, 27);
            this.txt_nbr_player.TabIndex = 1;
            // 
            // txt_nbr_deck
            // 
            this.txt_nbr_deck.Location = new System.Drawing.Point(58, 35);
            this.txt_nbr_deck.Name = "txt_nbr_deck";
            this.txt_nbr_deck.Size = new System.Drawing.Size(206, 27);
            this.txt_nbr_deck.TabIndex = 2;
            this.txt_nbr_deck.TabStop = false;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(285, 120);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(37, 30);
            this.btn_close.TabIndex = 3;
            this.btn_close.Text = "Ok";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // PlayerNumber
            // 
            this.PlayerNumber.AutoSize = true;
            this.PlayerNumber.Location = new System.Drawing.Point(58, 77);
            this.PlayerNumber.Name = "PlayerNumber";
            this.PlayerNumber.Size = new System.Drawing.Size(138, 20);
            this.PlayerNumber.TabIndex = 4;
            this.PlayerNumber.Text = "Number of Players :";
            // 
            // NumberDecks
            // 
            this.NumberDecks.AutoSize = true;
            this.NumberDecks.Location = new System.Drawing.Point(58, 9);
            this.NumberDecks.Name = "NumberDecks";
            this.NumberDecks.Size = new System.Drawing.Size(129, 20);
            this.NumberDecks.TabIndex = 5;
            this.NumberDecks.Text = "Number of decks :";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 152);
            this.Controls.Add(this.NumberDecks);
            this.Controls.Add(this.PlayerNumber);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_nbr_deck);
            this.Controls.Add(this.txt_nbr_player);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_nbr_player;
        private System.Windows.Forms.TextBox txt_nbr_deck;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Label PlayerNumber;
        private System.Windows.Forms.Label NumberDecks;
    }
}