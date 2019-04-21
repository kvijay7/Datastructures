using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class FindAnagrams
    {
       
        public bool checkAnagram(string s1, string s2)
        {
            int[] letter = new int[26];
            for (int j = 0; j < s1.Length; j++)
            {
                int idx = s1[j] - 'a';                
                letter[idx]++;                
            }
            for (int i = 0; i < s2.Length; i++)
            {
                int ix = s2[i] - 'a';
                if ((--letter[ix]) < 0) return false;
            }
            return true;
        }


        public void anagrams()
        {
            string txt = "AB";
            string w = "ab";
            w = w.ToLower();
            txt = txt.ToLower();
            int k = w.Length;
            string s1 = txt.Substring(0, k);
            int count = 0;
            if (checkAnagram(w, s1))
            {                
                count++;                
            }
            for (int j = k; j < txt.Length; j++)
            {
                s1 = txt.Substring(j - k + 1, k);
                if (checkAnagram(s1, w))
                {                    
                    count++;                    
                }
            }

            string res = (count > 0) ? "These 2 strings {0} and {1} are anagrams" : "These 2 strings {0} and {1} are not anagrams";

            Console.WriteLine(res, txt, w);            
            
        }
    }
}
