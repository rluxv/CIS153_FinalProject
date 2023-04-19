namespace Final_ConnectFour
{
    partial class Board_1Player
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Board_1Player));
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_p2Turn = new System.Windows.Forms.Label();
            this.lbl_p1Turn = new System.Windows.Forms.Label();
            this.lbl_turnNum = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_65 = new System.Windows.Forms.Button();
            this.btn_64 = new System.Windows.Forms.Button();
            this.btn_63 = new System.Windows.Forms.Button();
            this.btn_62 = new System.Windows.Forms.Button();
            this.btn_61 = new System.Windows.Forms.Button();
            this.btn_60 = new System.Windows.Forms.Button();
            this.btn_55 = new System.Windows.Forms.Button();
            this.btn_54 = new System.Windows.Forms.Button();
            this.btn_53 = new System.Windows.Forms.Button();
            this.btn_52 = new System.Windows.Forms.Button();
            this.btn_50 = new System.Windows.Forms.Button();
            this.btn_43 = new System.Windows.Forms.Button();
            this.btn_51 = new System.Windows.Forms.Button();
            this.btn_45 = new System.Windows.Forms.Button();
            this.btn_44 = new System.Windows.Forms.Button();
            this.btn_42 = new System.Windows.Forms.Button();
            this.btn_41 = new System.Windows.Forms.Button();
            this.btn_40 = new System.Windows.Forms.Button();
            this.btn_35 = new System.Windows.Forms.Button();
            this.btn_34 = new System.Windows.Forms.Button();
            this.btn_33 = new System.Windows.Forms.Button();
            this.btn_32 = new System.Windows.Forms.Button();
            this.btn_31 = new System.Windows.Forms.Button();
            this.btn_30 = new System.Windows.Forms.Button();
            this.btn_25 = new System.Windows.Forms.Button();
            this.btn_24 = new System.Windows.Forms.Button();
            this.btn_23 = new System.Windows.Forms.Button();
            this.btn_22 = new System.Windows.Forms.Button();
            this.btn_21 = new System.Windows.Forms.Button();
            this.btn_20 = new System.Windows.Forms.Button();
            this.btn_15 = new System.Windows.Forms.Button();
            this.btn_14 = new System.Windows.Forms.Button();
            this.btn_13 = new System.Windows.Forms.Button();
            this.btn_12 = new System.Windows.Forms.Button();
            this.btn_11 = new System.Windows.Forms.Button();
            this.btn_10 = new System.Windows.Forms.Button();
            this.btn_05 = new System.Windows.Forms.Button();
            this.btn_04 = new System.Windows.Forms.Button();
            this.btn_03 = new System.Windows.Forms.Button();
            this.btn_02 = new System.Windows.Forms.Button();
            this.btn_01 = new System.Windows.Forms.Button();
            this.btn_00 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(963, 695);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(119, 34);
            this.btn_exit.TabIndex = 134;
            this.btn_exit.Text = "End Game";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.lbl_p2Turn);
            this.panel1.Controls.Add(this.lbl_p1Turn);
            this.panel1.Controls.Add(this.lbl_turnNum);
            this.panel1.Location = new System.Drawing.Point(5, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(242, 740);
            this.panel1.TabIndex = 133;
            // 
            // lbl_p2Turn
            // 
            this.lbl_p2Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p2Turn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_p2Turn.Location = new System.Drawing.Point(3, 134);
            this.lbl_p2Turn.Name = "lbl_p2Turn";
            this.lbl_p2Turn.Size = new System.Drawing.Size(236, 30);
            this.lbl_p2Turn.TabIndex = 2;
            this.lbl_p2Turn.Text = "Computer\'s Turn";
            this.lbl_p2Turn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_p1Turn
            // 
            this.lbl_p1Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_p1Turn.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl_p1Turn.Location = new System.Drawing.Point(3, 82);
            this.lbl_p1Turn.Name = "lbl_p1Turn";
            this.lbl_p1Turn.Size = new System.Drawing.Size(236, 30);
            this.lbl_p1Turn.TabIndex = 1;
            this.lbl_p1Turn.Text = "Player 1\'s Turn";
            this.lbl_p1Turn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_turnNum
            // 
            this.lbl_turnNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_turnNum.Location = new System.Drawing.Point(3, 9);
            this.lbl_turnNum.Name = "lbl_turnNum";
            this.lbl_turnNum.Size = new System.Drawing.Size(236, 30);
            this.lbl_turnNum.TabIndex = 0;
            this.lbl_turnNum.Text = "Turn 0";
            this.lbl_turnNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 706);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 13);
            this.label1.TabIndex = 132;
            this.label1.Text = "first number in coord is col, second is row";
            // 
            // btn_65
            // 
            this.btn_65.Location = new System.Drawing.Point(943, 566);
            this.btn_65.Name = "btn_65";
            this.btn_65.Size = new System.Drawing.Size(100, 100);
            this.btn_65.TabIndex = 131;
            this.btn_65.Text = "6, 5";
            this.btn_65.UseVisualStyleBackColor = true;
            // 
            // btn_64
            // 
            this.btn_64.Location = new System.Drawing.Point(943, 460);
            this.btn_64.Name = "btn_64";
            this.btn_64.Size = new System.Drawing.Size(100, 100);
            this.btn_64.TabIndex = 130;
            this.btn_64.Text = "6, 4";
            this.btn_64.UseVisualStyleBackColor = true;
            // 
            // btn_63
            // 
            this.btn_63.Location = new System.Drawing.Point(943, 354);
            this.btn_63.Name = "btn_63";
            this.btn_63.Size = new System.Drawing.Size(100, 100);
            this.btn_63.TabIndex = 129;
            this.btn_63.Text = "6, 3";
            this.btn_63.UseVisualStyleBackColor = true;
            // 
            // btn_62
            // 
            this.btn_62.Location = new System.Drawing.Point(943, 248);
            this.btn_62.Name = "btn_62";
            this.btn_62.Size = new System.Drawing.Size(100, 100);
            this.btn_62.TabIndex = 128;
            this.btn_62.Text = "6, 2";
            this.btn_62.UseVisualStyleBackColor = true;
            // 
            // btn_61
            // 
            this.btn_61.Location = new System.Drawing.Point(943, 142);
            this.btn_61.Name = "btn_61";
            this.btn_61.Size = new System.Drawing.Size(100, 100);
            this.btn_61.TabIndex = 127;
            this.btn_61.Text = "6, 1";
            this.btn_61.UseVisualStyleBackColor = true;
            // 
            // btn_60
            // 
            this.btn_60.Location = new System.Drawing.Point(943, 36);
            this.btn_60.Name = "btn_60";
            this.btn_60.Size = new System.Drawing.Size(100, 100);
            this.btn_60.TabIndex = 126;
            this.btn_60.Text = "6, 0";
            this.btn_60.UseVisualStyleBackColor = true;
            // 
            // btn_55
            // 
            this.btn_55.Location = new System.Drawing.Point(837, 566);
            this.btn_55.Name = "btn_55";
            this.btn_55.Size = new System.Drawing.Size(100, 100);
            this.btn_55.TabIndex = 125;
            this.btn_55.Text = "5, 5";
            this.btn_55.UseVisualStyleBackColor = true;
            // 
            // btn_54
            // 
            this.btn_54.Location = new System.Drawing.Point(837, 460);
            this.btn_54.Name = "btn_54";
            this.btn_54.Size = new System.Drawing.Size(100, 100);
            this.btn_54.TabIndex = 124;
            this.btn_54.Text = "5, 4";
            this.btn_54.UseVisualStyleBackColor = true;
            // 
            // btn_53
            // 
            this.btn_53.Location = new System.Drawing.Point(837, 354);
            this.btn_53.Name = "btn_53";
            this.btn_53.Size = new System.Drawing.Size(100, 100);
            this.btn_53.TabIndex = 123;
            this.btn_53.Text = "5, 3";
            this.btn_53.UseVisualStyleBackColor = true;
            // 
            // btn_52
            // 
            this.btn_52.Location = new System.Drawing.Point(837, 248);
            this.btn_52.Name = "btn_52";
            this.btn_52.Size = new System.Drawing.Size(100, 100);
            this.btn_52.TabIndex = 122;
            this.btn_52.Text = "5, 2";
            this.btn_52.UseVisualStyleBackColor = true;
            // 
            // btn_50
            // 
            this.btn_50.Location = new System.Drawing.Point(837, 36);
            this.btn_50.Name = "btn_50";
            this.btn_50.Size = new System.Drawing.Size(100, 100);
            this.btn_50.TabIndex = 120;
            this.btn_50.Text = "5, 0";
            this.btn_50.UseVisualStyleBackColor = true;
            // 
            // btn_43
            // 
            this.btn_43.Location = new System.Drawing.Point(731, 354);
            this.btn_43.Name = "btn_43";
            this.btn_43.Size = new System.Drawing.Size(100, 100);
            this.btn_43.TabIndex = 117;
            this.btn_43.Text = "4, 3";
            this.btn_43.UseVisualStyleBackColor = true;
            // 
            // btn_51
            // 
            this.btn_51.Location = new System.Drawing.Point(837, 142);
            this.btn_51.Name = "btn_51";
            this.btn_51.Size = new System.Drawing.Size(100, 100);
            this.btn_51.TabIndex = 121;
            this.btn_51.Text = "5, 1";
            this.btn_51.UseVisualStyleBackColor = true;
            // 
            // btn_45
            // 
            this.btn_45.Location = new System.Drawing.Point(731, 566);
            this.btn_45.Name = "btn_45";
            this.btn_45.Size = new System.Drawing.Size(100, 100);
            this.btn_45.TabIndex = 119;
            this.btn_45.Text = "4, 5";
            this.btn_45.UseVisualStyleBackColor = true;
            // 
            // btn_44
            // 
            this.btn_44.Location = new System.Drawing.Point(731, 460);
            this.btn_44.Name = "btn_44";
            this.btn_44.Size = new System.Drawing.Size(100, 100);
            this.btn_44.TabIndex = 118;
            this.btn_44.Text = "4, 4";
            this.btn_44.UseVisualStyleBackColor = true;
            // 
            // btn_42
            // 
            this.btn_42.Location = new System.Drawing.Point(731, 248);
            this.btn_42.Name = "btn_42";
            this.btn_42.Size = new System.Drawing.Size(100, 100);
            this.btn_42.TabIndex = 116;
            this.btn_42.Text = "4, 2";
            this.btn_42.UseVisualStyleBackColor = true;
            // 
            // btn_41
            // 
            this.btn_41.Location = new System.Drawing.Point(731, 142);
            this.btn_41.Name = "btn_41";
            this.btn_41.Size = new System.Drawing.Size(100, 100);
            this.btn_41.TabIndex = 115;
            this.btn_41.Text = "4, 1";
            this.btn_41.UseVisualStyleBackColor = true;
            // 
            // btn_40
            // 
            this.btn_40.Location = new System.Drawing.Point(731, 36);
            this.btn_40.Name = "btn_40";
            this.btn_40.Size = new System.Drawing.Size(100, 100);
            this.btn_40.TabIndex = 114;
            this.btn_40.Text = "4, 0";
            this.btn_40.UseVisualStyleBackColor = true;
            // 
            // btn_35
            // 
            this.btn_35.Location = new System.Drawing.Point(625, 566);
            this.btn_35.Name = "btn_35";
            this.btn_35.Size = new System.Drawing.Size(100, 100);
            this.btn_35.TabIndex = 113;
            this.btn_35.Text = "3, 5";
            this.btn_35.UseVisualStyleBackColor = true;
            // 
            // btn_34
            // 
            this.btn_34.Location = new System.Drawing.Point(625, 460);
            this.btn_34.Name = "btn_34";
            this.btn_34.Size = new System.Drawing.Size(100, 100);
            this.btn_34.TabIndex = 112;
            this.btn_34.Text = "3, 4";
            this.btn_34.UseVisualStyleBackColor = true;
            // 
            // btn_33
            // 
            this.btn_33.Location = new System.Drawing.Point(625, 354);
            this.btn_33.Name = "btn_33";
            this.btn_33.Size = new System.Drawing.Size(100, 100);
            this.btn_33.TabIndex = 111;
            this.btn_33.Text = "3, 3";
            this.btn_33.UseVisualStyleBackColor = true;
            // 
            // btn_32
            // 
            this.btn_32.Location = new System.Drawing.Point(625, 248);
            this.btn_32.Name = "btn_32";
            this.btn_32.Size = new System.Drawing.Size(100, 100);
            this.btn_32.TabIndex = 110;
            this.btn_32.Text = "3, 2";
            this.btn_32.UseVisualStyleBackColor = true;
            // 
            // btn_31
            // 
            this.btn_31.Location = new System.Drawing.Point(625, 142);
            this.btn_31.Name = "btn_31";
            this.btn_31.Size = new System.Drawing.Size(100, 100);
            this.btn_31.TabIndex = 109;
            this.btn_31.Text = "3, 1";
            this.btn_31.UseVisualStyleBackColor = true;
            // 
            // btn_30
            // 
            this.btn_30.Location = new System.Drawing.Point(625, 36);
            this.btn_30.Name = "btn_30";
            this.btn_30.Size = new System.Drawing.Size(100, 100);
            this.btn_30.TabIndex = 108;
            this.btn_30.Text = "3, 0";
            this.btn_30.UseVisualStyleBackColor = true;
            // 
            // btn_25
            // 
            this.btn_25.Location = new System.Drawing.Point(519, 566);
            this.btn_25.Name = "btn_25";
            this.btn_25.Size = new System.Drawing.Size(100, 100);
            this.btn_25.TabIndex = 107;
            this.btn_25.Text = "2, 5";
            this.btn_25.UseVisualStyleBackColor = true;
            // 
            // btn_24
            // 
            this.btn_24.Location = new System.Drawing.Point(519, 460);
            this.btn_24.Name = "btn_24";
            this.btn_24.Size = new System.Drawing.Size(100, 100);
            this.btn_24.TabIndex = 106;
            this.btn_24.Text = "2, 4";
            this.btn_24.UseVisualStyleBackColor = true;
            // 
            // btn_23
            // 
            this.btn_23.Location = new System.Drawing.Point(519, 354);
            this.btn_23.Name = "btn_23";
            this.btn_23.Size = new System.Drawing.Size(100, 100);
            this.btn_23.TabIndex = 105;
            this.btn_23.Text = "2, 3";
            this.btn_23.UseVisualStyleBackColor = true;
            // 
            // btn_22
            // 
            this.btn_22.Location = new System.Drawing.Point(519, 248);
            this.btn_22.Name = "btn_22";
            this.btn_22.Size = new System.Drawing.Size(100, 100);
            this.btn_22.TabIndex = 104;
            this.btn_22.Text = "2, 2";
            this.btn_22.UseVisualStyleBackColor = true;
            // 
            // btn_21
            // 
            this.btn_21.Location = new System.Drawing.Point(519, 142);
            this.btn_21.Name = "btn_21";
            this.btn_21.Size = new System.Drawing.Size(100, 100);
            this.btn_21.TabIndex = 103;
            this.btn_21.Text = "2, 1";
            this.btn_21.UseVisualStyleBackColor = true;
            // 
            // btn_20
            // 
            this.btn_20.Location = new System.Drawing.Point(519, 36);
            this.btn_20.Name = "btn_20";
            this.btn_20.Size = new System.Drawing.Size(100, 100);
            this.btn_20.TabIndex = 102;
            this.btn_20.Text = "2, 0";
            this.btn_20.UseVisualStyleBackColor = true;
            // 
            // btn_15
            // 
            this.btn_15.Location = new System.Drawing.Point(413, 566);
            this.btn_15.Name = "btn_15";
            this.btn_15.Size = new System.Drawing.Size(100, 100);
            this.btn_15.TabIndex = 101;
            this.btn_15.Text = "1, 5";
            this.btn_15.UseVisualStyleBackColor = true;
            // 
            // btn_14
            // 
            this.btn_14.Location = new System.Drawing.Point(413, 460);
            this.btn_14.Name = "btn_14";
            this.btn_14.Size = new System.Drawing.Size(100, 100);
            this.btn_14.TabIndex = 100;
            this.btn_14.Text = "1, 4";
            this.btn_14.UseVisualStyleBackColor = true;
            // 
            // btn_13
            // 
            this.btn_13.Location = new System.Drawing.Point(413, 354);
            this.btn_13.Name = "btn_13";
            this.btn_13.Size = new System.Drawing.Size(100, 100);
            this.btn_13.TabIndex = 99;
            this.btn_13.Text = "1, 3";
            this.btn_13.UseVisualStyleBackColor = true;
            // 
            // btn_12
            // 
            this.btn_12.Location = new System.Drawing.Point(413, 248);
            this.btn_12.Name = "btn_12";
            this.btn_12.Size = new System.Drawing.Size(100, 100);
            this.btn_12.TabIndex = 98;
            this.btn_12.Text = "1, 2";
            this.btn_12.UseVisualStyleBackColor = true;
            // 
            // btn_11
            // 
            this.btn_11.Location = new System.Drawing.Point(413, 142);
            this.btn_11.Name = "btn_11";
            this.btn_11.Size = new System.Drawing.Size(100, 100);
            this.btn_11.TabIndex = 97;
            this.btn_11.Text = "1, 1";
            this.btn_11.UseVisualStyleBackColor = true;
            // 
            // btn_10
            // 
            this.btn_10.Location = new System.Drawing.Point(413, 36);
            this.btn_10.Name = "btn_10";
            this.btn_10.Size = new System.Drawing.Size(100, 100);
            this.btn_10.TabIndex = 96;
            this.btn_10.Text = "1, 0";
            this.btn_10.UseVisualStyleBackColor = true;
            // 
            // btn_05
            // 
            this.btn_05.Location = new System.Drawing.Point(307, 566);
            this.btn_05.Name = "btn_05";
            this.btn_05.Size = new System.Drawing.Size(100, 100);
            this.btn_05.TabIndex = 95;
            this.btn_05.Text = "0, 5";
            this.btn_05.UseVisualStyleBackColor = true;
            // 
            // btn_04
            // 
            this.btn_04.Location = new System.Drawing.Point(307, 460);
            this.btn_04.Name = "btn_04";
            this.btn_04.Size = new System.Drawing.Size(100, 100);
            this.btn_04.TabIndex = 94;
            this.btn_04.Text = "0, 4";
            this.btn_04.UseVisualStyleBackColor = true;
            // 
            // btn_03
            // 
            this.btn_03.Location = new System.Drawing.Point(307, 354);
            this.btn_03.Name = "btn_03";
            this.btn_03.Size = new System.Drawing.Size(100, 100);
            this.btn_03.TabIndex = 93;
            this.btn_03.Text = "0, 3";
            this.btn_03.UseVisualStyleBackColor = true;
            // 
            // btn_02
            // 
            this.btn_02.Location = new System.Drawing.Point(307, 248);
            this.btn_02.Name = "btn_02";
            this.btn_02.Size = new System.Drawing.Size(100, 100);
            this.btn_02.TabIndex = 92;
            this.btn_02.Text = "0, 2";
            this.btn_02.UseVisualStyleBackColor = true;
            // 
            // btn_01
            // 
            this.btn_01.Location = new System.Drawing.Point(307, 142);
            this.btn_01.Name = "btn_01";
            this.btn_01.Size = new System.Drawing.Size(100, 100);
            this.btn_01.TabIndex = 91;
            this.btn_01.Text = "0, 1";
            this.btn_01.UseVisualStyleBackColor = true;
            // 
            // btn_00
            // 
            this.btn_00.Location = new System.Drawing.Point(307, 36);
            this.btn_00.Name = "btn_00";
            this.btn_00.Size = new System.Drawing.Size(100, 100);
            this.btn_00.TabIndex = 90;
            this.btn_00.Text = "0, 0";
            this.btn_00.UseVisualStyleBackColor = true;
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1140, 783);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_65);
            this.Controls.Add(this.btn_64);
            this.Controls.Add(this.btn_63);
            this.Controls.Add(this.btn_62);
            this.Controls.Add(this.btn_61);
            this.Controls.Add(this.btn_60);
            this.Controls.Add(this.btn_55);
            this.Controls.Add(this.btn_54);
            this.Controls.Add(this.btn_53);
            this.Controls.Add(this.btn_52);
            this.Controls.Add(this.btn_50);
            this.Controls.Add(this.btn_43);
            this.Controls.Add(this.btn_51);
            this.Controls.Add(this.btn_45);
            this.Controls.Add(this.btn_44);
            this.Controls.Add(this.btn_42);
            this.Controls.Add(this.btn_41);
            this.Controls.Add(this.btn_40);
            this.Controls.Add(this.btn_35);
            this.Controls.Add(this.btn_34);
            this.Controls.Add(this.btn_33);
            this.Controls.Add(this.btn_32);
            this.Controls.Add(this.btn_31);
            this.Controls.Add(this.btn_30);
            this.Controls.Add(this.btn_25);
            this.Controls.Add(this.btn_24);
            this.Controls.Add(this.btn_23);
            this.Controls.Add(this.btn_22);
            this.Controls.Add(this.btn_21);
            this.Controls.Add(this.btn_20);
            this.Controls.Add(this.btn_15);
            this.Controls.Add(this.btn_14);
            this.Controls.Add(this.btn_13);
            this.Controls.Add(this.btn_12);
            this.Controls.Add(this.btn_11);
            this.Controls.Add(this.btn_10);
            this.Controls.Add(this.btn_05);
            this.Controls.Add(this.btn_04);
            this.Controls.Add(this.btn_03);
            this.Controls.Add(this.btn_02);
            this.Controls.Add(this.btn_01);
            this.Controls.Add(this.btn_00);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameScreen";
            this.Text = "Connect 4 Game Menu";
            this.Load += new System.EventHandler(this.GameScreen_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_p2Turn;
        private System.Windows.Forms.Label lbl_p1Turn;
        private System.Windows.Forms.Label lbl_turnNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_65;
        private System.Windows.Forms.Button btn_64;
        private System.Windows.Forms.Button btn_63;
        private System.Windows.Forms.Button btn_62;
        private System.Windows.Forms.Button btn_61;
        private System.Windows.Forms.Button btn_60;
        private System.Windows.Forms.Button btn_55;
        private System.Windows.Forms.Button btn_54;
        private System.Windows.Forms.Button btn_53;
        private System.Windows.Forms.Button btn_52;
        private System.Windows.Forms.Button btn_50;
        private System.Windows.Forms.Button btn_43;
        private System.Windows.Forms.Button btn_51;
        private System.Windows.Forms.Button btn_45;
        private System.Windows.Forms.Button btn_44;
        private System.Windows.Forms.Button btn_42;
        private System.Windows.Forms.Button btn_41;
        private System.Windows.Forms.Button btn_40;
        private System.Windows.Forms.Button btn_35;
        private System.Windows.Forms.Button btn_34;
        private System.Windows.Forms.Button btn_33;
        private System.Windows.Forms.Button btn_32;
        private System.Windows.Forms.Button btn_31;
        private System.Windows.Forms.Button btn_30;
        private System.Windows.Forms.Button btn_25;
        private System.Windows.Forms.Button btn_24;
        private System.Windows.Forms.Button btn_23;
        private System.Windows.Forms.Button btn_22;
        private System.Windows.Forms.Button btn_21;
        private System.Windows.Forms.Button btn_20;
        private System.Windows.Forms.Button btn_15;
        private System.Windows.Forms.Button btn_14;
        private System.Windows.Forms.Button btn_13;
        private System.Windows.Forms.Button btn_12;
        private System.Windows.Forms.Button btn_11;
        private System.Windows.Forms.Button btn_10;
        private System.Windows.Forms.Button btn_05;
        private System.Windows.Forms.Button btn_04;
        private System.Windows.Forms.Button btn_03;
        private System.Windows.Forms.Button btn_02;
        private System.Windows.Forms.Button btn_01;
        private System.Windows.Forms.Button btn_00;
    }
}