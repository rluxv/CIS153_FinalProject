using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Final_ConnectFour
{
    public class Stats
    {
        // This breaks the rule of private class members,
        // however XML serialization does not work if the
        // members are private;

        public int oneplayer_playerWinCount { get; set; }
        public int oneplayer_computerWinCount { get; set; }
        public int oneplayer_gameTieCount { get; set; }
        public int oneplayer_gamesPlayedCount { get; set; }
        public int oneplayer_playerWinPercentage { get; set; }
        public int oneplayer_computerWinPercentage { get; set; }


        public int twoplayer_playerOneWinCount { get; set; }
        public int twoplayer_playerTwoWinCount { get; set; }
        public int twoplayer_gameTieCount { get; set; }
        public int twoplayer_gamesPlayedCount { get; set; }
        public int twoplayer_playerOneWinPercentage { get; set; }
        public int twoplayer_playerTwoWinPercentage { get; set; }


        public Stats()
        {

        }

        public void Serialize()
        {
            using (StreamWriter writer = File.CreateText("statistics.xml"))
            {
                System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(this.GetType());
                x.Serialize(writer, this);
            }
        }

        public void Deserialize()
        {
            //XmlDocument statsDoc = new XmlDocument();
            try
            {
                //statsDoc.Load("statistics.xml");


                XmlSerializer serializer = new XmlSerializer(typeof(Stats));

                // Declare an object variable of the type to be deserialized.
                Stats s;

                using (Stream reader = new FileStream("statistics.xml", FileMode.Open))
                {
                    // Call the Deserialize method to restore the object's state.
                    s = (Stats)serializer.Deserialize(reader);
                }

                oneplayer_playerWinCount = s.oneplayer_playerWinCount;
                oneplayer_computerWinCount = s.oneplayer_computerWinCount;
                oneplayer_gameTieCount = s.oneplayer_gameTieCount;
                oneplayer_gamesPlayedCount = s.oneplayer_gamesPlayedCount;
                oneplayer_playerWinPercentage = s.oneplayer_playerWinPercentage;
                oneplayer_computerWinPercentage = s.oneplayer_computerWinPercentage;

                twoplayer_playerOneWinCount = s.twoplayer_playerOneWinCount;
                twoplayer_playerTwoWinCount = s.twoplayer_playerTwoWinCount;
                twoplayer_gameTieCount = s.twoplayer_gameTieCount;
                twoplayer_gamesPlayedCount = s.twoplayer_gamesPlayedCount;
                twoplayer_playerOneWinPercentage = s.twoplayer_playerOneWinPercentage;
                twoplayer_playerTwoWinPercentage = s.twoplayer_playerTwoWinPercentage;
            }
            catch (FileNotFoundException ex)
            {
                Serialize();
                Deserialize();
            }

        }
    }
}
