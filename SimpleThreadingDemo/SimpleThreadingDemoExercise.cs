﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleThreadingDemo
{
    class SimpleThreadingDemoExercise
    {
        static void Main(string[] args)
        {
            ThreadStart starter = new ThreadStart(Counting);
            Thread first = new Thread(starter);
            Thread second = new Thread(starter);

            first.Start();
            second.Start();

            first.Join();
            second.Join();

            Console.Read();
        }

        static void Counting()
        {
            for (int i = 0; i < 10; ++i)
            {
                Console.WriteLine("Count: {0} - Thread Id: {1}", i, Thread.CurrentThread.ManagedThreadId);
                Thread.Sleep(1000);
            }
        }

    }
}
