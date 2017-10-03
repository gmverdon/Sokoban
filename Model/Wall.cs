using SokoBan.Model;
using System;

namespace SokoBan
{
    public class Wall : Tile
    {
        public void MoveTo(Forklifttruck forklifttruck)
        {
            Console.WriteLine("Wall");
        }

        public override void Show()
        {
            Console.Write("#");
        }

        public override bool MoveTo(MoveableObject moveableObject)
        {
            // TODO: remove this writeline
            Console.WriteLine("Cannot move into wall");
            return false;
        }
    }
}