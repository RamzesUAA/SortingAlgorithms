using AlgorithmsLibrary;
using AlgorithmsLibrary.Algorithms;
using System;
using System.Linq;
using System.Timers;


namespace SortingAlgorithms
{
    class Program
    {
        

        static void Main(string[] args)
        {

            //!!!!-------Manual inputting----!!!!!

            ArrayItem arrayItem = new ArrayItem();
            arrayItem.InputFunc();
            arrayItem.DeleteMaxAndMin();
            Console.WriteLine("--------------Initial Array--------------");
            arrayItem.OutputFunc();


            Console.WriteLine("--------------Bubble sort--------------");
            BubbleSort bubble = new BubbleSort();
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            bubble.bubbleSort(ref arrayItem.Array);
            watch.Stop();
            Console.WriteLine($"-Execution Time: {watch.ElapsedMilliseconds} ms-\n");
            arrayItem.OutputFunc();



            Console.WriteLine("--------------Selection sort--------------");
            SelectionSort selection = new SelectionSort();
            watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            selection.selectionSort(ref arrayItem.Array);
            watch.Stop();
            Console.WriteLine($"Execution Time: {watch.ElapsedMilliseconds} ms\n");
            arrayItem.OutputFunc();
        }
    }
}
