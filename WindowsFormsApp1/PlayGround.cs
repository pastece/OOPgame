using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{

    public partial class PlayGround : Form
    {
        public PlayGround()
        {
            InitializeComponent();
            startGame();
           

        }

        private void PlayGround_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult secim = new DialogResult();
            secim = MessageBox.Show("Do you want to close the program ? ", "Close", MessageBoxButtons.YesNo);

            if (secim == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (secim == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        public void startGame()
        {
            Settings settings = new Settings();
            int r = settings.row;
            int c = settings.column;
            PlayGame game = new PlayGame(r, c);
            game.createGameBoard();
            for (int i = 0; i < r*c; i++)
            {
                Controls.Add(game.tiles[i].pb);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainGame mg = new mainGame();
            mg.Show();
            this.Hide();
        }
    }
}
