using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    class PlayGame
    {
        public List<Tile> tiles=new List<Tile>();
        private int row;
        private int column;
        private int count;

        public PlayGame(int r, int c)
        {
            count = 0;
            row = r;
            column = c;
        }

        public void createGameBoard()
        {
            for (int i = 1; i <= row; i++)
            {
                for (int j = 1; j <= column; j++)
                {
                    
                    Tile t = new Tile(i,j,count);
                    tiles.Add(t);
                    count++;
                }
            }
        }
    }
}
