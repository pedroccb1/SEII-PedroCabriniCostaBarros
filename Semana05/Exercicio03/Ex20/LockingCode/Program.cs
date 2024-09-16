using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace LockingCode
{
    class PublicRestroom
    {
        object stall1baton = new object();
        object stall2baton = new object();
        public void UseStall1()
        {
            lock(stall1baton)
            {
                Console.WriteLine("In stall 1");
                Thread.Sleep(2000);
            }
        }
        public void UseStall2()
        {
            lock(stall2baton)
            {
                Console.WriteLine("In stall 2"); 
                Thread.Sleep(2000);
            }
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

