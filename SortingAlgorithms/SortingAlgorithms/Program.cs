using AlgorithmsLibrary.Algorithms;
using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void InputFunc(int [] arr)
        {
            for(int i = 0; i < arr.Length; ++i)
            {
                Console.Write(arr[i] + " ");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter dimension of array:");
            string input = Console.ReadLine();
            int number = int.Parse(input);

            int[] Array = new int[number];
            Console.WriteLine("Enter numbers for array:");
            for(int i = 0; i < number; ++i)
            {
                Console.Write($"Array[{i}]:");
                input = Console.ReadLine();
                Array[i] = int.Parse(input);
            }

            BubbleSort bubble = new BubbleSort();
            bubble.bubbleSort(ref Array);
            InputFunc(Array);
        }
    }
}
