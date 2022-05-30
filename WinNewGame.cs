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
        private int numberOfPlayer;

        public int NumberOfPlayers { get { return numberOfPlayer; } set { numberOfPlayer = value; } }

        //Alapból csak az első sor látszódik
        public WinNewGame()
        {
            InitializeComponent();
            labPlayer2.Hide();
            teBoPlayerName2.Hide();
            labPlayer3.Hide();
            teBoPlayerName3.Hide();
            labPlayer4.Hide();
            teBoPlayerName4.Hide();
            labPlayer5.Hide();
            teBoPlayerName5.Hide();

            butGameStart.Enabled = false;
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

        //Minden textBox-nak saját boolja van ami azért felelős hogy ne fusson a kb init része minden egyes karakter leütésnél
        private bool booPlayer1 = true;

        private void teBoPlayerName1_TextChanged(object sender, EventArgs e)
        {
            //Ha először fut le megjelenítjük a következő sort és mozgatjuk a gombokat
            if (booPlayer1)
            {
                labPlayer2.Show();
                teBoPlayerName2.Show();
                butGameStart.Location = new Point(butGameStart.Location.X, butGameStart.Location.Y + 26);
                butBack.Location = new Point(butBack.Location.X, butBack.Location.Y + 26);
                NumberOfPlayers = 1;
                butGameStart.Enabled = true;
                booPlayer1 = false;
            }
            //Ha az első textBox üres és a második sor textBox-a is akkor eltünteti a második sort és az elsőt olyanná teszi mintha még nem lett volna bele írva
            else if (teBoPlayerName1.Text == "" && teBoPlayerName2.Text == "")
            {
                labPlayer2.Hide();
                teBoPlayerName2.Hide();
                butGameStart.Location = new Point(butGameStart.Location.X, 38);
                butBack.Location = new Point(butBack.Location.X, 38);
                NumberOfPlayers = 0;
                butGameStart.Enabled = false;
                booPlayer1 = true;
            }
            //Ha az első sor üres de a második nem akkor az összes textBox Text-ét az egyel korábbi sorba írja
            else if (teBoPlayerName1.Text == "" && teBoPlayerName2.Text != "")
            {
                teBoPlayerName1.Text = teBoPlayerName2.Text;
                teBoPlayerName2.Text = teBoPlayerName3.Text;
                teBoPlayerName3.Text = teBoPlayerName4.Text;
                teBoPlayerName4.Text = teBoPlayerName5.Text;
                teBoPlayerName5.Text = "";
            }
        }

        //Minden textBox-nak saját boolja van ami azért felelős hogy ne fusson a kb init része minden egyes karakter leütésnél
        private bool booPlayer2 = true;
       
        private void teBoPlayerName2_TextChanged(object sender, EventArgs e)
        {
            //Ha először fut le megjelenítjük a következő sort és mozgatjuk a gombokat
            if (booPlayer2)
            {
                labPlayer3.Show();
                teBoPlayerName3.Show();
                butGameStart.Location = new Point(butGameStart.Location.X, butGameStart.Location.Y + 26);
                butBack.Location = new Point(butBack.Location.X, butBack.Location.Y + 26);
                NumberOfPlayers = 2;
                booPlayer2 = false;
            }

            //Ha a második textBox üres és a harmadik sor textBox-a is akkor eltünteti a harmadik sort és a másodikat olyanná teszi mintha még nem lett volna bele írva
            else if (teBoPlayerName2.Text == "" && teBoPlayerName3.Text == "")
            {
                labPlayer3.Hide();
                teBoPlayerName3.Hide();
                butGameStart.Location = new Point(butGameStart.Location.X, butGameStart.Location.Y - 26);
                butBack.Location = new Point(butBack.Location.X, butBack.Location.Y - 26);
                NumberOfPlayers = 1;
                booPlayer2 = true;
            }

            //Ha a második sor üres de a harmadik nem akkor az összes textBox Text értékét az egyel korábbi sorba írja
            else if (teBoPlayerName2.Text == "" && teBoPlayerName3.Text != "")
            {
                teBoPlayerName2.Text = teBoPlayerName3.Text;
                teBoPlayerName3.Text = teBoPlayerName4.Text;
                teBoPlayerName4.Text = teBoPlayerName5.Text;
                teBoPlayerName5.Text = "";
            }
        }

        //Minden textBox-nak saját boolja van ami azért felelős hogy ne fusson a kb init része minden egyes karakter leütésnél
        private bool booPlayer3 = true;

        private void teBoPlayerName3_TextChanged(object sender, EventArgs e)
        {
            //Ha először fut le megjelenítjük a következő sort és mozgatjuk a gombokat
            if (booPlayer3)
            {
                labPlayer4.Show();
                teBoPlayerName4.Show();
                butGameStart.Location = new Point(butGameStart.Location.X, butGameStart.Location.Y + 26);
                butBack.Location = new Point(butBack.Location.X, butBack.Location.Y + 26);
                NumberOfPlayers = 3;
                booPlayer3 = false;
            }

            //Ha a harmadik textBox üres és a negyedik sor textBox-a is akkor eltünteti a negyedik sort és a harmadikat olyanná teszi mintha még nem lett volna bele írva
            else if (teBoPlayerName3.Text == "" && teBoPlayerName4.Text == "")
            {
                labPlayer4.Hide();
                teBoPlayerName4.Hide();
                butGameStart.Location = new Point(butGameStart.Location.X, butGameStart.Location.Y - 26);
                butBack.Location = new Point(butBack.Location.X, butBack.Location.Y - 26);
                NumberOfPlayers = 2;
                booPlayer3 = true;
            }

            //Ha a harmadik sor üres de a negyedik nem akkor az összes textBox Text értékét az egyel korábbi sorba írja
            else if (teBoPlayerName3.Text == "" && teBoPlayerName4.Text != "")
            {
                teBoPlayerName3.Text = teBoPlayerName4.Text;
                teBoPlayerName4.Text = teBoPlayerName5.Text;
                teBoPlayerName5.Text = "";
            }
        }

        //Minden textBox-nak saját boolja van ami azért felelős hogy ne fusson a kb init része minden egyes karakter leütésnél
        private bool booPlayer4 = true;

        private void teBoPlayerName4_TextChanged(object sender, EventArgs e)
        {
            //Ha először fut le megjelenítjük a következő sort és mozgatjuk a gombokat
            if (booPlayer4)
            {
                labPlayer5.Show();
                teBoPlayerName5.Show();
                butGameStart.Location = new Point(butGameStart.Location.X, butGameStart.Location.Y + 26);
                butBack.Location = new Point(butBack.Location.X, butBack.Location.Y + 26);
                NumberOfPlayers = 4;
                booPlayer4 = false;
            }

            //Ha a negyedik textBox üres és az ötödik sor textBox-a is akkor eltünteti az ötödik sort és a negyediket olyanná teszi mintha még nem lett volna bele írva
            else if (teBoPlayerName4.Text == "" && teBoPlayerName5.Text == "")
            {
                labPlayer5.Hide();
                teBoPlayerName5.Hide();
                butGameStart.Location = new Point(butGameStart.Location.X, butGameStart.Location.Y - 26);
                butBack.Location = new Point(butBack.Location.X, butBack.Location.Y - 26);
                NumberOfPlayers = 3;
                booPlayer4 = true;
            }

            //Ha a negyedik sor üres de az ötödik nem akkor az összes textBox Text értékét az egyel korábbi sorba írja
            else if (teBoPlayerName4.Text == "" && teBoPlayerName5.Text != "")
            {
                teBoPlayerName4.Text = teBoPlayerName5.Text;
                teBoPlayerName5.Text = "";
            }
        }

        //Minden textBox-nak saját boolja van ami azért felelős hogy ne fusson a kb init része minden egyes karakter leütésnél
        private bool booPlayer5 = true;

        private void teBoPlayerName5_TextChanged(object sender, EventArgs e)
        {
            //Mivel nincs következő sor így csak beállítjuk a játékosok számát 5-re
            if (booPlayer5)
            {
                NumberOfPlayers = 5;
                booPlayer5 = false;
            }
            //Ha üres a textBox akkor a játékosok száma 4
            else if (teBoPlayerName5.Text == "")
            {
                NumberOfPlayers = 4;
                booPlayer5 = true;
            }
        }
    }
}
