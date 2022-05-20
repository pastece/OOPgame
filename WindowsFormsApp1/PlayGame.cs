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
        private Stack<String> visitedTiles = new Stack<String>();
        




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
            List<QItem> list = new List<QItem>();

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    
                    Tile t = new Tile(i,j,Count);
                    tiles.Add(t);
                    Count++;
                    t.Pb.Click += (e, s) =>
                    {
                        if (t.Pb.BackColor == Color.White )
                        {
                            
                            if (Clicked1 == null && t.Pb.Image != null ) { 
                                
                                Clicked1 = t;
                                t.Pb.BackColor = Color.Gray;

                            }

                            else if (Clicked2 == null && t.Pb.Image == null && Clicked1 != null)
                            {
                                Clicked2 = t;
                                

                                if (minDistance(ref list))
                                {
                                    MoveTile(list);

                                }
                                else
                                {
                                    MessageBox.Show("No PATH for this move!");
                                    Clicked1.Pb.BackColor = Color.White;
                                    Clicked1 = null;
                                    Clicked2 = null;
                                    
                                }
                                
                                
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
        class QItem
        {
            public int row;
            public int col;
            public int dist;
            public QItem prev;
            public QItem(int x, int y, int w)
            {
                row = x;
                col = y;
                prev = null;
            }
        };



        bool minDistance(ref List<QItem> arr)
        {
            char[,] tiles2D = new char[Row, Column];
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {


                    if (!isEmptyTile(tiles[(i*Row)+j])) tiles2D[i, j] = '0';
                    if (isEmptyTile(tiles[(i * Row)+ j])) tiles2D[i, j] = '*';
                    if (i == Clicked1.x && j == Clicked1.y) tiles2D[i, j] = 's';
                    if (i == Clicked2.x && j == Clicked2.y) tiles2D[i, j] = 'd';
                }
            }


            QItem source = new QItem(0, 0, 0);

            // To keep track of visited QItems. Marking
            // blocked cells as visited.
            bool[,] visited = new bool[Row, Column];
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (tiles2D[i, j] == '0')
                        visited[i, j] = true;
                    else
                        visited[i, j] = false;

                    // Finding source
                    if (tiles2D[i, j] == 's')
                    {
                        source.row = i;
                        source.col = j;
                    }
                }
            }

            // applying BFS on matrix cells starting from source
            List<QItem> list = new List<QItem>();
            list.Add(source);
            visited[source.row, source.col] = true;
            while (list.Any())
            {
                QItem p = list[0];
                list.RemoveAt(0);

                // Destination found;
                if (tiles2D[p.row, p.col] == 'd')
                {
                    while (p != null)
                    {
                        arr.Add(p);
                        p = p.prev;
                    }
                    return true;
                }


                // moving up
                if (p.row - 1 >= 0 &&
                    visited[p.row - 1, p.col] == false)
                {
                    QItem q = new QItem(p.row - 1, p.col, p.dist + 1);
                    q.prev = p;
                    list.Add(q);
                    visited[p.row - 1, p.col] = true;
                }

                // moving down
                if (p.row + 1 < Row &&
                    visited[p.row + 1, p.col] == false)
                {
                    QItem q = new QItem(p.row + 1, p.col, p.dist + 1);
                    q.prev = p;
                    list.Add(q);
                    visited[p.row + 1, p.col] = true;
                }

                // moving left
                if (p.col - 1 >= 0 &&
                    visited[p.row, p.col - 1] == false)
                {
                    QItem q = new QItem(p.row, p.col - 1, p.dist + 1);
                    q.prev = p;
                    list.Add(q);
                    visited[p.row, p.col - 1] = true;
                }

                // moving right
                if (p.col + 1 < Column &&
                    visited[p.row, p.col + 1] == false)
                {
                    QItem q = new QItem(p.row, p.col + 1, p.dist + 1);
                    q.prev = p;
                    list.Add(q);
                    visited[p.row, p.col + 1] = true;
                }
            }
            return false;
        }










       

        private bool isEmptyTile(Tile tile)
        {

            return tile.Pb.Image == null;
        }

        private void MoveTile(List<QItem> list)
        {
            int sleepTime = 1000;
            Image temp;
            list.Reverse();
            for (int i = 0; i < list.Count - 1; i++)
            {

                int sourceIndex = (list[i].row * Row) + list[i].col;
                int destinationIndex = (list[i + 1].row * Row) + list[i + 1].col;

                tiles[destinationIndex].Pb.BackColor = Color.White;

                Task.Delay(sleepTime).Wait();

                temp = tiles[destinationIndex].Pb.Image;
                tiles[destinationIndex].Pb.Image = tiles[sourceIndex].Pb.Image;
                tiles[sourceIndex].Pb.Image = temp;
                
                
                tiles[sourceIndex].Pb.BackColor = Color.White;
                tiles[destinationIndex].Pb.BackColor = Color.Gray;
                
            }
            //Task.Delay(sleepTime).Wait();
            Clicked1 = null;
            Clicked2 = null;
            tiles[(list[list.Count-1].row*Row)+ (list[list.Count-1].col)].Pb.BackColor = Color.White;
            list.Clear();
            
            
            RandomShapes();
            

        }

        public int sumScore(Tile t1)
        {
            int score = 0;
            return score;



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
                            tiles[tile].color = 0;
                            break;

                        case 1:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.redsquare;
                            tiles[tile].color = 1;
                            break;

                        case 2:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.redtriangle;
                            tiles[tile].color = 2;
                            break;

                        case 3:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.bluecircle;
                            tiles[tile].color = 3;
                            break;

                        case 4:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.bluesquare;
                            tiles[tile].color = 4;
                            break;

                        case 5:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.bluetriangle;
                            tiles[tile].color = 5;
                            break;

                        case 6:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.greencircle;
                            tiles[tile].color = 6;
                            break;

                        case 7:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.greensquare;
                            tiles[tile].color = 7;
                            break;

                        case 8:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.greentriangle;
                            tiles[tile].color = 8;
                            break;
                    }
                }
                else i--;
            }

        }
    }
}
