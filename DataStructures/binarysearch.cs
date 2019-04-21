using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class binarysearch
    {
        public int binarySearch(int[] array, int target)
        {
            int minIndex = 0;
            int maxIndex = array.Length;
            int midIndex;
            while(maxIndex >= minIndex)
            {
                midIndex = (minIndex + maxIndex) / 2;
                if(array[midIndex] == target)
                {
                    return midIndex;
                }
                else if(array[midIndex] < target)
                {
                    minIndex = midIndex + 1;
                }
                else
                {
                    maxIndex = midIndex - 1;
                }
            }
            return -1;            
        }
       
    }
}
