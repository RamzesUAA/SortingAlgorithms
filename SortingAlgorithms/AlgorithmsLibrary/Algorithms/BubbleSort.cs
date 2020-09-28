using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary.Algorithms
{
    public class BubbleSort
    {
        private void Swap(ref int lhs, ref int rhs)
        {
            int temp;
            temp = lhs;
            lhs = rhs;
            rhs = temp;
        }
        public void bubbleSort(ref int[] arr)
        {
            for(int i = 0; i<arr.Length; ++i)
            {
                for(int j = 0; j< arr.Length -1; ++j)
                {
                    if(arr[j] > arr[j+1])
                    {
                        Swap(ref arr[j], ref arr[j+1]);
                    }
                }
            }
        }
    }
}
