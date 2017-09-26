using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Floor : Tile
    {
        public Floor()
        {
        }

        internal void draw()
        {
            throw new NotImplementedException();
        }

        public override void Show()
        {
            Console.Write(".");
        }
    }
}