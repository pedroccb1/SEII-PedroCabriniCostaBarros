using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace ProducerConsumerThread
{
    class Program
    {
        static Queue<int> numbers = new Queue<int>();
        static Random rand = new Random();
        const int NumThreads = 3;
        static int[] sums = new int[NumThreads];
        static void ProduceNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                numbers.Enqueue(rand.Next(10));
                Thread.Sleep(rand.Next(1000));
            }
        }
        static void SumNumbers(object threadNumber)
        {
            DateTime startTime = DateTime.Now;
            int mySum = 0;
            while((DateTime.Now - startTime).Seconds < 11)
            {
                if (numbers.Count != 0)
                {
                    mySum += numbers.Dequeue();
                }
            }
            sums[(int)threadNumber] = mySum;
        }
        static void Main(string[] args)
        {
            
        }
    }
}
