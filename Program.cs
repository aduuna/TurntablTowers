using System;
using System.Collections.Generic;

namespace TurntablTowers
{
    class Program
    {
        static void Main(string[] args)
        {
            SortedList<string, int> specification = new SortedList<string, int>() { { "Basic", 6 }, { "Grand", 2 }, { "Silver", 4} };
            TurntablTower towers = new TurntablTower(specification, "Concierge");

            towers.TakeTheRegister();


        }
    }
}
