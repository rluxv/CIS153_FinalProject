﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_ConnectFour
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void btn_exitGame_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_viewStats_Click(object sender, EventArgs e)
        {
            Stats st = new Stats();
            st.initialize();

            StatsWindow statsWindow = new StatsWindow();
            statsWindow.Show();

        }

        private void btn_startSnglPlyr_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_startTwoPlyr_Click(object sender, EventArgs e)
        {
            Board_2Player board = new Board_2Player(this);
            board.Show();
            this.Hide();
        }
    }
}
