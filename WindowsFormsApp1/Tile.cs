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
        public string shape { get; private set; }
        public Color color { get; private set; }

        public PictureBox pb { get; }

        public Tile(int x, int y, int count)
        {
            pb = new PictureBox();
            pb.Name = count.ToString();
            pb.BackColor = Color.White;
            pb.Cursor = Cursors.Hand;
            pb.Anchor = AnchorStyles.None;
            pb.BorderStyle = BorderStyle.FixedSingle;
            pb.Size = new Size(45, 45);
            pb.Location = new Point(50 * x, 50 * y);
            
        }

    }
}
