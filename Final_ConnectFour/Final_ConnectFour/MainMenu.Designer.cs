namespace Final_ConnectFour
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_startSnglPlyr = new System.Windows.Forms.Button();
            this.lbl_c4name = new System.Windows.Forms.Label();
            this.btn_startTwoPlyr = new System.Windows.Forms.Button();
            this.btn_viewStats = new System.Windows.Forms.Button();
            this.btn_exitGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_startSnglPlyr
            // 
            this.btn_startSnglPlyr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_startSnglPlyr.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_startSnglPlyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startSnglPlyr.Location = new System.Drawing.Point(169, 81);
            this.btn_startSnglPlyr.Name = "btn_startSnglPlyr";
            this.btn_startSnglPlyr.Size = new System.Drawing.Size(176, 39);
            this.btn_startSnglPlyr.TabIndex = 1;
            this.btn_startSnglPlyr.Text = "Start 1 Player Game";
            this.btn_startSnglPlyr.UseVisualStyleBackColor = false;
            this.btn_startSnglPlyr.Click += new System.EventHandler(this.btn_startSnglPlyr_Click);
            // 
            // lbl_c4name
            // 
            this.lbl_c4name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_c4name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_c4name.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_c4name.Location = new System.Drawing.Point(12, 14);
            this.lbl_c4name.Name = "lbl_c4name";
            this.lbl_c4name.Size = new System.Drawing.Size(490, 38);
            this.lbl_c4name.TabIndex = 0;
            this.lbl_c4name.Text = "Connect 4";
            this.lbl_c4name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_startTwoPlyr
            // 
            this.btn_startTwoPlyr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_startTwoPlyr.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_startTwoPlyr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startTwoPlyr.Location = new System.Drawing.Point(169, 143);
            this.btn_startTwoPlyr.Name = "btn_startTwoPlyr";
            this.btn_startTwoPlyr.Size = new System.Drawing.Size(176, 39);
            this.btn_startTwoPlyr.TabIndex = 2;
            this.btn_startTwoPlyr.Text = "Start 2 Player Game";
            this.btn_startTwoPlyr.UseVisualStyleBackColor = false;
            this.btn_startTwoPlyr.Click += new System.EventHandler(this.btn_startTwoPlyr_Click);
            // 
            // btn_viewStats
            // 
            this.btn_viewStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_viewStats.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_viewStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_viewStats.Location = new System.Drawing.Point(169, 207);
            this.btn_viewStats.Name = "btn_viewStats";
            this.btn_viewStats.Size = new System.Drawing.Size(176, 39);
            this.btn_viewStats.TabIndex = 3;
            this.btn_viewStats.Text = "View Statistics";
            this.btn_viewStats.UseVisualStyleBackColor = false;
            this.btn_viewStats.Click += new System.EventHandler(this.btn_viewStats_Click);
            // 
            // btn_exitGame
            // 
            this.btn_exitGame.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_exitGame.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_exitGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exitGame.Location = new System.Drawing.Point(169, 274);
            this.btn_exitGame.Name = "btn_exitGame";
            this.btn_exitGame.Size = new System.Drawing.Size(176, 39);
            this.btn_exitGame.TabIndex = 4;
            this.btn_exitGame.Text = "Quit Game";
            this.btn_exitGame.UseVisualStyleBackColor = false;
            this.btn_exitGame.Click += new System.EventHandler(this.btn_exitGame_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(512, 322);
            this.Controls.Add(this.btn_exitGame);
            this.Controls.Add(this.btn_viewStats);
            this.Controls.Add(this.btn_startTwoPlyr);
            this.Controls.Add(this.btn_startSnglPlyr);
            this.Controls.Add(this.lbl_c4name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect 4 Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_startSnglPlyr;
        private System.Windows.Forms.Label lbl_c4name;
        private System.Windows.Forms.Button btn_startTwoPlyr;
        private System.Windows.Forms.Button btn_viewStats;
        private System.Windows.Forms.Button btn_exitGame;
    }
}

