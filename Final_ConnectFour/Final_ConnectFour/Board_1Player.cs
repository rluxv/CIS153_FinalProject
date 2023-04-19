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
    public partial class Board_1Player : Form
    {
        private Board gameBoard;
        private bool isPlayer_turn;

        public Board_1Player()
        {
            InitializeComponent();
            gameBoard = new Board();
            isPlayer_turn = true;

        }



        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void GameScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
