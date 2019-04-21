namespace DataStructures
{
    class SelectionSort
    {
        public int[] swap(int[] array, int firstIndex, int secondIndex)
        {
            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
            return array;
        }
        public int indexOfMinimum(int[] array, int startIndex)
        {
            int minVal = array[startIndex];
            int minIndex = startIndex;

            for(int i = minIndex + 1; i < array.Length; i++)
            {
                if(array[i] < minVal)
                {
                    minIndex = i;
                    minVal = array[i];
                }
            }
            return minIndex;
        }
        public int[] selectionSort(int[] array)
        {
            int i, index;
            for (i = 0; i < array.Length; i++)
            {
                index = indexOfMinimum(array, i);
                if(i != index)
                {
                    swap(array, i, index);
                }                
            }
            return array;
        }
    }
}
