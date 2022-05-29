using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using V3;

namespace V3
{
    public partial class WinNewGame : Form
    {
        public WinNewGame()
        {
            InitializeComponent();
        }

        private void WinNewGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void butGameStart_Click(object sender, EventArgs e)
        {

        }

        private void butBack_Click(object sender, EventArgs e)
        {
            WinMainMenu winMainMenu = new WinMainMenu();
            this.Hide();
            winMainMenu.Show();
        }
    }
}
