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
            Console.WriteLine("Hello World!");
            stopwatch.Stop();
            Console.WriteLine("Time Taken: " + stopwatch.Elapsed);
            Console.ReadLine();
        }
    }
}
