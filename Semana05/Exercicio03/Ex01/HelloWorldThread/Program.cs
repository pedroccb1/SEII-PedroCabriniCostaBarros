using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace HelloWorldThread
{
class Program
{
    static void Main(string[] args)
    {
        var t1 = new Thread(DifferentMethod);
        t1.Start();
    }
    static void DifferentMethod()
    {
        Console.WriteLine("Hello World!");
    }
}
}