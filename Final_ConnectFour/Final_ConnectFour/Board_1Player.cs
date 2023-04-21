using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;
using System.Threading;

namespace Final_ConnectFour
{
    public partial class Board_1Player : Form
    {

        Board board;
        MainMenu mm;
        Player player;
        int turns;
        private bool isPlayer1_turn;

        Color defaultColor;

        public Board_1Player(MainMenu mainMenu)
        {
            InitializeComponent();
            board = new Board();
            board.initialize();
            mm = mainMenu;
            isPlayer1_turn = true;
            player = new Player();
            player.setPlayerTurn(1);
            turns = 1;
            refreshSidebar();

            // this hides the coordinates in-game since they are not needed for the player
            foreach (var button in panel_gamePanel.Controls.OfType<Button>())
            {
                button.Tag = button.Text;
                Console.WriteLine(button.Tag);
                button.Text = "";
            }
            defaultColor = btn_00.BackColor;
            foreach (var btn in panel_gamePanel.Controls.OfType<Button>())
            {
                string txt = btn.Tag.ToString();
                int col = int.Parse(txt.Substring(0, 1));
                int row = int.Parse(txt.Substring(3));

                Cell c = board.getCell(col, row);
                c.setButton(btn);
            }
            label1.Hide();
            refreshBoard();
        }

        private void Board_2Player_Load(object sender, EventArgs e)
        {

        }
        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void refreshBoard()
        {

            this.Text = "Connect Four | Player " + player.getPlayerTurn() + "'s Turn | Turn " + turns;
            if(player.getPlayerTurn() == 2)
            {
                this.Text = "Connect Four | Computer's Turn | Turn " + turns;
            }

            foreach (var btn in panel_gamePanel.Controls.OfType<Button>())
            {
                string txt = btn.Tag.ToString();

                int col = int.Parse(txt.Substring(0, 1));
                int row = int.Parse(txt.Substring(3));

                Cell c = board.getCell(col, row);
                if (c.getToken() == 1)
                {
                    btn.BackColor = Color.Yellow;
                }
                else if (c.getToken() == 2)
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = defaultColor;
                }
            }
        }

        private void refreshSidebar()
        {
            if (player.getPlayerTurn() == 1)
            {
                lbl_p1Turn.ForeColor = Color.DarkGreen;
                lbl_p1Turn.Font = new Font(lbl_p1Turn.Font, FontStyle.Bold);

                lbl_p2Turn.ForeColor = Color.Gray;
                lbl_p2Turn.Font = new Font(lbl_p1Turn.Font, FontStyle.Regular);
            }
            else if (player.getPlayerTurn() == 2)
            {
                lbl_p2Turn.ForeColor = Color.DarkGreen;
                lbl_p2Turn.Font = new Font(lbl_p1Turn.Font, FontStyle.Bold);

                lbl_p1Turn.ForeColor = Color.Gray;
                lbl_p1Turn.Font = new Font(lbl_p1Turn.Font, FontStyle.Regular);
            }
            lbl_turnNum.Text = "Turn " + turns;
        }

        // if all cells contain a player token and there is no winner the game is a draw
        private bool isGameDraw()
        {

            for (int col = 0; col < 7; col++)
            {
                for (int row = 0; row < 6; row++)
                {
                    // if even a single cell has no player token the board is not yet full.
                    if (board.getCell(col, row).getToken() == 0)
                    {
                        return false;
                    }

                }
            }
            return true;
        }
        private bool checkWin(int p)
        {
            // vertical check
            for (int c = 0; c < 7; c++)
            {
                int count = 0;
                for (int r = 0; r < 6; r++)
                {
                    if (board.getCell(c, r).getToken() == p)
                    {
                        Console.WriteLine("token found: " + c + ", " + r);
                        count++;
                        Console.WriteLine("count: " + count);
                        if (count == 4)
                        {
                            return true;
                        }
                    }
                    else
                    {
                        count = 0;
                    }
                }

            }

            // horizontal check
            for (int r = 0; r < 6; r++)
            {
                int count = 0;
                for (int c = 0; c < 7; c++)
                {
                    if (board.getCell(c, r).getToken() == p)
                    {
                        Console.WriteLine("token found: " + c + ", " + r);
                        count++;
                    }
                    else
                    {
                        count = 0;
                    }
                    if (count == 4)
                    {
                        return true;
                    }
                }
            }

            // diagonal check
            for (int r = 0; r < 3; r++)
            {
                for (int c = 0; c < 7; c++)
                {
                    try
                    {
                        if (board.getCell(c, r).getToken() == p && board.getCell(c + 1, r + 1).getToken() == p &&
                        board.getCell(c + 2, r + 2).getToken() == p && board.getCell(c + 3, r + 3).getToken() == p)
                        {
                            return true;
                        }
                    }
                    catch (Exception) { }

                    try
                    {
                        if (board.getCell(c, r + 3).getToken() == p && board.getCell(c + 1, r + 2).getToken() == p &&
                        board.getCell(c + 2, r + 1).getToken() == p && board.getCell(c + 3, r).getToken() == p)
                        {
                            return true;
                        }
                    }
                    catch (Exception) { }
                }
            }

            return false;
        }

