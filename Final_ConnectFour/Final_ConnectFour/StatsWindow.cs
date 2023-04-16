using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_ConnectFour
{
    public partial class StatsWindow : Form
    {
        public StatsWindow()
        {
            InitializeComponent();

            Stats stats = new Stats();
            stats.Deserialize();
            lbl_gamesPlayed.Text = stats.gamesPlayedCount + "";
        }

        private void StatsWindow_Load(object sender, EventArgs e)
        {

        }
    }
}
