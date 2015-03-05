using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileSystemPerf
{
    class Program
    {
        static void Main(string[] args)
        {
            var start = DateTime.Now;
            double total = 0;
            int maxIteration = 10;
            for (int i = 0; i < maxIteration; i++)
            {
                var iterationStart = DateTime.Now;
                File.WriteAllText("FileSystemPerf.txt", "Hello");

                double ms = (DateTime.Now - iterationStart).TotalMilliseconds;
                total += ms;
                Console.WriteLine("The write took {0}ms.", ms);
            }

            Console.WriteLine();
            Console.WriteLine("Average: {0}ms", ((DateTime.Now - start).TotalMilliseconds / maxIteration));
        }
    }
}
