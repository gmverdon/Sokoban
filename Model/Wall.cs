using SokoBan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Wall : Tile
    {
        public Wall()
        {
        }

        internal void draw()
        {
            throw new NotImplementedException();
        }

        public new void MoveTo(Forklifttruck forklifttruck)
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