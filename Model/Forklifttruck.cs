using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Forklifttruck : Tile
    {

        public Forklifttruck()
        {

        }

        internal void draw()
        {
            throw new NotImplementedException();
        }
        public override void Show()
        {
            Console.Write("@");
        }
    }
}