        private void btn_click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                string txt = btn.Tag.ToString();


                int col = int.Parse(txt.Substring(0, 1));
                int row = int.Parse(txt.Substring(3));


                Cell c = board.getCell(col, row);
                Console.WriteLine("Clicked on " + c.getCordCol() + ", " + c.getCordRow());
                Console.WriteLine("Button tag:" + c.getButton().Tag.ToString());


                //This section of code will allow a user to click on any button and have the program automatically place a disc at the lowest possible spot in the column they clicked.
                for (int i = 0; i < 6; i++)
                {

                    if (board.getCell(col, i).getToken() != 0)
                    {

                    }
                    else
                    {
                        c = board.getCell(col, i);
                        btn = c.getButton();
                        row = i;
                    }

                }


                //Checks what token is present on the button (0 for nothing, 1 for player 1, 2 for player 2
                //Then places it or places it lower
                if (board.getCell(col, row).getToken() == 0)
                {

                    //Checks if the cell below has a filled out token or not(or is at bottom of row
                    if (row == 5 || board.getCell(col, row + 1).getToken() == 1 || board.getCell(col, row + 1).getToken() == 2)
                    {
                        Console.WriteLine("Placing a disc.");
                        audioClickPlay();
                        placeDisc(row, col, btn);


                        //Switches player after button press
                        if (player.getPlayerTurn() == 1)
                        {
                            player.setPlayerTurn(2);
                            Console.WriteLine("Player 2 Turn");
                        }
                        turns++;
                    }


                    //Errors
                }
                else if (board.getCell(col, row).getToken() == 1)
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

                refreshSidebar();

                if (checkWin(1))
                {
                    winner(1);
                }
                else if (checkWin(2))
                {
                    winner(2);
                }
                else if (isGameDraw())
                {
                    draw();
                }

