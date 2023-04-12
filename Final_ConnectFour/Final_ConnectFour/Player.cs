using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ConnectFour
{
    internal class Player
    {
        //Variables
        private int playerTurn;


        //Getters
        public int getPlayerTurn()
        {
            return playerTurn;
        }


        //Setters
        public void setPlayerTurn(int t)
        {
            playerTurn = t;
        }
    }
}
