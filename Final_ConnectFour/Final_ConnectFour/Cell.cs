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
        private int xCord;
        private int yCord;
        Button btn;


        //Default Constructor
        public Cell()
        {
            Console.WriteLine("New Cell Created");
        }
        //Setter Constructor
        public Cell(int x, int y, Button b)
        {
            xCord = x;
            yCord = y;
            b = btn;
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
        public Button getButton()
        {
            return btn;
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
        public void setButton(Button b)
        {
            btn = b;
        }
    }
}
