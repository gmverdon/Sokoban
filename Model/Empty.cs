using System;
using SokoBan.Model;

namespace SokoBan
{
    public class Empty : Tile
    {
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