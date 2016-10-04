using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortStack
{
    class Program
    {
        static Stack<int> Sort(Stack<int> s)
        {
            Stack<int> r = new Stack<int>();
            while(s.Count != 0)
            {
                int tmp = s.Pop();
                while (r.Count != 0 && r.Peek() > tmp)
                {
                    s.Push(r.Pop());
                }
                r.Push(tmp);
            }

            // to get the sorted array with minimum on the top
            while (r.Count != 0)
            {
                s.Push(r.Pop());
            }
            return s;
        }

        static void Main(string[] args)
        {
        }
    }
}
