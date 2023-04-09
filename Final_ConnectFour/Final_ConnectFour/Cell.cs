using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_ConnectFour
{
    internal class Cell
    {
        //Variables
        private int colCord;
        private int rowCord;
        Button btn;
        
        // 0 equals no player, 1 equals player 1, 2 equals player 2/ai (this will be used to determine the winner)
        int player;


        //Default Constructor
        public Cell()
        {
            Console.WriteLine("New Cell Created");
            player = 0;
        }
        //Setter Constructor
        public Cell(int col, int row, Button b, int player)
        {
            colCord = col;
            rowCord = row;
            b = btn;
            this.player = player;
            Console.WriteLine("New Cell Created");
        }

        //============================
        //Getters
        public int getCordCol()
        {
            return colCord;
        }
        public int getCordRow()
        {
            return rowCord;
        }
        public Button getButton()
        {
            return btn;
        }

        public int getPlayer()
        {
            return player;
        }


        //===========================
        //Setters
        public void setCordCol(int x)
        {
            colCord = x;
        }
        public void setCordRow(int y)
        {
            rowCord = y;
        }
        public void setButton(Button b)
        {
            btn = b;
        }

        public void setPlayer(int player)
        {
            this.player = player;
        }
    }
}
