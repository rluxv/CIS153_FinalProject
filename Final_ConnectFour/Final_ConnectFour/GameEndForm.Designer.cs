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
            this.label1 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btn_reviewBoard = new System.Windows.Forms.Button();
            this.btn_playAgain = new System.Windows.Forms.Button();
            this.btn_mainMenu = new System.Windows.Forms.Button();
            this.lbl_winner = new System.Windows.Forms.Label();
            this.lbl_totalTurns = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(800, 76);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game End";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(593, 399);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(195, 39);
            this.button4.TabIndex = 7;
            this.button4.Text = "Exit Game";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btn_reviewBoard
            // 
            this.btn_reviewBoard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reviewBoard.Location = new System.Drawing.Point(12, 399);
            this.btn_reviewBoard.Name = "btn_reviewBoard";
            this.btn_reviewBoard.Size = new System.Drawing.Size(195, 39);
            this.btn_reviewBoard.TabIndex = 8;
            this.btn_reviewBoard.Text = "Review Board";
            this.btn_reviewBoard.UseVisualStyleBackColor = true;
            this.btn_reviewBoard.Click += new System.EventHandler(this.btn_reviewBoard_Click);
            // 
            // btn_playAgain
            // 
            this.btn_playAgain.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_playAgain.Location = new System.Drawing.Point(213, 399);
            this.btn_playAgain.Name = "btn_playAgain";
            this.btn_playAgain.Size = new System.Drawing.Size(185, 39);
            this.btn_playAgain.TabIndex = 11;
            this.btn_playAgain.Text = "Play Again";
            this.btn_playAgain.UseVisualStyleBackColor = true;
            this.btn_playAgain.Click += new System.EventHandler(this.btn_playAgain_Click);
            // 
            // btn_mainMenu
            // 
            this.btn_mainMenu.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mainMenu.Location = new System.Drawing.Point(402, 399);
            this.btn_mainMenu.Name = "btn_mainMenu";
            this.btn_mainMenu.Size = new System.Drawing.Size(185, 39);
            this.btn_mainMenu.TabIndex = 12;
            this.btn_mainMenu.Text = "Main Menu";
            this.btn_mainMenu.UseVisualStyleBackColor = true;
            this.btn_mainMenu.Click += new System.EventHandler(this.btn_mainMenu_Click);
            // 
            // lbl_winner
            // 
            this.lbl_winner.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_winner.Location = new System.Drawing.Point(12, 95);
            this.lbl_winner.Name = "lbl_winner";
            this.lbl_winner.Size = new System.Drawing.Size(776, 78);
            this.lbl_winner.TabIndex = 13;
            this.lbl_winner.Text = "Winner: Player 0";
            this.lbl_winner.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_totalTurns
            // 
            this.lbl_totalTurns.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_totalTurns.Location = new System.Drawing.Point(12, 186);
            this.lbl_totalTurns.Name = "lbl_totalTurns";
            this.lbl_totalTurns.Size = new System.Drawing.Size(776, 78);
            this.lbl_totalTurns.TabIndex = 14;
            this.lbl_totalTurns.Text = "Total Turns: 0";
            this.lbl_totalTurns.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameEndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_totalTurns);
            this.Controls.Add(this.lbl_winner);
            this.Controls.Add(this.btn_mainMenu);
            this.Controls.Add(this.btn_playAgain);
            this.Controls.Add(this.btn_reviewBoard);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "GameEndForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameEndForm";
            this.Load += new System.EventHandler(this.GameEndForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btn_reviewBoard;
        private System.Windows.Forms.Button btn_playAgain;
        private System.Windows.Forms.Button btn_mainMenu;
        private System.Windows.Forms.Label lbl_winner;
        private System.Windows.Forms.Label lbl_totalTurns;
    }
}