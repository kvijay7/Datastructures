using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class FindTheFine
    {

        public void findFine(int numOfRecords, int Month, int[] carArray, int[] fineArray)
        {
            int sumOddNumberedCarsFines = 0;
            int sumEvenNumberedCarsFines = 0;
            for(int i = 0; i < numOfRecords; i++)
            {
                if((Month%2 ==0) && (carArray[i]%2 != 0)) //even date, odd car number
                {
                    sumOddNumberedCarsFines = sumOddNumberedCarsFines + fineArray[i];
                }
                else if((Month%2 != 0) && (carArray[i]%2 == 0)) //odd date, even car number
                {
                    sumEvenNumberedCarsFines = sumEvenNumberedCarsFines + fineArray[i];
                }
            }
            Console.WriteLine("Even Number Car Fines: {0} and Odd Number Car Fines: {1}", sumEvenNumberedCarsFines,sumOddNumberedCarsFines);
            Console.WriteLine("Total Fines: {0}", sumOddNumberedCarsFines + sumEvenNumberedCarsFines);
        }
    }
}
