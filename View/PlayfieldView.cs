using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SokoBan.View
{
    public class PlayfieldView
    {
        private Game Game { get; }

        public PlayfieldView(Game game)
        {
            Game = game;
        }

        public void showPlayField()
        {
            Console.WriteLine("┌──────────┐");
            Console.WriteLine("| Sokoban  |");
            Console.WriteLine("└──────────┘");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
            // draw playfield on canvas
            Game.ShowPlayField();
            Console.WriteLine("");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");

            Game.AskDirections();
        }
    }
}
