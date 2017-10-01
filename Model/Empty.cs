using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SokoBan.Model;

namespace SokoBan
{
    public class Empty : Tile
    {

        public Empty()
        {

        }

        public override bool MoveTo(MoveableObject moveableObject)
        {
            return false;
        }

        public override void Show()
        {
            Console.Write(" ");
        }
    }
}