using System;
using System.IO;
using System.Threading;

namespace Threads
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrera race = new Carrera();

            Thread liebre = new Thread(new ThreadStart(race.Liebre));
            Thread tortuga = new Thread(new ThreadStart(race.Tortuga));

            liebre.Start();
            tortuga.Start();

            Console.ReadKey(true);
        }
    }
}
