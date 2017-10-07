using System;

namespace SokoBan.View
{
    public class PlayfieldView
    {
        private Game game;

        public PlayfieldView(Game game)
        {
            this.game = game;
        }

        public void showPlayField()
        {
            Console.WriteLine("┌──────────┐");
            Console.WriteLine("| Sokoban  |");
            Console.WriteLine("└──────────┘");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
            // draw playfield on canvas
            game.ShowPlayField();
        }
    }
}
