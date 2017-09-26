using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Box : Tile
    {

        public Box()
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

        public override void MoveTo(Tile tile)
        {

            // TODO: remove this writeline
            Console.WriteLine("Cannot move into wall");
        }
    }
}