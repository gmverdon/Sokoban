using SokoBan.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Game
    {
        private Playfield _playfield;

        public GameView _gameView;
        public PlayfieldView _playfieldView;

        private bool isPlaying = true;

        public Game()
        {
            StartGame();
            isPlaying = true;
        }

        public void StartGame()
        {
            _gameView = new GameView();
            _playfieldView = new PlayfieldView(this);

            _gameView.ShowStart();
            AskLevel();
            _playfieldView.showPlayField();
        }

        public void AskLevel()
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
                        StopGame();
                        canRead = true;
                        break;
                    case '1':
                        Console.Clear();
                        LoadGame(1);
                        canRead = true;
                        break;
                    case '2':
                        Console.Clear();
                        LoadGame(2);
                        canRead = true;
                        break;
                    case '3':
                        Console.Clear();
                        LoadGame(3);
                        canRead = true;
                        break;
                    case '4':
                        Console.Clear();
                        LoadGame(4);
                        canRead = true;
                        break;
                    default:
                        Console.WriteLine("\n?");
                        break;
                }
            }
        }

        public void AskDirections()
        {
            while (isPlaying)
            {

                bool canRead = false;
                while (!canRead)
                {
                    Console.WriteLine(">     Gebruik pijljestoetsen (s = stop, r = reset)");

                    var input = Console.ReadKey(false).Key;
                    switch (input)
                    {
                        case ConsoleKey.UpArrow:
                            // forkliftruck move up
                            _playfield.Forklifttruck.Move(0);
                            canRead = true;
                            break;
                        case ConsoleKey.RightArrow:
                            // forkliftruck move right
                            _playfield.Forklifttruck.Move(1);
                            canRead = true;
                            break;
                        case ConsoleKey.DownArrow:
                            // forkliftruck move down
                            _playfield.Forklifttruck.Move(2);
                            canRead = true;
                            break;
                        case ConsoleKey.LeftArrow:
                            // forkliftruck move left
                            _playfield.Forklifttruck.Move(3);
                            canRead = true;
                            break;
                    }
                    ShowPlayField();
                    checkIfWon();
                    canRead = false;
                }

            }
        }

        private void checkIfWon()
        {
            throw new NotImplementedException();
        }

        public void ShowPlayField()
        {
            _playfield.ClearPlayField();
            _playfield.showPlayField();
        }

        public void LoadGame(int level)
        {
            _playfield = new Playfield(level);
        }

        public void StopGame()
        {
            System.Environment.Exit(1);
        }
    }
}