using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace LockingOnVsMethod
{
    class BathroomStall
    {
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void BeUsed()
        {
            lock (typeof(BathroomStall))
            {
                Console.WriteLine("Doing our thing...");
                Thread.Sleep(5000);
            }
        }
        [MethodImpl(MethodImplOptions.Synchronized)]
        public static void FlushToilet()
        {
            Console.WriteLine("Flushing the toilet...");
            Thread.Sleep(5000);
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            new Thread(BathroomStall.BeUsed).Start();
            new Thread(BathroomStall.FlushToilet).Start();
        }
    }
}