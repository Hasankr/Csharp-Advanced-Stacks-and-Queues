using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Print_Even_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] input = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Queue<int> numbers = new Queue<int>(input);
            int count = numbers.Count();
            for (int i = 0; i < count; i++)
            {
                if (numbers.Peek() % 2 == 1)
                {
                    numbers.Dequeue();
                }
                else
                {
                    numbers.Enqueue(numbers.Dequeue());
                }
            }
            Console.WriteLine(string.Join(", ", numbers));
        }
    }
}
