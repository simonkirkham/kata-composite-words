using System;
using System.Diagnostics;

namespace CompositeWordsKataFast
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            //All logic must be between the start and stop
            Console.WriteLine("Print output here");

            stopwatch.Stop();
            Console.WriteLine("Time Taken: " + stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
