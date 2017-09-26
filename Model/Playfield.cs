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

            foreach (string line in lines)
            {
                Console.WriteLine(lines[0][0]);
                foreach (char c in line)
                {
                    switch (c)
                    {
                        case '#':
                            // muur
                            new Wall();
                            break;
                        case '.':
                            // vloer
                            new Floor();
                            break;
                        case 'o':
                            // krat
                            new Box();
                            break;
                        case 'x':
                            // bestemming
                            new Floor();
                            break;
                        case '@':
                            // truck
                            new Forklifttruck();
                            break;
                        default:
                            // Empty aanmaken
                            break;
                    }
                }
            }
        }
    }
}