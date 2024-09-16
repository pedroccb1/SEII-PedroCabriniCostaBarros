using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace LockingOn
{
    class BathroomStall
    {
        object baton = new object();
        public void BeUsed()
        {
            lock(baton)
                Console.WriteLine("Doing our thing...");
        }
        public void FlushToilet()
        {
            lock(baton)
                Console.WriteLine("Flushing the toilet...");
        }
    }
    class PublicRestroom
    {
        BathroomStall stall1 = new BathroomStall();
        BathroomStall stall2 = new BathroomStall();
        public void UseStall1()
        {
            stall1.BeUsed();
            stall1.FlushToilet();
        }
        public void UseStall2()
        {
            stall2.BeUsed();
            stall2.FlushToilet();
        }
        public void CleanTheSink()
        {
            lock (stall1)
                Console.WriteLine("Clean the sink...");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            var restroom = new PublicRestroom();
            new Thread(restroom.UseStall1).Start();
            new Thread(restroom.UseStall2).Start();
            new Thread(restroom.UseStall1).Start();
            new Thread(restroom.UseStall2).Start();
        }
    }
}