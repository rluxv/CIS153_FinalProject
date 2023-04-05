using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;

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
        public Stats()
        {

        }
        private XmlDocument statsDoc;
        private int playerWinCount, computerWinCount, gameTieCount, gamesPlayedCount, playerWinPercentage, computerWinPercentage;
        
        public void initialize()
        {
            statsDoc = new XmlDocument();
            try
            {
                statsDoc.Load("Statistics.xml");
            }
            catch (FileNotFoundException ex)
            {
                //file does not exist, so we will create it
                var sts = new XmlWriterSettings()
                {
                    Indent = true,
                    IndentChars = "    "
                };

                XmlWriter statsWriter = XmlWriter.Create("Statistics.xml", sts);

                statsWriter.WriteStartDocument();

                statsWriter.WriteStartElement("playerWinCount");
                statsWriter.WriteValue(0);

                statsWriter.WriteStartElement("computerWinCount");
                statsWriter.WriteValue(0);

                statsWriter.WriteStartElement("gameTieCount");
                statsWriter.WriteValue(0);

                statsWriter.WriteStartElement("gamesPlayedCount");
                statsWriter.WriteValue(0);

                statsWriter.WriteStartElement("playerWinPercentage");
                statsWriter.WriteValue(0);

                statsWriter.WriteStartElement("computerWinPercentage");
                statsWriter.WriteValue(0);

                statsWriter.WriteEndDocument();
                statsWriter.Close();
            }
            
        }

        public void saveStat()
        {

        }

        public void getStat()
        {

        }
    }
}
