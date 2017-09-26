using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokoBan
{
    public abstract class Tile
    {
        public Tile UpperTile { get; set; }
        public Tile RightTile { get; set; }
        public Tile LowerTile { get; set; }
        public Tile LeftTile { get; set; }


        public Tile()
        {
        }

        public abstract void MoveTo();

        public abstract void Show();
    }
}
