using Stacks.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var Stack = new SimpleStack<int>();
            Stack.Push(1);
            Stack.Push(2);
            Stack.Push(3);
            Stack.Push(4);
            Stack.Push(5);

            Console.WriteLine(Stack.Pop());
            Console.WriteLine(Stack.Peek());
            Console.WriteLine(Stack.Pop());

            Console.WriteLine(Stack);

            var LinkedStack = new LinkedStack<int>();
            LinkedStack.Push(1);
            LinkedStack.Push(2);
            LinkedStack.Push(3);
            LinkedStack.Push(4);
            LinkedStack.Push(5);

            Console.WriteLine(LinkedStack.Pop());
            Console.WriteLine(LinkedStack.Peek());
            Console.WriteLine(LinkedStack.Pop());

            Console.WriteLine(LinkedStack);

            var ArrayStack = new ArrayStack<int>(5);
            ArrayStack.Push(1);
            ArrayStack.Push(2);
            ArrayStack.Push(3);
            ArrayStack.Push(4);
            ArrayStack.Push(5);

            Console.WriteLine(ArrayStack.Pop());
            Console.WriteLine(ArrayStack.Peek());
            Console.WriteLine(ArrayStack.Pop());

            Console.WriteLine(ArrayStack);

            Console.ReadLine();
        }
    }
}
