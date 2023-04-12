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
    public partial class Board_2Player : Form
    {

        Board board;
        MainMenu mm;

        public Board_2Player(MainMenu mainMenu)
        {
            InitializeComponent();
            board = new Board();
            board.initialize();
            mm = mainMenu;
        }

        private void Board_2Player_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                Button btn = (Button)sender;
                string txt = btn.Text;



                int col = int.Parse(txt.Substring(0, 1));
                int row = int.Parse(txt.Substring(3));

                Cell c = board.getCell(col, row);
                Console.WriteLine("Clicked on " + c.getCordCol() + ", " + c.getCordRow());

                if(columnFull(col))
                {
                    Console.WriteLine("Column full, doing nothing.");
                }
                else
                {
                    Console.WriteLine("Placing a disc.");
                    // temporary code below, only places disc for player 1 as we do not yet have a way to set whos turn it is, discs also do not fall to the bottom, and discs can be overwritten
                    placeDisc(1, row, col, btn);

                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form_close(object sender, FormClosedEventArgs e)
        {
            mm.Show();
        }

        public bool columnFull(int col)
        {
            int n = 0;
            for(int i = 0; i < 6; i++)
            {
                if (board.getCell(col, i).getPlayer() == 1 || board.getCell(col, i).getPlayer() == 2)
                {
                    n++;
                }
            }
            if (n == 6) return true;

            return false;
        }

        public void placeDisc(int player, int row, int col, Button btn)
        {
            if(player == 1)
            {
                board.getCell(col, row).setPlayer(1);
                btn.BackColor = Color.Yellow;
            }
            else if(player == 2)
            {
                board.getCell(col, row).setPlayer(2);
                btn.BackColor = Color.Red;
            }
        }
    }
}
