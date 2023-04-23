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
            this.Hide();
            if (statsWindow.ShowDialog() == DialogResult.Yes)
            {
                this.Show();
            }
            else
            {
                this.Close();
            }

        }

        private void btn_startSnglPlyr_Click(object sender, EventArgs e)
        {
            DialogResult res;
            do
            {
                Board_1Player board = new Board_1Player(this);
                this.Hide();
                res = board.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    this.Show();
                }
                else if (res == DialogResult.Abort)
                {
                    this.Close();
                }
            } while (res == DialogResult.Retry);
        }

        private void btn_startTwoPlyr_Click(object sender, EventArgs e)
        {
            DialogResult res;
            do
            {
                Board_2Player board = new Board_2Player(this);
                this.Hide();
                res = board.ShowDialog();
                if (res == DialogResult.Yes)
                {
                    this.Show();
                }
                else if (res == DialogResult.Abort)
                {
                    this.Close();
                }
            } while (res == DialogResult.Retry);

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
