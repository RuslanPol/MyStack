using System;
using TestMyStack.Properties;

namespace TestMyStack
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyStack<String> stack = new MyStack<string>(5);
           
            stack.Push("!");
            stack.Push("World");
            stack.Push(" ");
            stack.Push("Hello");
            
            Console.Write(stack.Pop());
            Console.Write(stack.Pop());
            Console.Write(stack.Pop());
            Console.Write(stack.Pop());
            
        }
    }
}