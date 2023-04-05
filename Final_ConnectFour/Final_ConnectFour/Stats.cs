using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Linq;

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


                statsWriter.WriteStartElement("Statistics");

                statsWriter.WriteElementString("playerWinCount", "0");
                statsWriter.WriteElementString("computerWinCount", "0");
                statsWriter.WriteElementString("gameTieCount", "0");
                statsWriter.WriteElementString("gamesPlayedCount", "0");
                statsWriter.WriteElementString("playerWinPercentage", "0");
                statsWriter.WriteElementString("computerWinPercentage", "0");

                statsWriter.WriteEndElement();

                statsWriter.WriteEndDocument();
                statsWriter.Close();

                initialize();
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
