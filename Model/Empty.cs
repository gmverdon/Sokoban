using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Empty : Tile
    {

        public Empty()
        {

        }

        public override void Show()
        {
            Console.Write(" ");
        }
    }
}