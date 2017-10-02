using SokoBan.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Playfield
    {
        public GridList map;
        public Forklifttruck Forklifttruck { get; set; }

        public Playfield(int level)
        {
            map = new GridList();

            loadPlayfield(level);
        }

        public void loadPlayfield(int level)
        {
            // convert level to objects of right classes
            string[] lines;
            try
            {
                lines = System.IO.File.ReadAllLines((@"C:\Users\renat\OneDrive\Documents\Visual Studio 2015\Projects\Modelleren 3\Sokoban\Resources\doolhof" + level + ".txt"));
            }
            catch (DirectoryNotFoundException dirNotFound)
            {
                Console.WriteLine("File not found, cannot execute Sokoban. Sorry!");
                Console.WriteLine("Press any key to stop Sokoban.");
                Console.ReadLine();
                System.Environment.Exit(1);
                return;
            }

            bool isFirstCharAndLine = true;
            bool isFirstLine = true;
            bool isFirstChar = true;

            foreach (string line in lines)
            {
                isFirstChar = true;
                foreach (char c in line)
                {
                    Tile newTile;
                    switch (c)
                    {
                        case '#':
                            // muur
                            newTile = new Wall();
                            break;
                        case '.':
                            // vloer
                            newTile = new Floor();
                            break;
                        case 'o':
                            // krat
                            newTile = new Floor();
                            newTile.MoveableObject = new Box(newTile);
                            break;
                        case 'x':
                            // bestemming
                            newTile = new Destination();
                            break;
                        case '@':
                            // truck
                            newTile = new Floor();
                            Forklifttruck = new Forklifttruck(newTile);
                            newTile.MoveableObject = Forklifttruck;
                            break;
                        default:
                            // Empty aanmaken
                            newTile = new Empty();
                            break;
                    }
                    if (isFirstLine)
                    {
                        if (isFirstCharAndLine)
                        {
                            map.First = newTile;
                            map.Current = map.First;
                            isFirstCharAndLine = false;
                        }
                        else
                        {
                            map.Current.RightTile = newTile;
                            newTile.LeftTile = map.Current;
                            map.Current = map.Current.RightTile;
                        }
                    }
                    else
                    {
                        if (isFirstChar)
                        {
                            Tile currentTile = map.First;
                            while (currentTile.LowerTile != null)
                            {
                                currentTile = currentTile.LowerTile;
                            }

                            currentTile.LowerTile = newTile;
                            newTile.UpperTile = currentTile;
                            map.Current = currentTile.LowerTile;
                            isFirstChar = false;
                        }
                        else
                        {
                            map.Current.RightTile = newTile;
                            newTile.LeftTile = map.Current;
                            newTile.UpperTile = map.Current.UpperTile.RightTile;
                            newTile.UpperTile.LowerTile = newTile;
                            map.Current = map.Current.RightTile;
                        }
                    }
                }

                isFirstLine = false;
            }
            Console.WriteLine("\n");
            Console.WriteLine("");
        }

        public bool checkIfWon()
        {
            bool isNotLastLine = true;
            int lineCounter = 1;
            Tile currentTile = map.First;

            while (isNotLastLine)
            {
                while (currentTile != null)
                {
                    bool currentTileIsDestination = currentTile is Destination;
                    bool moveableObjectisBox = currentTile.MoveableObject is Box;

                    if ((currentTileIsDestination && !moveableObjectisBox) || (!currentTileIsDestination && moveableObjectisBox))
                    {
                        return false;
                    }
                    currentTile = currentTile.RightTile;
                }

                lineCounter++;

                currentTile = map.First;
                for (int i = 1; i < lineCounter; i++)
                {
                    currentTile = currentTile.LowerTile;
                }

                if (currentTile.LowerTile == null)
                {
                    isNotLastLine = false;
                }
            }

            while (currentTile != null)
            {
                bool currentTileIsDestination = currentTile is Destination;
                bool moveableObjectisBox = currentTile.MoveableObject is Box;

                if ((currentTileIsDestination && !moveableObjectisBox) || (!currentTileIsDestination && moveableObjectisBox))
                {
                    return false;
                }
                currentTile = currentTile.RightTile;
            }
            return true;
        }

        public void showPlayField()
        {
            Console.WriteLine("┌──────────┐");
            Console.WriteLine("| Sokoban  |");
            Console.WriteLine("└──────────┘");
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");

            bool isNotLastLine = true;
            int lineCounter = 1;
            Tile currentTile = map.First;

            while (isNotLastLine)
            {
                while (currentTile != null)
                {
                    currentTile.Show();
                    currentTile = currentTile.RightTile;
                }

                lineCounter++;

                currentTile = map.First;
                for (int i = 1; i < lineCounter; i++)
                {
                    currentTile = currentTile.LowerTile;
                }

                if (currentTile.LowerTile == null)
                {
                    isNotLastLine = false;
                }
                Console.WriteLine("");
            }

            while (currentTile != null)
            {
                currentTile.Show();
                currentTile = currentTile.RightTile;
            }
            Console.WriteLine("");

        }

        public void ClearPlayField()
        {
            Console.Clear();
        }
    }
}