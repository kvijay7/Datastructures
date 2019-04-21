using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class InsertandFrequency
    {
        public void Insert(char[] chars, int noOfChars)
        {
            ArrayList arr = new ArrayList();
            string word = "";
            string chrfrq = "";
            for (int i = 0; i <  2*(noOfChars); i++)
            {
                if (chars[i] == 'i' && (i%2 ==0))
                {                    
                    arr.Add(chars[i + 1]);
                }
                else if(chars[i] == 'f' && i < 2*(noOfChars)-1)
                {
                    chrfrq = chars[i + 1].ToString();
                }
            }
            foreach(char c in arr)
            {
                word = word + c;
            }            
            bool isCharInWord = word.Contains(chrfrq);
            if (isCharInWord)
            {
                int frequency = word.Count(x => x == char.Parse(chrfrq));
                Console.WriteLine("The frequency of {0} in {1} is {2} ", chrfrq, word, frequency);
            }
            else
            {
                Console.WriteLine("This character {0} is not Present in the word {1} ", chrfrq, word);
            }
        }        
    }
}
