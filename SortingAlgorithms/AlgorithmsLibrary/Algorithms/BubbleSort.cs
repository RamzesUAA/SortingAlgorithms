using System;
using System.Collections.Generic;
using System.Text;
using System.Timers;

namespace AlgorithmsLibrary.Algorithms
{
    public class BubbleSort : SortBase
    { 
        public void bubbleSort(ref int[] arr)
        {
            int size = arr.Length;
            for (int i = 0; i < size; i++)
            {
                bool F = false;
                for (int j = 0; j < size - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        Swap(ref arr[j], ref arr[j + 1]);
                        F = true;
                    }
                }
                if (F == false) break;
            }
        }
    }
}
