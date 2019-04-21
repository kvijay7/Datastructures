using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class SpecificOrderSort
    {
        public void sortArray()
        {
            int[] arr = {0, 4, 5, 3, 7, 2, 1};
            int[] evenArr = arr.Where(n => n % 2 == 0).OrderBy(n => n).ToArray();
            int[] oddArr = arr.Where(n => n % 2 != 0).OrderByDescending(n => n).ToArray();
            Array.Copy(oddArr, arr, oddArr.Length);
            Array.Copy(evenArr, 0, arr, oddArr.Length, evenArr.Length);
            
            foreach (int i in arr)
            {
                Console.Write(i + " ");
            }            
        }
    }
}
