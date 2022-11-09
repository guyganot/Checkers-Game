using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B22_Ex05_ItayGrinberg_209413277_GuyGanot_207044363
{
    internal class PictureBoxTile : PictureBox
    {
        public static int s_BlockSize = 60;
        //private Image m_PuckImage;
        private Tile m_Tile;

        public PictureBoxTile(Tile i_Tile)
        {
            m_Tile = i_Tile;
            Location = new Point((m_Tile.ColumnNumber)*s_BlockSize,
                (m_Tile.RowNumber) * s_BlockSize);
            Size = new Size(s_BlockSize, s_BlockSize);
            SizeMode = PictureBoxSizeMode.StretchImage;
            SetImage();
        }

        public void SetImage()
        {
            switch (m_Tile.Puck)
            {
                case 'X':
                    Image = new Bitmap(Properties.Resources.tile_XSimplePuck);
                    break;
                case 'O':
                    Image = new Bitmap(Properties.Resources.tile_OSimplePuck);
                    break;
                case 'Z':
                    Image = new Bitmap(Properties.Resources.tile_XQueenPuck);
                    break;
                case 'Q':
                    Image = new Bitmap(Properties.Resources.tile_OQueenPuck);
                    break;
                default:
                    //Image = new Bitmap(Size.Width, Size.Height); // or null?
                    Image = null;
                    break;
            }

        }

        public Tile Tile
        {
            get
            {
                return m_Tile;
            }
        }
    }
}
