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
        public string Shape { get;  set; }
        public Color Clr { get;  set; }

        public PictureBox Pb { get; set; }

        public int x { get;  set; }

        public int y { get; set; }
        public int color { get; set; }


        public bool visited { get;  set; }
        public Tile(int x, int y, int count)
        {
            Pb = new PictureBox
            {
                Name = count.ToString(),
                BackColor = Color.White,
                Cursor = Cursors.Hand,
                Anchor = AnchorStyles.None,
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(45, 45),
                Location = new  Point(35 * (y + 1), 35 * (x + 1)),
                SizeMode = PictureBoxSizeMode.StretchImage            
            };

            this.x = x;
            this.y = y;
            this.visited = false;
            this.color = -1;


        }


    }

    
}
