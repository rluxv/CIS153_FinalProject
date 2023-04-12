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
        //Token refers to whether or not the cell was already selected/has a token in it
        //0 is no token, 1 is p1 token, 2 is p2 token
        private int token;


        //I got rid of the "player" variable here and gave it its own class


        //Default Constructor
        public Cell()
        {
            Console.WriteLine("New Cell Created");
        }
        //Setter Constructor
        public Cell(int col, int row, Button b, int tok)
        {
            colCord = col;
            rowCord = row;
            btn=b;
            token = tok;
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

        public int getToken()
        {
            return token;
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

        public void setToken(int tok)
        {
            token = tok;
        }
    }
}
