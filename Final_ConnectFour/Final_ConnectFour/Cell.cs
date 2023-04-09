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
        
        // 0 equals no player, 1 equals player 1, 2 equals player 2/ai (this will be used to determine the winner)
        int player;


        //Default Constructor
        public Cell()
        {
            Console.WriteLine("New Cell Created");
            player = 0;
        }
        //Setter Constructor
        public Cell(int x, int y, Button b, int player)
        {
            xCord = x;
            yCord = y;
            b = btn;
            this.player = player;
            Console.WriteLine("New Cell Created");
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

        public int getPlayer()
        {
            return player;
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

        public void setPlayer(int player)
        {
            this.player = player;
        }
    }
}
