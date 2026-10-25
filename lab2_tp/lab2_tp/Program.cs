using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_tp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var home = new MobileHome(5, "Caravan", 2, 2, true);
            home.Move(7, 8);
            Console.WriteLine($"{home.GetX}, {home.GetY}");   // 7, 8

            var unfinishedHome = new MobileHome(6, "New home", 0, 0, false);
            unfinishedHome.Move(9, 9);
            Console.WriteLine($"{unfinishedHome.GetX}, {unfinishedHome.GetY}");   // 0, 0

        }
    }
}
