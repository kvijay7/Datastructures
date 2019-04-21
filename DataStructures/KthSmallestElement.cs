using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class KthSmallestElement
    {
        public int kthSmallest(ArrayList arr, int k)
        {                                
            while(k != 0)
            {
                int smallest = (int)arr[0];
                foreach (int a in arr)
                {
                    if (a < smallest)
                    {
                        smallest = a;
                    }
                }                
                arr.Remove(smallest);                
                k--;
                if (k == 0) { return smallest; }
            }
            return 0;
        }

        
    }
}
