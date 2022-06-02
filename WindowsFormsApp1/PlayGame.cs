using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;



namespace WindowsFormsApp1
{
    class PlayGame
    {
        PlayGround playGround;
        public List<Tile> tiles=new List<Tile>();
        private Stack<String> visitedTiles = new Stack<String>();
        //int[,] ButtonInfo = new int[20,20];


        private int score  { get; set; }


        private readonly int Row;
        private readonly int Column;
        private int Count;
        public static int bestScore;


        private Tile Clicked1;
        private Tile Clicked2;


       
        public PlayGame(int r, int c)
        {
            Count = 0;
            Row = r;
            Column = c;
            score = 0;
            playGround = new PlayGround();
            bestScore = int.Parse(profileScreen.score);
            playGround.labelBest.Text = "Best Score: " + bestScore.ToString();
            CreateGameBoard();
            RandomShapes();
        }
        
        int[,] tilesAdd = new int[20,20];

        public void CreateGameBoard()
        {
            playGround.Show();
            List<QItem> list = new List<QItem>();


            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    
                    Tile t = new Tile(i,j,Count);
                    tiles.Add(t);
                    tilesAdd[i, j] = 0;
                    
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
                                    scoreCheck();
                                    Clicked1 = null;
                                    Clicked2 = null;

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
            int sleepTime = 1;
            list.Reverse();
            for (int i = 0; i < list.Count - 1; i++)
            {

                int sourceIndex = (list[i].row * Row) + list[i].col;
                int destinationIndex = (list[i + 1].row * Row) + list[i + 1].col;

                tiles[destinationIndex].Pb.BackColor = Color.White;

                Task.Delay(sleepTime).Wait();

                //temp = tiles[destinationIndex].Pb.Image;
                tiles[destinationIndex].Pb.Image = tiles[sourceIndex].Pb.Image;
                tiles[sourceIndex].Pb.Image = default;
                
                tiles[sourceIndex].Pb.BackColor = Color.White;
                tiles[destinationIndex].Pb.BackColor = Color.Gray;
                
            }
            int sayi = tilesAdd[Clicked1.x, Clicked1.y];
            tilesAdd[Clicked2.x, Clicked2.y] = sayi;
            tilesAdd[Clicked1.x, Clicked1.y] = 0;

            //Task.Delay(sleepTime).Wait();


            tiles[(list[list.Count-1].row*Row)+ (list[list.Count-1].col)].Pb.BackColor = Color.White;
            list.Clear();

            
            RandomShapes();
            


        }
        void scoreCheck()
        {
           
            
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column - 4; j++)
                {

                    int[,] arrXCoordinate = new int[5, 2];
                    int pickedShape = tilesAdd[i, j];
                    int shapeCount = 0;

                    for (int k = 0; k < 5; k++)
                    {
                        if (tilesAdd[i, k + j] == pickedShape && tilesAdd[i, k + j] != 0) 
                        {
                            arrXCoordinate[k, 0] = i;
                            arrXCoordinate[k, 1] = k + j;
                            shapeCount++;

                        }
                        else
                        {
                            break;
                        }
                       
                    }
                    if (shapeCount == 5)
                    {                      
                        removeShape(arrXCoordinate);
                    }
                }
            }

      

            for (int i = 0; i < Column; i++)
            {
                for (int j = 0; j < Row - 4; j++)
                {
                    int[,] arrYCoordinate = new int[5, 2];
                    int pickedShape = tilesAdd[j, i];
                    int shapeCount = 0;

                    for (int k = 0; k < 5; k++)
                    {
                        if (tilesAdd[k + j, i] == pickedShape && tilesAdd[k + j, i] != 0) 
                        {
                            arrYCoordinate[k, 0] = k + j;
                            arrYCoordinate[k, 1] = i;
                            shapeCount++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (shapeCount == 5)
                    {
                        removeShape(arrYCoordinate);
                    } 
                }
            }
        }

       void removeShape(int[,] arr)
        {
            
            for (int i = 0; i < 5; i++)
            {
                Task.Delay(50).Wait();
                tilesAdd[arr[i, 0], arr[i, 1]] = 0;
                tiles[(arr[i, 0] * Row) + arr[i, 1]].Pb.Image = default;
                
            }
            
            sumScore();
            playGround.labelCurrent.Text = "Current Score: "+score.ToString();
            if (score > bestScore)
            {
                bestScore = score;
                playGround.labelBest.Text = "Best Score: " + bestScore.ToString();
                profileScreen.score = bestScore.ToString();
                XDocument xdosya = XDocument.Load(@"usersInfo.xml");
                XElement node = xdosya.Element("Users").Elements("User").FirstOrDefault(a => a.Element("UserName").Value.Trim() == profileScreen.username);
                node.SetElementValue("Score", bestScore);
                xdosya.Save(@"usersInfo.xml");

            }


        }
            public void sumScore()
        {
            Settings st = new Settings();
            

            if (st.cmboxDiffuculty.Text == "Easy")
            {
                score += 1;
                

            }
            else if (st.cmboxDiffuculty.Text == "Medium")
            {
                score += 3;
                
            }
            else if (st.cmboxDiffuculty.Text == "Hard")
            {
                score += 5;
                
            }
            else 
            {
                score += 2;
                
            }
 
        }

        public void RandomShapes()
        {
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                int tile = random.Next(0, Row*Column);
                int shape = random.Next(1, 10);
                Tile t;
                int r, c;
                t = tiles[tile];
                r = t.x;
                c = t.y;

                if (tiles[tile].Pb.Image == default)
                {

                    switch (shape)
                    {
                        case 1:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.redcircle;
                           

                            tilesAdd[r, c] = shape;
                            break;

                        case 2:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.redsquare;
                            tilesAdd[r, c] = shape;
                            break;

                        case 3:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.redtriangle;
                            tilesAdd[r, c] = shape; ;
                            break;

                        case 4:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.bluecircle;
                            tilesAdd[r, c] = shape;
                            break;

                        case 5:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.bluesquare;
                            tilesAdd[r, c] = shape;
                            break;

                        case 6:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.bluetriangle;
                            tilesAdd[r, c] = shape;
                            break;

                        case 7:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.greencircle;
                            tilesAdd[r, c] = shape;
                            break;

                        case 8:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.greensquare;
                            tilesAdd[r, c] = shape;
                            break;

                        case 9:
                            tiles[tile].Pb.Image = global::WindowsFormsApp1.Properties.Resources.greentriangle;
                            tilesAdd[r, c] = shape;
                            break;
                    }
                }
                else i--;
            }

        }
    }
}
