using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace SynchronizedContainers
{
    class Program
    {
        static MySynchronizedQueue<int> numbers = new MySynchronizedQueue<int>();
        static Random rand = new Random(987);
        const int NumThreads = 3;
        static int[] sums = new int[NumThreads];
        static void ProduceNumbers()
        {
            for (int i = 0; i < 10; i++)
            {
                int numToEnqueue = rand.Next(10);
                Console.WriteLine("Producing thread adding " + numToEnqueue + " to the queue.");
                lock(numbers)
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
                int numToSum = -1;
                lock(numbers)
                {
                    if (numbers.Count != 0)
                    {
                        numToSum = numbers.Dequeue();
                    }
                }
                if (numToSum != -1)
                {
                    mySum += numToSum;
                    Console.WriteLine("Consuming thread #" + threadNumber + " adding "  
                            + numToSum + " to its total sum making " 
                            + numToSum + " for the thread total.");
                }   
            }
            sums[(int)threadNumber] = mySum;
        }
        static void Main(string[] args)
        {
            var producingThread = new Thread(ProduceNumbers);
            producingThread.Start();
            Thread[] threads = new Thread[NumThreads];
            for (int i = 0; i < NumThreads; i++)
            {
                threads[i]= new Thread(SumNumbers);
                threads[i].Start(i);
            }
            for (int i = 0; i < NumThreads; i++)
                threads[i].Join();
            int totalSum = 0;
            for (int i = 0; i < NumThreads; i++)
            {
                totalSum += sums[i];
            }
            Console.WriteLine("Done adding. Total is " + totalSum);
        }
    }
    
    class MySynchronizedQueue<T> : Queue<T>
    {
        object baton = new object();
        Queue<T> theQ = new Queue<T>();
        
        public void Enqueue(T item)
        {
            lock (baton)
                theQ.Enqueue(item);
        }
        public T Dequeue()
        {
            lock (baton)
                return theQ.Dequeue();
        }
        public int Count
        {
            get { lock (baton) return theQ.Count;}
        }
        public object SyncRoot
        {
            get { return baton; }
        }
    }
}

