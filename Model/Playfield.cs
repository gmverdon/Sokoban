using SokoBan.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SokoBan
{
    public class Playfield
    {
        public GridList map;

        public Playfield(int level)
        {
            map = new GridList();

            loadPlayfield(level);
        }

        public void loadPlayfield(int level)
        {
            // convert level to objects of right classes
            string[] lines = System.IO.File.ReadAllLines((@"\\Mac\Home\Downloads\Doolhof\doolhof" + level + ".txt"));

            bool isFirstCharAndLine = true;
            bool isFirstLine = true;
            bool isFirstChar = true;

            foreach (string line in lines)
            {
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
                            newTile = new Floor();
                            break;
                        case '@':
                            // truck
                            newTile = new Floor();
                            newTile.MoveableObject = new Forklifttruck(newTile);
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
                            map.Current.UpperTile.RightTile.LowerTile = newTile;
                            map.Current = map.Current.RightTile;
                        }
                    }
                }

                isFirstLine = false;
            }
        }
    }
}