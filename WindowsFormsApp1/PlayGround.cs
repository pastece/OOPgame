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
        private int count;
        public PlayGround()
        {
            
            Settings settings = new Settings();
            int r = settings.row;
            int c = settings.column;


            InitializeComponent();
            this.Size = new Size(67*r,70*c);
            startGame();
            
            Tile tile = new Tile(r, c, count);

            tile.Pb.MouseClick += Pb_MouseClick;
            
        }

        private void Pb_MouseClick(object sender, MouseEventArgs e)
        {
            Settings settings = new Settings();
            int r = settings.row;
            int c = settings.column;
            Tile tile = new Tile(r, c, count);


            Graphics g;
            Pen draw = new Pen(Color.White, 3);
            g = tile.Pb.CreateGraphics();
            g.DrawRectangle(draw, Cursor.Position.X - 10, Cursor.Position.Y - 10, 100, 100);
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
            game.CreateGameBoard();
            for (int i = 0; i < r*c; i++)
            {
                
                Controls.Add(game.tiles[i].Pb);

            }
            game.RandomShapes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mainGame mg = new mainGame();
            mg.Show();
            this.Hide();
        }

        

    }
}
