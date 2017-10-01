using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokoBan.View
{
    public class PlayfieldView
    {
        private Game game { get; }

        public PlayfieldView(Game theGame)
        {
            this.game = theGame;
        }

        public void showPlayField()
        {
            Console.WriteLine("┌──────────┐");
            Console.WriteLine("| Sokoban  |");
            Console.WriteLine("└──────────┘");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
            // draw playfield on canvas
            game.showPlayField();
            Console.WriteLine("");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("> gebruik pijljestoetsen (s = stop, r = reset)");
        }
    }
}
