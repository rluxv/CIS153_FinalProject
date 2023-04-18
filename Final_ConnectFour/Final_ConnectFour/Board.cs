using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_ConnectFour
{
    internal class Board
    {

        public Board()
        {

        }

        private const int numCols = 7;
        private const int numRows = 6;
        
        private Cell[,] gameBoard = new Cell[numCols, numRows];


        //Getters
        public int getNumRows()
        {
            return numRows;
        }
        public int getNumCols()
        {
            return numCols;
        }
        //Maybe I want to be able to get an individual cell from the gameboard given row and col
        public Cell getCell(int col, int row)
        {
            return gameBoard[col, row];
        }

        //Maybe we want to be able to view the entire board not just a cell
        public Cell[,] getGameBoard()
        {
            return gameBoard;
        }


        //however, you could definitely pass a full board
        public void setGameBoardCell(Cell cell)
        {
            //the only reason I can do this is because I am going to make sure that I 
            //set the row and col of a cell before I add it to the board
            gameBoard[cell.getCordCol(), cell.getCordRow()] = cell;
        }

        public void initialize()
        {
            
            // we will set the coordinates for each cell
            for (int col = 0; col < numCols; col++)
            {
                for(int row = 0; row < numRows; row++)
                {
                    gameBoard[col, row] = new Cell();
                    gameBoard[col, row].setCordCol(col);
                    gameBoard[col, row].setCordRow(row);
                }
                
            }
        }
    }
}
