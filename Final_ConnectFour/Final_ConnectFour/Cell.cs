using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ConnectFour
{
    internal class Cell
    {
        //Variables
        private int xCord;
        private int yCord;
        private char val;


        //Default Constructor
        public Cell()
        {
            Console.WriteLine("New Cell Created");

            //Probably add something relating to the "val" later
        }
        //Setter Constructor
        public Cell(int x, int y)
        {
            xCord = x;
            yCord = y;

            //Probably add something relating to the "val" later
        }

        //============================
        //Getters
        public int getCordX()
        {
            return xCord;
        }
        public int getCordY()
        {
            return yCord;
        }
        public char getCellVal()
        {
            return val;
        }

        //===========================
        //Setters
        public void setCordX(int x)
        {
            xCord = x;
        }
        public void setCordY(int y)
        {
            yCord= y;
        }
        public void setCellVal(char v)
        {
            val = v;
        }
    }
}
