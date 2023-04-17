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
        public int playerWinCount { get; set; }
        public int computerWinCount { get; set; }
        public int gameTieCount { get; set; }
        public int gamesPlayedCount { get; set; }
        public int playerWinPercentage { get; set; }
        public int computerWinPercentage { get; set; }

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

                playerWinCount = s.playerWinCount;
                computerWinCount = s.computerWinCount;
                gameTieCount = s.gameTieCount;
                gamesPlayedCount = s.gamesPlayedCount;
                playerWinPercentage = s.playerWinPercentage;
                computerWinPercentage = s.computerWinPercentage;
            }
            catch (FileNotFoundException ex)
            {
                Serialize();
                Deserialize();
            }

        }
    }
}
