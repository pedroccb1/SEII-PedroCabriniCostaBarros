using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace List
{
    public class Node
    {
        public int Data { get; set; }
        public Node? Next { get; set; }
        
        public void DisplayNode(){
            Console.WriteLine(Data);
        }
    }
}