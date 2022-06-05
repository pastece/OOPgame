﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;
using System.Data;
using System.Media;



namespace WindowsFormsApp1
{
    class PlayGame
    {
        PlayGround playGround;
        public List<Tile> tiles=new List<Tile>();
        private Stack<String> visitedTiles = new Stack<String>();

        String connetionString = @"workstation id=OOPGAME.mssql.somee.com;packet size=4096;user id=pastace_SQLLogin_1;pwd=7xbcp7q2cu;data source=OOPGAME.mssql.somee.com;persist security info=False;initial catalog=OOPGAME";
        SqlConnection cnn;


        SoundPlayer soundMove = new SoundPlayer(@"C:\Repositories\OOPgame\WindowsFormsApp1\Resources\sound.wav");
        SoundPlayer soundRemove = new SoundPlayer(@"C:\Repositories\OOPgame\WindowsFormsApp1\Resources\soundRemove.wav");

        private int score  { get; set; }


        private readonly int Row;
        private readonly int Column;
        private int Count;
        public static int bestScore;
        private static int countRemove = 0;


        private Tile Clicked1;
        private Tile Clicked2;


       
        public PlayGame(int r, int c)
        {
            Count = 0;
            Row = r;
            Column = c;
            score = 0;
            
            CreateGameBoard();
            RandomShapes();
        }
        
        int[,] tilesAdd = new int[20,20];

        public void CreateGameBoard()
        {
            playGround = new PlayGround();
            bestScore = int.Parse(profileScreen.score);
            playGround.labelBest.Text = "Best Score: " + bestScore.ToString();

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
                            
                            if (Clicked1 == default && t.Pb.Image != default ) {

                                if (tilesAdd[i, j] == 0)
                                {
                                    t.Pb.Enabled = true;
                                    Clicked1 = t;
                                    t.Pb.BackColor = Color.Gray;
                                }
                                else
                                {
                                    t.Pb.Enabled = false;
                                }

                            }
                           
                            else if (Clicked2 == default && t.Pb.Image == default&& Clicked1 != default)
                            {
                                Clicked2 = t;
                                

                                if (minDistance(ref list))
                                {
                                    MoveTile(list);
                                    scoreCheck();

                                    if (countRemove == 0)
                                    {

                                        RandomShapes();
                                    }
                                    if (countRemove > 0)
                                    {
                                        countRemove = 0;
                                    }

                                    Clicked1 = default;
                                    Clicked2 = default;

                                }
                                else
                                {
                                    MessageBox.Show("Unfortunately the shape can't go there, make a new move!!!");
                                    Clicked1.Pb.BackColor = Color.White;
                                    Clicked1 = default;
                                    Clicked2 = default;
                                    
                                }
                                
                                
                            }
                            if (gameOverControl())
                            {
                                cnn = new SqlConnection(connetionString);
                                cnn.Open();
                                SqlCommand sqlCommand = new SqlCommand("Update oopUsers set Score = @score  where UserName = @uname", cnn);
                                sqlCommand.CommandType = CommandType.Text;
                                sqlCommand.Parameters.AddWithValue("@uname", profileScreen.username);
                                sqlCommand.Parameters.AddWithValue("@score", bestScore);
                                sqlCommand.ExecuteNonQuery();
                                cnn.Close();

                                repeatGame();
                                CreateGameBoard();
                                RandomShapes();
                            }
                        }
                        else
                        {
                            t.Pb.BackColor = Color.White;
                            Clicked1 = default;
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

            bool[,] visitedTiles = new bool[Row, Column];
            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (tiles2D[i, j] == '0')
                    {
                        visitedTiles[i, j] = true;
                    }
                    else
                    { 
                        visitedTiles[i, j] = false; 
                    }

    
                    if (tiles2D[i, j] == 's')
                    {
                        source.row = i;
                        source.col = j;
                    }
                }
            }

            
            List<QItem> list = new List<QItem>();
            list.Add(source);
            visitedTiles[source.row, source.col] = true;
            while (list.Any())
            {
                QItem p = list[0];
                list.RemoveAt(0);

                if (tiles2D[p.row, p.col] == 'd')
                {
                    while (p != null)
                    {
                        arr.Add(p);
                        p = p.prev;
                    }
                    return true;
                }
                
                if (p.row - 1 >= 0 && visitedTiles[p.row - 1, p.col] == false)
                {
                    QItem q = new QItem(p.row - 1, p.col, p.dist + 1);
                    q.prev = p;
                    list.Add(q);
                    visitedTiles[p.row - 1, p.col] = true;
                }

                if (p.row + 1 < Row && visitedTiles[p.row + 1, p.col] == false)
                {
                    QItem q = new QItem(p.row + 1, p.col, p.dist + 1);
                    q.prev = p;
                    list.Add(q);
                    visitedTiles[p.row + 1, p.col] = true;
                }

                if (p.col - 1 >= 0 && visitedTiles[p.row, p.col - 1] == false)
                {
                    QItem q = new QItem(p.row, p.col - 1, p.dist + 1);
                    q.prev = p;
                    list.Add(q);
                    visitedTiles[p.row, p.col - 1] = true;
                }
                
                if (p.col + 1 < Column && visitedTiles[p.row, p.col + 1] == false)
                {
                    QItem q = new QItem(p.row, p.col + 1, p.dist + 1);
                    q.prev = p;
                    list.Add(q);
                    visitedTiles[p.row, p.col + 1] = true;
                }
            }
            return false;
        }
        bool gameOverControl()
        {
            int control = 0;

            for (int i = 0; i < Row; i++)
            {
                for (int j = 0; j < Column; j++)
                {
                    if (tilesAdd[i, j] == 0)
                    {
                        control++;
                    }
                }
            }
            if (control >= 3)
            {
                return false;
            }
            MessageBox.Show("You can't make move, GAME IS OVER!!!!!");
            MessageBox.Show("Score = " + score);
            playGround.Hide();


            return true;
        }
        void repeatGame()
        {
            score = 0;

            for (int a = 0; a < Row; a++)
            {
                for (int b = 0; b < Column; b++)
                {
                    tilesAdd[a, b] = 0;
                    tiles.Clear();
                }
            }
           
        }

        private bool isEmptyTile(Tile tile)
        {

            return tile.Pb.Image == null;
        }

        private void MoveTile(List<QItem> list)
        {
            int sleepTime = 1000;
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
                soundMove.Play();
                
            }
            int sayi = tilesAdd[Clicked1.x, Clicked1.y];
            tilesAdd[Clicked2.x, Clicked2.y] = sayi;
            tilesAdd[Clicked1.x, Clicked1.y] = 0;

            //Task.Delay(sleepTime).Wait();

            tiles[(list[list.Count-1].row*Row)+ (list[list.Count-1].col)].Pb.BackColor = Color.White;
            list.Clear();
           
            //RandomShapes();           
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
            int sleepTime = 1000;

            for (int i = 0; i < 5; i++)
            {
                Task.Delay(50).Wait();
                tilesAdd[arr[i, 0], arr[i, 1]] = 0;
                tiles[(arr[i, 0] * Row) + arr[i, 1]].Pb.Image = default;
                
            }
            countRemove++;
            Task.Delay(sleepTime).Wait();     
            soundRemove.Play();
            
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
