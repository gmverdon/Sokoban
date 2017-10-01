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
            Console.Write("o");
        }
    }
}