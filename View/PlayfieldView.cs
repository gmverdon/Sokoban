﻿using System;

namespace SokoBan.View
{
    public class PlayfieldView
    {

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
        }
    }
}
