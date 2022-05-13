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
        public string Shape { get; private set; }
        public Color Clr { get; private set; }

        public PictureBox Pb { get; }

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
                Location = new Point(50 * x, 50 * y),
                SizeMode = PictureBoxSizeMode.StretchImage

            };

        }

    }
}
