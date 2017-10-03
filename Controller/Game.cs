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
        public VictoryView _victoryView;

        private bool isPlaying = true;
        private int _labirinthNumber;

        public Game()
        {
            while (true)
            {
                isPlaying = true;
                StartGame();
            }
        }

        public void StartGame()
        {
            _gameView = new GameView();
            _playfieldView = new PlayfieldView(this);
            

            _gameView.ShowStart();
            AskLevel();
            _playfieldView.showPlayField();
            AskDirections();
            ShowVictory();
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
                        EndApplicationGame();
                        canRead = true;
                        break;
                    case '1':
                        _labirinthNumber = 1;
                        Console.Clear();
                        LoadGame(_labirinthNumber);
                        canRead = true;
                        break;
                    case '2':
                        _labirinthNumber = 2;
                        Console.Clear();
                        LoadGame(_labirinthNumber);
                        canRead = true;
                        break;
                    case '3':
                        _labirinthNumber = 3;
                        Console.Clear();
                        LoadGame(_labirinthNumber);
                        canRead = true;
                        break;
                    case '4':
                        _labirinthNumber = 4;
                        Console.Clear();
                        LoadGame(_labirinthNumber);
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
                    Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
                    Console.WriteLine(">     Gebruik pijljestoetsen (s = stop, r = reset)");

                    var input = Console.ReadKey(false).Key;
                    switch (input)
                    {
                        case ConsoleKey.R:
                            Console.Clear();
                            LoadGame(_labirinthNumber);
                            break;
                        case ConsoleKey.S:
                            Console.Clear();
                            StopGame();
                            canRead = true;
                            break;
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

                    if(checkIfWon())
                    {
                        break;
                    }

                    canRead = false;
                }
            }
        }

        private bool checkIfWon()
        {
            if(_playfield.checkIfWon())
            {
                isPlaying = false;
            }

            return _playfield.checkIfWon();
        }

        public void ShowPlayField()
        {
            _playfield.ClearPlayField();
            _playfield.showPlayField();
        }

        public void ShowVictory()
        {
            _victoryView = new VictoryView();
            _victoryView.showVictory();
        }

        public void LoadGame(int level)
        {
            _playfield = new Playfield(level);
        }

        public void EndApplicationGame()
        {
            System.Environment.Exit(1);
        }

        public void StopGame()
        {
            while (true)
            {
                isPlaying = true;
                StartGame();
            }
        }
    }
}