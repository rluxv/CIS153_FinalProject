namespace Final_ConnectFour
{
    partial class GameEndForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameEndForm));
            this.button4 = new System.Windows.Forms.Button();
            this.btn_reviewBoard = new System.Windows.Forms.Button();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.lbl_totalTurns = new System.Windows.Forms.Label();
            this.panel_gameEnd = new System.Windows.Forms.Panel();
            this.lbl_gmEnd = new System.Windows.Forms.Label();
            this.panel_gameEnd.SuspendLayout();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(791, 491);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(260, 48);
            this.button4.TabIndex = 7;
            this.button4.Text = "Exit Game";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_reviewBoard
            // 
            this.btn_reviewBoard.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_reviewBoard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reviewBoard.Location = new System.Drawing.Point(16, 491);
            this.btn_reviewBoard.Margin = new System.Windows.Forms.Padding(4);
            this.btn_reviewBoard.Name = "btn_reviewBoard";
            this.btn_reviewBoard.Size = new System.Drawing.Size(260, 48);
            this.btn_reviewBoard.TabIndex = 8;
            this.btn_reviewBoard.Text = "Review Board";
            this.btn_reviewBoard.UseVisualStyleBackColor = false;
            this.btn_reviewBoard.Click += new System.EventHandler(this.btn_reviewBoard_Click);
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_playAgain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playAgain.Location = new System.Drawing.Point(284, 491);
            this.btn_playAgain.Margin = new System.Windows.Forms.Padding(4);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(247, 48);
            this.btn_playAgain.TabIndex = 11;
            this.btn_playAgain.Text = "Play Again";
            this.btn_playAgain.UseVisualStyleBackColor = false;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_mainMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainMenu.Location = new System.Drawing.Point(536, 491);
            this.btn_mainMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(247, 48);
            this.btn_mainMenu.TabIndex = 12;
            this.btn_mainMenu.Text = "Main Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = false;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // lbl_winner
            // 
            this.lbl_winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner.Location = new System.Drawing.Point(4, 135);
            this.lbl_winner.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(491, 96);
            this.lbl_winner.TabIndex = 13;
            this.lbl_winner.Text = "Player 0 Wins!";
            this.lbl_winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_totalTurns
            // 
            this.lbl_totalTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalTurns.Location = new System.Drawing.Point(4, 231);
            this.lbl_totalTurns.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_totalTurns.Name = "lbl_totalTurns";
            this.lbl_totalTurns.Size = new System.Drawing.Size(491, 96);
            this.lbl_totalTurns.TabIndex = 14;
            this.lbl_totalTurns.Text = "Total Turns: 0";
            this.lbl_totalTurns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_gameEnd
            // 
            this.panel_gameEnd.BackColor = System.Drawing.Color.RoyalBlue;
            this.panel_gameEnd.Controls.Add(this.lbl_gmEnd);
            this.panel_gameEnd.Controls.Add(this.lbl_totalTurns);
            this.panel_gameEnd.Controls.Add(this.lbl_winner);
            this.panel_gameEnd.Location = new System.Drawing.Point(284, 43);
            this.panel_gameEnd.Name = "panel_gameEnd";
            this.panel_gameEnd.Size = new System.Drawing.Size(499, 341);
            this.panel_gameEnd.TabIndex = 15;
            // 
            // lbl_gmEnd
            // 
            this.lbl_gmEnd.AutoSize = true;
            this.lbl_gmEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gmEnd.Location = new System.Drawing.Point(33, 28);
            this.lbl_gmEnd.Name = "lbl_gmEnd";
            this.lbl_gmEnd.Size = new System.Drawing.Size(426, 91);
            this.lbl_gmEnd.TabIndex = 17;
            this.lbl_gmEnd.Text = "Game End";
            // 
            // GameEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel_gameEnd);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.btn_playAgain);
            this.Controls.Add(this.btn_reviewBoard);
            this.Controls.Add(this.button4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "GameEndForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameEndForm";
            this.Load += new System.EventHandler(this.GameEndForm_Load);
            this.panel_gameEnd.ResumeLayout(false);
            this.panel_gameEnd.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_reviewBoard;
        private System.Windows.Forms.Button btn_playAgain;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Label lbl_totalTurns;
        private System.Windows.Forms.Panel panel_gameEnd;
        private System.Windows.Forms.Label lbl_gmEnd;
    }
}