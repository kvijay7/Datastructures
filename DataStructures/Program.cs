using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            /*BEGIN Find the Kth Smallest Element in an Array*/
            //Console.WriteLine("Enter the array numbers");
            //int[] arrElements = Array.ConvertAll(Console.ReadLine().Split(','), arrTemp => Convert.ToInt32(arrTemp));
            //Console.WriteLine("Enter the value of k");
            //int k = Convert.ToInt32(Console.ReadLine());
            //ArrayList arr = new ArrayList();
            //arr.AddRange(arrElements);            
            //KthSmallestElement ksmall = new KthSmallestElement();
            //Console.WriteLine("The {0} th smallest number is {1}",k,ksmall.kthSmallest(arr, k));
            /*END Find the Kth Smallest Element in an Array*/

            /* BEGIN InsertAndFrequency of ArrayList */
            //Console.WriteLine("How many characters in all?");
            //int noOfChars = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter the string");
            //char[] chars = Console.ReadLine().ToCharArray();
            //InsertandFrequency iandf = new InsertandFrequency();
            //iandf.Insert(chars, noOfChars);
            /* END InsertAndFrequency of ArrayList */

            /* BEGIN Anagrams */
            FindAnagrams ana = new FindAnagrams();
            ana.anagrams();
            /* END Anagrams */

            /* BEGIN RotateArray Left */

            //string[] strArr = new string[] { "Tokyo", "Okyot" };//, "Kyoto", "Yotko" };
            //List<ArrayList> lal = new List<ArrayList>();
            //RotateLeft rl = new RotateLeft();
            //for (int i = 0; i < strArr.Length; i++)
            //{
            //    char[] chrArr = strArr[i].ToLower().ToCharArray();
            //    ArrayList a = new ArrayList();
            //    for (int j = 0; j < chrArr.Length; j++)
            //    {
            //        rl.LeftShiftArray(chrArr, 1);
            //        string str = new string(chrArr);                    
            //        a.Add(str);                    
            //    }
            //    lal.Add(a);
            //}

            //foreach (ArrayList a in lal)
            //{

            //    //foreach(string s in a)
            //    //{
            //    //    Console.WriteLine(s);
            //    //}                
            //}


            /* END RotateArray Left */

            /* BEGIN FindTheFine */
            //Console.WriteLine("Enter the number of records and the month of fine with spaces in between");
            //string[] s = Console.ReadLine().Split(' ');
            //int numOfRecs = int.Parse(s[0]);
            //int Month = int.Parse(s[1]);
            //Console.WriteLine("Enter the {0} car numbers with spaces", numOfRecs);
            //int[] carNums = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //Console.WriteLine("Enter the {0} fines with spaces", numOfRecs);
            //int[] fines = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));

            //FindTheFine f = new FindTheFine();
            //f.findFine(numOfRecs, Month, carNums, fines);
            /* END FindTheFine */
            //SpecificOrderSort sort = new SpecificOrderSort();
            //sort.sortArray();

            // WORD SPLITTER PROGRAM
            //string[] dictionary = new string[] { "super","hero", "batman", "is", "a", "spiderman", "marvel", "dc", "ironman", "and" };
            //WordSplitter WS = new WordSplitter(dictionary);
            //WS.printDictionaryItems();    
            //string test = WS.SplitToWords("batmanandspidermanhero".ToLower());
            //Console.WriteLine(test);

            //Palindrome p = new Palindrome();
            //Console.WriteLine(p.isPalindrome("Dad"));

            /*
            binarysearch bin = new binarysearch();
            int[] arr = new int[] { 1, 7, 9, 12, 14, 15, 19, 26 };
            Console.WriteLine("Enter the target");
            int target = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(bin.binarySearch(arr, target));
            Console.ReadKey();
            */

            //SelectionSort sSort = new SelectionSort();
            //int[] arr = new int[] { 28, 1, 12, 32, 15, 17, 11, 41 };
            //arr = sSort.selectionSort(arr);            
            //foreach(int val in arr)
            //{                
            //    Console.Write(val + " ");
            //}            

            Console.ReadKey();

        }        

    }
}
