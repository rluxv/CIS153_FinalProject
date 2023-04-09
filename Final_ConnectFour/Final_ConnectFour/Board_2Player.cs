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
    public partial class Board_2Player : Form
    {

        Board board;

        public Board_2Player()
        {
            InitializeComponent();
            board = new Board();
            board.initialize();
        }

        private void Board_2Player_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_click(object sender, EventArgs e)
        {
            if(sender is Button)
            {
                Button btn = (Button)sender;
                string txt = btn.Text;
                int row = int.Parse(txt.Substring(0, 1));
                int col = int.Parse(txt.Substring(3));

                //Console.WriteLine(x);
                //Console.WriteLine(y);

                Cell c = board.getCell(row, col);
                Console.WriteLine("Clicked on " + c.getCordCol() + ", " + c.getCordRow());
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
