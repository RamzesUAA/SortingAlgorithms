using System;
using System.Collections.Generic;
using System.Text;

namespace AlgorithmsLibrary.Algorithms
{
    public abstract class SortBase
    {
        public void Swap(ref int first, ref int second)
        {
            int temp;
            temp = first;
            first = second;
            second = temp;
        }

    }
}
