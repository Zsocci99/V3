﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace V3
{
    public partial class WinMainMenu : Form
    {
        public WinMainMenu()
        {
            InitializeComponent();
        }

        private void butNewGame_Click(object sender, EventArgs e)
        {
            WinNewGame winNewGame = new WinNewGame();
            this.Hide();
            winNewGame.Show();
        }

        private void butTotirial_Click(object sender, EventArgs e)
        {
            WinTutorial winTutorial = new WinTutorial();
            this.Hide();
            winTutorial.Show();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void WinMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            butExit_Click(sender,e);
        }
    }
}
