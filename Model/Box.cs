using SokoBan.Model;
using System;

namespace SokoBan
{
    public class Box : MoveableObject
    {
        public Box(Tile currentTile) : base(currentTile)
        {
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