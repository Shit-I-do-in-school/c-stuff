namespace BlackJackGame_App
{
    partial class Form1
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
            this.draw_next_card_button = new System.Windows.Forms.Button();
            this.player_score = new System.Windows.Forms.Label();
            this.dealer_score = new System.Windows.Forms.Label();
            this.stand = new System.Windows.Forms.Button();
            this.player_card = new System.Windows.Forms.Label();
            this.dealer_card = new System.Windows.Forms.Label();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.SuspendLayout();
            // 
            // draw_next_card_button
            // 
            this.draw_next_card_button.Location = new System.Drawing.Point(264, 237);
            this.draw_next_card_button.Name = "draw_next_card_button";
            this.draw_next_card_button.Size = new System.Drawing.Size(82, 65);
            this.draw_next_card_button.TabIndex = 0;
            this.draw_next_card_button.Text = "Draw Card";
            this.draw_next_card_button.UseVisualStyleBackColor = true;
            this.draw_next_card_button.Click += new System.EventHandler(this.button1_Click);
            // 
            // player_score
            // 
            this.player_score.AutoSize = true;
            this.player_score.Location = new System.Drawing.Point(188, 54);
            this.player_score.Name = "player_score";
            this.player_score.Size = new System.Drawing.Size(87, 16);
            this.player_score.TabIndex = 2;
            this.player_score.Text = "Your points: 0";
            this.player_score.Click += new System.EventHandler(this.player_score_Click);
            // 
            // dealer_score
            // 
            this.dealer_score.AutoSize = true;
            this.dealer_score.Location = new System.Drawing.Point(458, 54);
            this.dealer_score.Name = "dealer_score";
            this.dealer_score.Size = new System.Drawing.Size(100, 16);
            this.dealer_score.TabIndex = 3;
            this.dealer_score.Text = "Dealer points: 0";
            this.dealer_score.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // stand
            // 
            this.stand.Location = new System.Drawing.Point(420, 237);
            this.stand.Name = "stand";
            this.stand.Size = new System.Drawing.Size(82, 65);
            this.stand.TabIndex = 4;
            this.stand.Text = "Stand";
            this.stand.UseVisualStyleBackColor = true;
            this.stand.Click += new System.EventHandler(this.stand_Click);
            // 
            // player_card
            // 
            this.player_card.AutoSize = true;
            this.player_card.Location = new System.Drawing.Point(188, 105);
            this.player_card.Name = "player_card";
            this.player_card.Size = new System.Drawing.Size(0, 16);
            this.player_card.TabIndex = 5;
            // 
            // dealer_card
            // 
            this.dealer_card.AutoSize = true;
            this.dealer_card.Location = new System.Drawing.Point(458, 105);
            this.dealer_card.Name = "dealer_card";
            this.dealer_card.Size = new System.Drawing.Size(0, 16);
            this.dealer_card.TabIndex = 6;
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dealer_card);
            this.Controls.Add(this.player_card);
            this.Controls.Add(this.stand);
            this.Controls.Add(this.dealer_score);
            this.Controls.Add(this.player_score);
            this.Controls.Add(this.draw_next_card_button);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button draw_next_card_button;
        private System.Windows.Forms.Label player_score;
        private System.Windows.Forms.Label dealer_score;
        private System.Windows.Forms.Button stand;
        private System.Windows.Forms.Label player_card;
        private System.Windows.Forms.Label dealer_card;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
    }
}

