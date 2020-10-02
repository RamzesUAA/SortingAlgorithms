using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace AlgorithmsLibrary.Algorithms
{
    public class SelectionSort : SortBase
    {
        public void selectionSort(ref int[] arr)  
        {
           for(int i = 0; i < arr.Length - 1; ++i)
            {
                int min = i;
                for(int j= (i+1); j< arr.Length; ++j)
                {
                    if(arr[min] < arr[j])
                    {
                        min = j;
                    }
                }
                Swap(ref arr[min], ref arr[i]);
            }
        }
    }
}
