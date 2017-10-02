using SokoBan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Box : MoveableObject
    {
        public Box(Tile currentTile) : base(currentTile)
        {
        }

        internal void draw()
        {
            throw new NotImplementedException();
        }
        public override void Show()
        {
            if (this.Tile is Destination)
            {
                Console.Write("0");
            } else
            {
                Console.Write("o");
            }
        }
    }
}