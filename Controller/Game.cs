using SokoBan.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Game
    {
        private Playfield playfield;

        public GameView gameView;
        public PlayfieldView playfieldView;

        public Game()
        {
            startGame();
        }

        public void startGame()
        {
            gameView = new GameView();
            playfieldView = new PlayfieldView(this);

            gameView.ShowStart();
            askInput();
            playfieldView.showPlayField();
        }

        public void askInput()
        {
            bool canRead = false;

            while(!canRead)
            {
                Console.WriteLine(">     Kies een doolhof (1 - 4), s = stop");
                char input = Console.ReadKey().KeyChar;

                switch (input)
                {
                    case 's':
                        Console.Clear();
                        stopGame();
                        canRead = true;
                        break;
                    case '1':
                        Console.Clear();
                        loadGame(1);
                        canRead = true;
                        break;
                    case '2':
                        Console.Clear();
                        loadGame(2);
                        canRead = true;
                        break;
                    case '3':
                        Console.Clear();
                        loadGame(3);
                        canRead = true;
                        break;
                    case '4':
                        Console.Clear();
                        loadGame(4);
                        canRead = true;
                        break;
                    default:
                        Console.WriteLine("\n?");
                        break;
                }
            }
        }

        public void showPlayField()
        {
            playfield.showPlayField();
        }

        public void loadGame(int level)
        {
            playfield = new Playfield(level);
        }

        public void stopGame()
        {
            System.Environment.Exit(1);
        }
    }
}