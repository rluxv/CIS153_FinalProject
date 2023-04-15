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
    public partial class GameScreen : Form
    {
        private Board gameBoard;
        private bool isPlayer_turn;

        public GameScreen()
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




    }
}
