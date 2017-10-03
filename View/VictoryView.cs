using System;

namespace SokoBan.View
{
    public class VictoryView
    {
        public void showVictory()
        {
            Console.WriteLine("─────────────────────────────────────────────────────────────────────────");
            Console.WriteLine("");
            Console.WriteLine("=== HOERA OPGELOST ===");
            Console.WriteLine("> press key to continue");
            Console.ReadKey();
        }
    }
}
