
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
            this.SuspendLayout();
            // 
            // txt_nbr_player
            // 
            this.txt_nbr_player.Location = new System.Drawing.Point(58, 103);
            this.txt_nbr_player.Name = "txt_nbr_player";
            this.txt_nbr_player.Size = new System.Drawing.Size(206, 27);
            this.txt_nbr_player.TabIndex = 1;
            // 
            // txt_nbr_deck
            // 
            this.txt_nbr_deck.Location = new System.Drawing.Point(58, 48);
            this.txt_nbr_deck.Name = "txt_nbr_deck";
            this.txt_nbr_deck.Size = new System.Drawing.Size(206, 27);
            this.txt_nbr_deck.TabIndex = 2;
            this.txt_nbr_deck.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 152);
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
    }
}