using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


namespace WindowsFormsApp1
{
    class Tile
    {
        Settings st = new Settings();
        public string Shape { get; set; }
        public Color Clr { get; set; }

        public Button Pb { get; set; }

        public int x { get; set; }


        public int y { get; set; }
        public int color;



        public bool visited { get; set; }
        public Tile(int x, int y, int count)
        {
            {
                Pb = new Button
                {
                    Name = count.ToString(),
                    BackColor = Color.White,
                    Cursor = Cursors.Hand,
                    Anchor = AnchorStyles.None,
                    Size = new Size(45, 45),
                    Location = new Point(48 * (y + 1), 48 * (x + 1)),
                };




                this.x = x;
                this.y = y;
                this.visited = false;
                this.color = -1;


            }
        }
    }
}
