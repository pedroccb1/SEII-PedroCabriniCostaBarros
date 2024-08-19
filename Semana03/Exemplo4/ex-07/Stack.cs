using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stacks
{
    public class Stack
    {
        public int MaxSize { get; set; } // Array stacks you need a maxszie to init array
        public string[] StackArray {get; set; }
        public int Top {get; set; }

        public Stack(int size){
            this.MaxSize = size;
            // Create array and new up size
            this.StackArray = new string[MaxSize];
            // We give the top -1 because array is zero index; If we dont it will first element
            this.Top = -1;
        }

        public void Push(string item){
            Top++;
            StackArray[Top] = item;
        }

        public string Pop(){
            //Placeholder
            int oldTop = Top;
            //Decrement to the new top
            Top--;
            return StackArray[oldTop];
        }

        public string Peek(){
            return StackArray[Top];
        }

        public bool isEmpty(){
            return Top == 0;
        }

        public bool isFull(){
            return (MaxSize - 1 == Top);
        }
    }
}