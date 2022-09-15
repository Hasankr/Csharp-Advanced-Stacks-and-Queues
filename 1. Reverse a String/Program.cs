using System;
using System.Collections.Generic;

namespace _1._Reverse_a_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char item in input)
            {
                stack.Push(item);
            }
            foreach (var item in stack)
            {
                Console.Write(item);
            }
        }
    }
}
