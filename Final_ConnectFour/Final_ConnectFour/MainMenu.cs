using System;
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
            StatsWindow statsWindow = new StatsWindow(this);
            statsWindow.Show();
            this.Hide();

        }

        private void btn_startSnglPlyr_Click(object sender, EventArgs e)
        {
            Board_1Player board = new Board_1Player();
            this.Hide();
            if (board.ShowDialog() == DialogResult.OK)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void btn_startTwoPlyr_Click(object sender, EventArgs e)
        {
            Board_2Player board = new Board_2Player(this);
            board.Show();
            this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
