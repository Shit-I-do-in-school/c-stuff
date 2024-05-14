namespace BlackJack_optimised_ish
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
            this.label_player_score = new System.Windows.Forms.Label();
            this.label_dealer_score = new System.Windows.Forms.Label();
            this.button_draw = new System.Windows.Forms.Button();
            this.button_stand = new System.Windows.Forms.Button();
            this.label_player_cards = new System.Windows.Forms.Label();
            this.label_dealer_cards = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_player_score
            // 
            this.label_player_score.AutoSize = true;
            this.label_player_score.Location = new System.Drawing.Point(190, 52);
            this.label_player_score.Name = "label_player_score";
            this.label_player_score.Size = new System.Drawing.Size(87, 16);
            this.label_player_score.TabIndex = 0;
            this.label_player_score.Text = "Your points: 0";
            // 
            // label_dealer_score
            // 
            this.label_dealer_score.AutoSize = true;
            this.label_dealer_score.Location = new System.Drawing.Point(419, 52);
            this.label_dealer_score.Name = "label_dealer_score";
            this.label_dealer_score.Size = new System.Drawing.Size(100, 16);
            this.label_dealer_score.TabIndex = 1;
            this.label_dealer_score.Text = "Dealer points: 0";
            // 
            // button_draw
            // 
            this.button_draw.Location = new System.Drawing.Point(193, 221);
            this.button_draw.Name = "button_draw";
            this.button_draw.Size = new System.Drawing.Size(85, 63);
            this.button_draw.TabIndex = 2;
            this.button_draw.Text = "Draw Card";
            this.button_draw.UseVisualStyleBackColor = true;
            this.button_draw.Click += new System.EventHandler(this.button_draw_Click);
            // 
            // button_stand
            // 
            this.button_stand.Location = new System.Drawing.Point(422, 221);
            this.button_stand.Name = "button_stand";
            this.button_stand.Size = new System.Drawing.Size(85, 63);
            this.button_stand.TabIndex = 3;
            this.button_stand.Text = "Stand";
            this.button_stand.UseVisualStyleBackColor = true;
            this.button_stand.Click += new System.EventHandler(this.button2_Click);
            // 
            // label_player_cards
            // 
            this.label_player_cards.AutoSize = true;
            this.label_player_cards.Location = new System.Drawing.Point(193, 89);
            this.label_player_cards.Name = "label_player_cards";
            this.label_player_cards.Size = new System.Drawing.Size(75, 16);
            this.label_player_cards.TabIndex = 4;
            this.label_player_cards.Text = "Your cards:";
            // 
            // label_dealer_cards
            // 
            this.label_dealer_cards.AutoSize = true;
            this.label_dealer_cards.Location = new System.Drawing.Point(422, 88);
            this.label_dealer_cards.Name = "label_dealer_cards";
            this.label_dealer_cards.Size = new System.Drawing.Size(88, 16);
            this.label_dealer_cards.TabIndex = 5;
            this.label_dealer_cards.Text = "Dealer cards:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_dealer_cards);
            this.Controls.Add(this.label_player_cards);
            this.Controls.Add(this.button_stand);
            this.Controls.Add(this.button_draw);
            this.Controls.Add(this.label_dealer_score);
            this.Controls.Add(this.label_player_score);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_player_score;
        private System.Windows.Forms.Label label_dealer_score;
        private System.Windows.Forms.Button button_draw;
        private System.Windows.Forms.Button button_stand;
        private System.Windows.Forms.Label label_player_cards;
        private System.Windows.Forms.Label label_dealer_cards;
    }
}

