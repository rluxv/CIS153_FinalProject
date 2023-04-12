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
        Player player;

        public Board_2Player(MainMenu mainMenu)
        {
            InitializeComponent();
            board = new Board();
            board.initialize();
            mm = mainMenu;
            player = new Player();
            player.setPlayerTurn(1);
        }

        private void Board_2Player_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btn_click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                string txt = btn.Text;


                int col = int.Parse(txt.Substring(0, 1));
                int row = int.Parse(txt.Substring(3));


                Cell c = board.getCell(col, row);
                Console.WriteLine("Clicked on " + c.getCordCol() + ", " + c.getCordRow());


                //Checks what token is present on the button (0 for nothing, 1 for player 1, 2 for player 2
                //Then places it or places it lower
                if(board.getCell(col, row).getToken()==0)
                {
                    //Checks if the cell below has a filled out token or not(or is at bottom of row
                    if (row == 5 || board.getCell(col, row + 1).getToken() == 1 || board.getCell(col, row + 1).getToken() == 2 )
                    {
                        Console.WriteLine("Placing a disc.");
                        placeDisc(row, col, btn);

                        //Switches player after button press
                        if (player.getPlayerTurn() == 1)
                        {
                            player.setPlayerTurn(2);
                            Console.WriteLine("Player 2 Turn");
                        }
                        else if (player.getPlayerTurn() == 2)
                        {
                            player.setPlayerTurn(1);
                            Console.WriteLine("Player 1 Turn");
                        }
                    }
                    ////Goes down and checks every cell below it if there is a token within the cell
                    ////Places token down as far as possible
                    ////Work in Progress
                    //else
                    //{
                    //    int rowCount = 1;
                    //    while (board.getCell(col, row + rowCount).getToken() == 0)
                    //    {
                    //        rowCount++;
                    //        if (row+rowCount == 5)
                    //        {
                    //            placeDisc(row, col, btn);
                    //            break;
                    //        }
                    //        if (board.getCell(col, row + rowCount + 1).getToken() != 0)
                    //        {

                    //        }
                    //    }
                    //}


                //Errors
                }
                else if (board.getCell(col, row).getToken()==1)
                {
                    Console.WriteLine("ERROR: Player 1 Token present");
                }
                else if (board.getCell(col, row).getToken() == 2)
                {
                    Console.WriteLine("ERROR: Player 2 Token present");
                }
                else
                {
                    Console.WriteLine("ERROR 404: Token not found");
                }



            }
        }

        private void form_close(object sender, FormClosedEventArgs e)
        {
            mm.Show();
        }

        //public bool columnFull(int col)
        //{
        //    int n = 0;
        //    for(int i = 0; i < 6; i++)
        //    {
        //        if (board.getCell(col, i).getPlayer() == 1 || board.getCell(col, i).getPlayer() == 2)
        //        {
        //            n++;
        //        }
        //    }
        //    if (n == 6) return true;

        //    return false;
        //}

        public void placeDisc(int row, int col, Button btn)
        {
            if(player.getPlayerTurn() == 1)
            {
                board.getCell(col, row).setToken(1);
                btn.BackColor = Color.Yellow;
            }
            else if(player.getPlayerTurn() == 2)
            {
                board.getCell(col, row).setToken(2);
                btn.BackColor = Color.Red;
            }
        }


    }
}
