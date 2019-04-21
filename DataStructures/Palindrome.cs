using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Palindrome
    {
        public Boolean isPalindrome(string str)
        {
            string reversedStr = "";
            str = str.ToLower();
            char[] chrArray = str.ToCharArray();
            char[] newArray = new char[chrArray.Length];

            for(int i=0; i < chrArray.Length; i++)
            {
                newArray[i] = chrArray[(chrArray.Length-1) - i];
            }
            reversedStr = new string(newArray);

            Console.WriteLine("Provided String {0} and the reversed string {1}", str, reversedStr);
            
            if (reversedStr == str)
            {
                return true;
            }

            return false;
        }
    }
}
