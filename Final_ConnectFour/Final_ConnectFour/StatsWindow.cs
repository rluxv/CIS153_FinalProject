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
        private MainMenu mm;

        float op_pwinpercent = 0;
        float op_cwinpercent = 0;
        float tp_p1winpercent = 0;
        float tp_p2winpercent = 0;
        public StatsWindow(MainMenu mainMenu)
        {
            InitializeComponent();

            mm = mainMenu;
            Stats stats = new Stats();
            stats.Deserialize();
            //lbl_gamesPlayed.Text = stats.gamesPlayedCount + "";

            lbl_oneplayer_playerwins.Text = stats.oneplayer_playerWinCount + "";
            lbl_oneplayer_computerwins.Text = stats.oneplayer_computerWinCount + "";
            lbl_oneplayer_draws.Text = stats.oneplayer_gameTieCount + "";
            lbl_oneplayer_totalgamesplayed.Text = stats.oneplayer_gamesPlayedCount + "";
            if(stats.oneplayer_gamesPlayedCount != 0)
            {
                Console.WriteLine(stats.oneplayer_playerWinCount);
                float wc = stats.oneplayer_playerWinCount;
                float gpc = stats.oneplayer_gamesPlayedCount;
                float cwc = stats.oneplayer_computerWinCount;

                op_pwinpercent = wc / gpc * 100;
                op_cwinpercent = cwc / gpc * 100;
            }
            
            lbl_oneplayer_playerwinpercent.Text = op_pwinpercent.ToString("#.##") + "%";
            lbl_oneplayer_computerwinpercent.Text = op_cwinpercent.ToString("#.##") + "%";




            lbl_twoplayer_p1wins.Text = stats.twoplayer_playerOneWinCount + "";
            lbl_twoplayer_p2wins.Text = stats.twoplayer_playerTwoWinCount + "";
            lbl_twoplayer_draws.Text = stats.twoplayer_gameTieCount + "";
            lbl_twoplayer_gamesplayed.Text = stats.twoplayer_gamesPlayedCount + "";
            if (stats.twoplayer_gamesPlayedCount != 0)
            {
                float p1wc = stats.twoplayer_playerOneWinCount;
                float gpc = stats.twoplayer_gamesPlayedCount;
                float p2wc = stats.twoplayer_playerTwoWinCount;

                tp_p1winpercent = p1wc / gpc * 100;
                tp_p2winpercent = p2wc / gpc * 100;
            }

            lbl_twoplayer_p1winpercent.Text = tp_p1winpercent.ToString("#.##") + "%";
            lbl_twoplayer_p2winpercent.Text = tp_p2winpercent.ToString("#.##") + "%";


        }

        private void StatsWindow_Load(object sender, EventArgs e)
        {

        }

        private void btn_returnToMenu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeWin(object sender, FormClosedEventArgs e)
        {
            mm.Show();
        }
    }
}
