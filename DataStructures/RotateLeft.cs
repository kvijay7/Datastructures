using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class RotateLeft
    {
        public T[] LeftShiftArray<T>(T[] arr, int shift)
        {
            shift = shift % arr.Length;            
            T[] buffer = new T[shift];
            Array.Copy(arr, buffer, shift);
            Array.Copy(arr, shift, arr, 0, arr.Length - shift);
            Array.Copy(buffer, 0, arr, arr.Length - shift, shift);            
            return arr;                        
        }
    }
}
