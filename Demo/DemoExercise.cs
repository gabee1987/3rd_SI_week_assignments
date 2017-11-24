using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Demo
{
    class DemoExercise
    {
        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(DisplayTime);
            Thread first = new Thread(starter);
            Thread second = new Thread(starter);

            first.Start();
            second.Start();

            first.Join();
            second.Join();

            Console.Read();
        }

        static void DisplayTime()
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Current time: {0} \n\n", DateTime.Now);
                Thread.Sleep(2000);
            }
        }
    }
}
