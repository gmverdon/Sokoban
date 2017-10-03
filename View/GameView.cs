using System;

namespace SokoBan.View
{
    public class GameView
    {
        public void ShowStart()
        {
            Console.Clear();
            Console.WriteLine("______________________________________________________________");
            Console.WriteLine("|     Welkom bij Sokoban.                                    |");
            Console.WriteLine("|                                  |                         |");
            Console.WriteLine("|     Betekenis van de symbolen.   |   doel van het spel     |");
            Console.WriteLine("|                                  |                         |");
            Console.WriteLine("|     spatie : outerspace          |   duw met de tuck       |");
            Console.WriteLine("|          # : muur                |   de krat(ten)          |");
            Console.WriteLine("|          . : vloer               |   naar de bestemming    |");
            Console.WriteLine("|          o : krat                |                         |");
            Console.WriteLine("|          0 : krat op bestemming  |                         |");
            Console.WriteLine("|          x : bestemming          |                         |");
            Console.WriteLine("|          @ : truck               |                         |");
            Console.WriteLine("|____________________________________________________________|");
            Console.WriteLine();

        }
    }
}
