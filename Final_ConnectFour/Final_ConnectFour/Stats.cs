using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_ConnectFour
{
    internal class Stats
    {
        enum STAT_TYPES
        {
            PLAYERWINCOUNT,
            COMPUTERWINCOUNT,
            GAMETIECOUNT,
            GAMESPLAYEDCOUNT,
            PLAYERWINPERCENTAGE,
            COMPUTERWINPERCENTAGE
        }
        Stats()
        {

        }

        private int playerWinCount, computerWinCount, gameTieCount, gamesPlayedCount, playerWinPercentage, computerWinPercentage;

        public void loadStatsFromFile()
        {

        }

        public void saveStat()
        {

        }

        public int getStat(int STAT_TYPES)
        {

            return 0;
        }
    }
}
