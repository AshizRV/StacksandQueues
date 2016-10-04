using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueviaStacks
{
    public class MyQueue<T>
    {
        Stack<T> stackoldest = new Stack<T>();
        Stack<T> stacknewest = new Stack<T>();

        public MyQueue()
        {
            stacknewest = new Stack<T>();
            stackoldest = new Stack<T>();
        }
        public int size()
        {
            return stackoldest.Count + stacknewest.Count;
        }

        public void Add(T value)
        {
            stacknewest.Push(value);
        }

        private void ShiftStacks()
        {
            if(stackoldest.Count == 0)
            {
                while (stacknewest.Count != 0)
                {
                    stackoldest.Push(stacknewest.Pop());
                }
            }
        }

        public T Peek()
        {
            //Ensure stackoldest has the current elements
            ShiftStacks();
            return stackoldest.Peek();
        }

        public T Pop()
        {
            ShiftStacks();
            return stackoldest.Pop();
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
