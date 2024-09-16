using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MultipleThreads
{
class Program
{
    static void Main(string[] args)
    {
        for (int i = 0; i < 6; i++)
        {
            var t1 = new Thread(DifferentMethod);
            t1.Start(i);
        }
        // while(true)
        //     Console.WriteLine("Hello from Main (1)");
    }
    static void DifferentMethod(object threadID)
    {
        while(true)
            Console.WriteLine("Hello from DifferentMethod (" + threadID + ")");
    }
}
}