                wait();
                AIMove();
                refreshBoard();
            }
        }

        private void AIMove()
        {
            int col = 0;
            int row = 0;
            Cell c = null;

            Button btn = null;


            //This section of code will allow a user to click on any button and have the program automatically place a disc at the lowest possible spot in the column they clicked.
            int i = 0;
            bool outerLoop = true;
            while (outerLoop && i < 7)
            {
                for (int j = 0; j < 6; j++)
                {
                    if (j == 5 || board.getCell(i, j + 1).getToken() == 1 || board.getCell(i, j + 1).getToken() == 2)
                    {
                        if (board.getCell(i, j).getToken() == 0)
                        {
                            board.getCell(i, j).setToken(1);
                            if (checkWin(1))
                            {
                                c = board.getCell(i, j);
                                btn = c.getButton();
                                col = i;
                                row = j;
                                outerLoop = false;
                            }
                            board.getCell(i, j).setToken(2);
                            if (checkWin(2))
                            {
                                c = board.getCell(i, j);
                                btn = c.getButton();
                                col = i;
                                row = j;
                                outerLoop = false;
                            }
                            board.getCell(i, j).setToken(0);
                        }
                    }
                }
                i++;
            }


            if (c == null)
            {
                col = new Random().Next(0, 6);
                c = board.getCell(col, row);
                while (c.getToken() != 0)
                {
                    col = new Random().Next(0, 6);
                    c = board.getCell(col, row);
                }
                for (int k = 0; k < 6; k++)
                {

                    if (board.getCell(col, k).getToken() == 0)
                    {
                        c = board.getCell(col, k);
                        btn = c.getButton();
                        row = k;
                    }

                }
            }

            Console.WriteLine("Computer Clicked on " + c.getCordCol() + ", " + c.getCordRow());
            Console.WriteLine("Button tag:" + c.getButton().Tag.ToString());

            //Checks what token is present on the button (0 for nothing, 1 for player 1, 2 for player 2
            //Then places it or places it lower
            if (board.getCell(col, row).getToken() == 0)
            {
                //Checks if the cell below has a filled out token or not(or is at bottom of row
                if (row == 5 || board.getCell(col, row + 1).getToken() == 1 || board.getCell(col, row + 1).getToken() == 2)
                {
                    Console.WriteLine("Placing a disc.");
                    audioClickPlay();
                    placeDisc(row, col, btn);
                }
            }
            else if (board.getCell(col, row).getToken() == 1)
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


            player.setPlayerTurn(1);
            Console.WriteLine("Player 1 Turn");
            turns++;

            refreshSidebar();

            if (checkWin(1))
            {
                winner(1);
            }
            else if (checkWin(2))
            {
                winner(2);
            }
            else if (isGameDraw())
            {
                draw();
            }

            refreshBoard();
        }

        private Cell getAIMove(Board board)
        {
            //Check for any moves that would result in an instant win for the AI
            for (int col = 0; col < board.getNumCols(); col++)
            {
                for (int row = 0; row < board.getNumRows(); row++)
                {
                    if (board.getCell(col, row).getToken() == 0)
                    {
                        board.getCell(col, row).setToken(2);
                        if (checkWin(2))
                        {
                            board.getCell(col, row).setToken(0);
                            return board.getCell(col, row);
                        }
                        board.getCell(col, row).setToken(0);
                    }
                }
            }

            //Check for any moves that would result in a win for the player and block them
            for (int col = 0; col < board.getNumCols(); col++)
            {
                for (int row = 0; row < board.getNumRows(); row++)
                {
                    if (board.getCell(col, row).getToken() == 0)
                    {
                        board.getCell(col, row).setToken(1);
                        if (checkWin(1))
                        {
                            board.getCell(col, row).setToken(0);
                            return board.getCell(col, row);
                        }
                        board.getCell(col, row).setToken(0);
                    }
                }
            }

            //If no instant wins or blocks are available, make a random move
            Random rand = new Random();
            int colIndex = rand.Next(board.getNumCols());
            Cell cell = board.getCell(colIndex, board.getNumRows() - 1);

            while (cell.getToken() != 0)
            {
                colIndex = rand.Next(board.getNumCols());
                cell = board.getCell(colIndex, board.getNumRows() - 1);
            }
            return cell;
        }

        private void draw()
        {
            GameEndForm gef = new GameEndForm(this, "Game Draw", mm, turns, 0);
            gef.Show();
            panel_gamePanel.Enabled = false;
            lbl_p2Turn.ForeColor = Color.Gray;
            lbl_p2Turn.Font = new Font(lbl_p1Turn.Font, FontStyle.Regular);
            lbl_p1Turn.ForeColor = Color.Gray;
            lbl_p1Turn.Font = new Font(lbl_p1Turn.Font, FontStyle.Regular);
            Stats stats = new Stats();
            stats.Deserialize();
            stats.twoplayer_gameTieCount++;
            stats.twoplayer_gamesPlayedCount++;
            stats.Serialize();
        }
        private void winner(int playerWinner)
        {
            GameEndForm gef = new GameEndForm(this, (playerWinner == 1 ? "Player" : "Computer") + " Wins!", mm, turns, playerWinner);
            gef.Show();
            panel_gamePanel.Enabled = false;
            lbl_p2Turn.ForeColor = Color.Gray;
            lbl_p2Turn.Font = new Font(lbl_p1Turn.Font, FontStyle.Regular);
            lbl_p1Turn.ForeColor = Color.Gray;
            lbl_p1Turn.Font = new Font(lbl_p1Turn.Font, FontStyle.Regular);

            Stats stats = new Stats();
            stats.Deserialize();
            stats.twoplayer_gamesPlayedCount++;
            if (playerWinner == 1)
            {
                stats.oneplayer_playerWinCount++;
            }
            if (playerWinner == 2)
            {
                stats.oneplayer_computerWinCount++;
            }
            stats.Serialize();
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
            if (player.getPlayerTurn() == 1)
            {
                board.getCell(col, row).setToken(1);
                btn.BackColor = Color.Yellow;
            }
            else if (player.getPlayerTurn() == 2)
            {
                board.getCell(col, row).setToken(2);
                btn.BackColor = Color.Red;
            }

        }

        private void audioClickPlay()
        {
            //For sound
            Stream soundFile = Properties.Resources.token_click;
            SoundPlayer audio = new SoundPlayer(soundFile);
            audio.Play();
        }

        //Delays the ai a moment
        private void wait()
        {
            Task.Delay(1000).Wait();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_mouseHover(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button btn = (Button)sender;
                string txt = btn.Tag.ToString();


                int col = int.Parse(txt.Substring(0, 1));
                int row = int.Parse(txt.Substring(3));

                for (int i = 5; i >= 0; i--)
                {
                    if (board.getCell(col, i).getToken() == 1 || board.getCell(col, i).getToken() == 2)
                    {

                    }
                    else
                    {
                        btn = board.getCell(col, i).getButton();
                        if (player.getPlayerTurn() == 1)
                        {
                            btn.BackColor = Color.LightYellow;
                        }
                        else if (player.getPlayerTurn() == 2)
                        {
                            btn.BackColor = Color.PaleVioletRed;
                        }
                        break;
                    }
                }

            }
        }

        private void btn_mouseLeave(object sender, EventArgs e)
        {
            refreshBoard();
        }

        private void panel_gamePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
