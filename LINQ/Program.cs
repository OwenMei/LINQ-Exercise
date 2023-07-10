using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Halo", "COD", "WOW", "DOTA", "Valorant", "League of Legends", "Minecraft", "Overwatch"};
            videoGames.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));

        }
    }
}
