using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackMin
{
    //First way:Calculating minimum at each time an item is pushed (Takes more space)
    public class StackWithMins : Stack<NodewithMins>
    {
        public void Push(int item)
        {
            int min = Math.Min(item, this.min());
            base.Push(new NodewithMins(item, min));
        }

        public int min()
        {
            if (this.Peek() == null)
                return int.MaxValue;
            return this.Peek().minValue;
        }

    }
    public class NodewithMins
    {
        public int minValue;
        public int Value;

        public NodewithMins(int minValue, int Value)
        {
            this.minValue = minValue;
            this.Value = Value;
        }
    }

    //Efficient way: Having an additional stack which keeps track of the minimums 
    public class StackWithMin2 : Stack<int>
    {
        Stack<int> s2;

        public StackWithMin2()
        {
            s2 = new Stack<int>();
        }

        public new void Push(int Value)
        {
            if (Value <= min())
            {
                s2.Push(Value);
            }
            base.Push(Value);
        }

        public new int Pop()
        {
            int value = base.Pop();
            if(value == s2.Peek())
            {
                s2.Pop();
            }
            return value;
        }

        public int min()
        {
            if (s2 == null)
                return int.MaxValue;
            return s2.Peek();

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
