using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GADE6112_Task_1
{
    public partial class MapForm : Form
    {
        private GADE6112_Task_1.Classes.GameEngine Game;
        public MapForm()
        {
            InitializeComponent();

            Game = new GADE6112_Task_1.Classes.GameEngine(this, 20, 40, 20, 30, 10);
            
        }

        private void btnUP_Click(object sender, EventArgs e)
        {

        }

        private void btnLEFT_Click(object sender, EventArgs e)
        {
            //Game.MovePlayer(Cha)
        }

        private void btnDOWN_Click(object sender, EventArgs e)
        {

        }

        private void btnRIGHT_Click(object sender, EventArgs e)
        {

        }
    }
}
