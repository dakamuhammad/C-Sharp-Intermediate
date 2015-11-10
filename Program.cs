using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace MoshSection2Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new StopWatch();

            // stopwatch.Start(); //Just for testing the code
            stopwatch.Start();
            Thread.Sleep(3000);
            stopwatch.Stop();

            var seconds = stopwatch.GetDuration().TotalSeconds;
            Console.WriteLine(seconds);

            stopwatch.Start();
            Thread.Sleep(80);
            stopwatch.Stop();

            seconds = stopwatch.GetDuration().TotalSeconds;
            Console.WriteLine(seconds);
        }
    }
}
