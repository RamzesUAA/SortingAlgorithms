using System;
using System.Linq;

namespace AlgorithmsLibrary
{
    public class ArrayItem
    {
        private Random random = new Random();
        public int[] Array;
        public ArrayItem()
        {
            Console.Write("Enter dimension of array: ");
            string input = Console.ReadLine();
            int number = int.Parse(input);
            Array = new int[number];
        }
        public void InputFunc()
        {
            Console.WriteLine("Enter numbers for array:");
            for (int i = 0; i < Array.Length; ++i)
            {
                Console.Write($"Array[{i}]:");
                string input = Console.ReadLine();
                Array[i] = int.Parse(input);
            }
        }
        public void OutputFunc()
        {
            for (int i = 0; i < Array.Length; ++i)
            {
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine("\n");

        }

        public void AuthoPlaceholder()
        {
            for (int i = 0; i < Array.Length; ++i)
            {
                Array[i] = random.Next(0, 2147483647);
            }
        }

        public void DeleteMaxAndMin()
        {
            int max = Array.Max();
            int min = Array.Min();
            Array = Array.Where(p => p != max && p != min).ToArray();
        }
    }
}
