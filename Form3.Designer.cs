
namespace BlackJackk
{
    partial class Form3
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
            this.lbl_player_name = new System.Windows.Forms.Label();
            this.txt_player_name = new System.Windows.Forms.TextBox();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_player_name
            // 
            this.lbl_player_name.AutoSize = true;
            this.lbl_player_name.Location = new System.Drawing.Point(42, 22);
            this.lbl_player_name.Name = "lbl_player_name";
            this.lbl_player_name.Size = new System.Drawing.Size(50, 20);
            this.lbl_player_name.TabIndex = 0;
            this.lbl_player_name.Text = "label1";
            // 
            // txt_player_name
            // 
            this.txt_player_name.Location = new System.Drawing.Point(42, 55);
            this.txt_player_name.Name = "txt_player_name";
            this.txt_player_name.Size = new System.Drawing.Size(181, 27);
            this.txt_player_name.TabIndex = 1;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(204, 99);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(64, 29);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 132);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.txt_player_name);
            this.Controls.Add(this.lbl_player_name);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_player_name;
        private System.Windows.Forms.TextBox txt_player_name;
        private System.Windows.Forms.Button btn_close;
    }
}