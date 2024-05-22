using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackExample
{
   class Program
    {
        static void Main()
        {
            Stack<int> stack = new Stack<int>();    
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();
           foreach(int i in stack)
            {
                Console.WriteLine(i);
            }
           System.Console.WriteLine("Lat Element in Stack : "+stack.Peek());
            Console.WriteLine("Number of elements in stack : "+stack.Count());
            Console.ReadKey();
        }
    }
}
