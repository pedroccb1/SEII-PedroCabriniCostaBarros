using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DivideAndConquer
{
    class Program
    {
        static byte[] values = new byte[500000000];
        static long[] portionResults;
        static int portionSize;
        static void GenerateInts()
        {
            var rand = new Random(987);
            for (int i = 0; i < values.Length; i++)
                values[i] = (byte)rand.Next(10);
        }
        static void SumYourPortion(object portionNumber)
        {
            long sum = 0;
            int portionNumberAsInt = (int)portionNumber;
            for (int i = portionNumberAsInt * portionSize; i < portionNumberAsInt * portionSize + portionSize; i++)
                sum += values[i];
            portionResults [portionNumberAsInt] = sum;
        }
        static void Main(string[] args)
        {
            portionResults = new long[Environment.ProcessorCount];
            portionSize = values.Length / Environment.ProcessorCount;
            GenerateInts();
            Console.WriteLine("Summing...");
            Stopwatch watch = new Stopwatch();
            watch.Start();
            long total = 0;
            for(int i = 0; i < values.Length; i++)
                total += values[i];
            watch.Stop();
            Console.WriteLine("Total values is: " + total);
            Console.WriteLine("Time to sum: " + watch.Elapsed);
        }
       
    }
}
