﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace MonitorMethodCalls
{
    class Program
    {
        static object baton = new object();

        static void Main(string[] args)
        {
            //lock(baton)
            bool lockTaken = false;
            Monitor.Enter(baton, ref lockTaken);
            try
            {
                Console.WriteLine("Got the baton");
            }
            finally
            {
                Monitor.Exit(baton);
            }
        }
       
    }
}

