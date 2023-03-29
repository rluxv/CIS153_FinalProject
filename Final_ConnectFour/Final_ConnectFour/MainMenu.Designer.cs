﻿namespace Final_ConnectFour
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
            this.btn_startSnglPlyr = new System.Windows.Forms.Button();
            this.lbl_c4name = new System.Windows.Forms.Label();
            this.btn_startTwoPlyr = new System.Windows.Forms.Button();
            this.btn_viewStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_startSnglPlyr
            // 
            this.btn_startSnglPlyr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_startSnglPlyr.Location = new System.Drawing.Point(157, 73);
            this.btn_startSnglPlyr.Name = "btn_startSnglPlyr";
            this.btn_startSnglPlyr.Size = new System.Drawing.Size(176, 39);
            this.btn_startSnglPlyr.TabIndex = 1;
            this.btn_startSnglPlyr.Text = "Start Single Player Game";
            this.btn_startSnglPlyr.UseVisualStyleBackColor = true;
            // 
            // lbl_c4name
            // 
            this.lbl_c4name.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_c4name.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_c4name.Location = new System.Drawing.Point(12, 9);
            this.lbl_c4name.Name = "lbl_c4name";
            this.lbl_c4name.Size = new System.Drawing.Size(462, 51);
            this.lbl_c4name.TabIndex = 0;
            this.lbl_c4name.Text = "Connect Four";
            this.lbl_c4name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_startTwoPlyr
            // 
            this.btn_startTwoPlyr.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_startTwoPlyr.Location = new System.Drawing.Point(157, 139);
            this.btn_startTwoPlyr.Name = "btn_startTwoPlyr";
            this.btn_startTwoPlyr.Size = new System.Drawing.Size(176, 39);
            this.btn_startTwoPlyr.TabIndex = 2;
            this.btn_startTwoPlyr.Text = "Start 2 Player Game";
            this.btn_startTwoPlyr.UseVisualStyleBackColor = true;
            // 
            // btn_viewStats
            // 
            this.btn_viewStats.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_viewStats.Location = new System.Drawing.Point(157, 205);
            this.btn_viewStats.Name = "btn_viewStats";
            this.btn_viewStats.Size = new System.Drawing.Size(176, 39);
            this.btn_viewStats.TabIndex = 3;
            this.btn_viewStats.Text = "View Statistics";
            this.btn_viewStats.UseVisualStyleBackColor = true;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(486, 307);
            this.Controls.Add(this.btn_viewStats);
            this.Controls.Add(this.btn_startTwoPlyr);
            this.Controls.Add(this.btn_startSnglPlyr);
            this.Controls.Add(this.lbl_c4name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect Four";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_startSnglPlyr;
        private System.Windows.Forms.Label lbl_c4name;
        private System.Windows.Forms.Button btn_startTwoPlyr;
        private System.Windows.Forms.Button btn_viewStats;
    }
}

