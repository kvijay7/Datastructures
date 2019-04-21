using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    public class WordSplitter
    {
        string[] Dictionary;

        List<IndexedString>[,] substringBuffer;

        public WordSplitter(string[] Dictionary)
        {
            this.Dictionary = Dictionary.OrderByDescending(x => x.Length).ToArray();            
        }

        public void printDictionaryItems()
        {
            foreach (string item in this.Dictionary)
            {
                Console.WriteLine(item);
            }
        }

        public string SplitToWords(string Input)
        {
            substringBuffer = new List<IndexedString>[Input.Length + 1, Input.Length + 1];
            IndexedString stringToSplit = new IndexedString(0, Input, false);

            var sortedList = recursiveWordSearch(stringToSplit, Dictionary).OrderBy(x => x.index);
            string result = "";
            foreach (var word in sortedList)
            {
                result = result + word.text + " ";
            }
            return result;
        }

        private List<IndexedString> recursiveWordSearch(IndexedString stringToSplit, string[] Dictionary)
        {
            int len = stringToSplit.text.Length;
            if(substringBuffer[stringToSplit.index, len + stringToSplit.index] != null)
            {
                return substringBuffer[stringToSplit.index, len + stringToSplit.index];
            }

            List<IndexedString> result = new List<IndexedString>();
            result.Add(stringToSplit);

            string[] newDictionary = Dictionary.Where(x => stringToSplit.text.Contains(x)).ToArray();

            if (newDictionary.Length < 1)
            {
                return result;
            }

            foreach(string entry in newDictionary)
            {
                List<IndexedString> temp = new List<IndexedString>();

                IndexedString[] divByEntry = splitByEntry(stringToSplit, entry);

                IndexedString left = divByEntry[0];
                IndexedString middle = divByEntry[1];
                IndexedString right = divByEntry[2];

                temp.Add(middle);
                temp.AddRange(recursiveWordSearch(left, newDictionary));
                temp.AddRange(recursiveWordSearch(right, newDictionary));

                var tempScore = temp.Where(x => x.word == true);
                var currentScore = result.Where(x => x.word == true);

                if (tempScore.Select(x => x.text.Length).Sum() > currentScore.Select(x => x.text.Length).Sum())
                {
                    result = temp;
                }
                
            }
            substringBuffer[stringToSplit.index, len + stringToSplit.index] = result;
            return result;
        }


        private IndexedString[] splitByEntry(IndexedString source, string entry)
        {
            int indexOfEntry = source.text.IndexOf(entry);
            IndexedString[] result = new IndexedString[3];

            int leftIndex = source.index;
            int entryIndex = source.index + indexOfEntry;
            int rightIndex = source.index + indexOfEntry + entry.Length;

            string leftString = source.text.Substring(0, indexOfEntry);
            string entryString = entry;
            string rightString = source.text.Substring(indexOfEntry + entry.Length);

            result[0] = new IndexedString(leftIndex, leftString, false);
            result[1] = new IndexedString(entryIndex, entryString, true);
            result[2] = new IndexedString(rightIndex, rightString, false);

            return result;

        }

        private class IndexedString
        {
            public int index { get; set; }
            public string text { get; set; }
            public bool word { get; set; }
            public IndexedString(int index, string text, bool word)
            {
                this.index = index;
                this.text = text;
                this.word = word;
            }
        }

    }
}
