using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_ConnectFour
{
    public partial class GameEndForm : Form
    {
        Board_2Player board_2player;
        Board_1Player board_1player;
        MainMenu mm;

        // 1 = 1 player game, 2 = 2 player game
        int mode = 0;

        //winnernum: 0:draw 1:player1 2:player2/computer
        public GameEndForm(Board_2Player twoPlayerBoard, string title, MainMenu main, int totalMoves, int winnerNum)
        {
            InitializeComponent();
            board_2player = twoPlayerBoard;
            board_2player.Hide();
            mode = 2;
            this.Text = title;
            mm = main;
            lbl_winner.Text = "Player " + winnerNum + " Wins!";
            if (winnerNum == 0)
            {
                lbl_winner.Text = "Game Draw";
                audioDraw();
            }
            else audioWin();
            lbl_totalTurns.Text = "Total Turns: " + totalMoves;
        }

        public GameEndForm(Board_1Player onePlayerBoard, string title, MainMenu main)
        {
            InitializeComponent();
            board_1player = onePlayerBoard;
            board_1player.Hide();
            mode = 1;
            this.Text = title;
            mm = main;
        }
        private void audioWin()
        {
            Stream soundFile = Properties.Resources.win;
            SoundPlayer audio = new SoundPlayer(soundFile);
            audio.Play();
        }
        private void audioDraw()
        {
            Stream soundFile = Properties.Resources.draw;
            SoundPlayer audio = new SoundPlayer(soundFile);
            audio.Play();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_reviewBoard_Click(object sender, EventArgs e)
        {
            this.Hide();
            if(mode == 1)
            {
                board_1player.Show();
            } 
            if(mode == 2)
            {
                board_2player.Show();
            }
        }

        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            if(mode == 1)
            {

            }
            else if(mode == 2)
            {
                board_2player.Dispose();
                board_2player = new Board_2Player(mm);
                board_2player.Show();
                this.Close();
            }
        }

        private void btn_mainMenu_Click(object sender, EventArgs e)
        {
            mm.Show();
            this.Close();
        }

        private void GameEndForm_Load(object sender, EventArgs e)
        {

        }
    }
}
