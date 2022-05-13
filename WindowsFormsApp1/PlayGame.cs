using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;


namespace WindowsFormsApp1
{
    class PlayGame
    {
        public List<Tile> tiles=new List<Tile>();
        private readonly int Row;
        private readonly int Column;
        private int Count;
        private Tile Clicked1;
        private Tile Clicked2;

        public PlayGame(int r, int c)
        {
            Count = 0;
            Row = r;
            Column = c;
            CreateGameBoard();
            RandomShapes();

            
        }

      

        public void CreateGameBoard()
        {
            PlayGround playGround = new PlayGround();
            playGround.Show();
            
            
            for (int i = 1; i <= Row; i++)
            {
                for (int j = 1; j <= Column; j++)
                {
                    
                    Tile t = new Tile(i,j,Count);
                    tiles.Add(t);
                    Count++;
                    t.Pb.Click += (s, e) =>
                    {
                        if (t.Pb.BackColor == Color.White)
                        {
                            t.Pb.BackColor = Color.Gray;
                            if (Clicked1 == null) Clicked1 = t;
                            else if (Clicked2 == null)
                            {
                                Clicked2 = t;
                                MoveTile(Clicked1, Clicked2);
                            }
                        }
                        else
                        {
                            t.Pb.BackColor = Color.White;
                            Clicked1 = null;
                        }
                    };
                    playGround.Controls.Add(t.Pb);
                }
            }
        }

        

       

        public void MoveTile(Tile t1, Tile t2)
        {
            
            Image temp;
            temp=t2.Pb.Image;
            t2.Pb.Image = t1.Pb.Image;
            t1.Pb.Image = temp;
            t1.Pb.BackColor = Color.White;
            t2.Pb.BackColor = Color.White;            
            Clicked1 = null;
            Clicked2 = null;
            RandomShapes();

        }

        public void RandomShapes()
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int tile = random.Next(0, Row*Column);
                int shape = random.Next(0, 9);

                if (tiles[tile].Pb.Image == default)
                {

                    switch (shape)
                    {
                        case 0:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.redcircle;
                            break;

                        case 1:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.redsquare;
                            break;

                        case 2:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.redtriangle;
                            break;

                        case 3:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.bluecircle;
                            break;

                        case 4:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.bluesquare;
                            break;

                        case 5:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.bluetriangle;
                            break;

                        case 6:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.greencircle;
                            break;

                        case 7:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.greensquare;
                            break;

                        case 8:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.greentriangle;
                            break;
                    }
                }
                else i--;
            }

        }
    }
}
