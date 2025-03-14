namespace StockAnalyser
{
    public class Sort
    {
        /// <summary>
        /// Creating insertion sort in the ascending order.
        /// </summary>
        /// 
        /// <param name="array">
        /// Array that needs to be sorted is passed down here.
        /// </param>
        /// 
        /// <returns>
        /// Returns a sorted array of integers.
        /// </returns>
        ///
        /// <remarks>
        /// First, array is checked on whether it is empty.
        /// For loop is applied in order to sort the array itself, starting from the second index,
        /// assuming that first element is sorted. Then loop terminates when i reaches the array's length.
        ///
        /// Keys and indices of the array are created and changed with each new iteration of the loop.
        ///
        /// If the value is greater than key and search index in the first place is present in the array,
        /// then while loop executes.
        /// Indices are swapped and index is decremented, while counter still moves on.
        /// Key in the array also moves forward to 1.
        /// </remarks>
        public int[] InsertionSortAsc(int[] array)
        {
            if (array.Length != 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    int key = array[i];
                    int index = i - 1;
                    
                    while (index >= 0 && array[index] > key)
                    {
                        array[index + 1] = array[index];
                    
                        index--;
                    }
                
                    array[index + 1] = key;
                }
            }
            
            return array;
        }
        
        /// <summary>
        /// Creating insertion sort in the descending order.
        /// </summary>
        /// 
        /// <param name="array">
        /// Array that needs to be sorted is passed down here.
        /// </param>
        /// 
        /// <returns>
        /// Returns a sorted array of integers.
        /// </returns>
        ///
        /// <remarks>
        /// First, array is checked on whether it is empty.
        /// For loop is applied in order to sort the array itself, starting from the second index,
        /// assuming that first element is sorted. Then loop terminates when i reaches the array's length.
        ///
        /// Keys and indices of the array are created and changed with each new iteration of the loop.
        ///
        /// If the value is less than key and search index in the first place is present in the array,
        /// then while loop executes.
        /// Indices are swapped and index is decremented, while counter still moves on.
        /// Key in the array also moves forward to 1.
        /// </remarks>
        public int[] InsertionSortDesc(int[] array)
        {
            if (array.Length != 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    int key = array[i];
                    int index = i - 1;
                
                    while (index >= 0 && array[index] < key)
                    {
                        array[index + 1] = array[index];
                    
                        index--;
                    }
                
                    array[index + 1] = key;
                }
            }
            
            return array;
        }

        /// <summary>
        /// Partitions the array into two halves based on a pivot element.
        /// Elements smaller than or equal to the pivot are placed on the left,
        /// and elements greater than the pivot are placed on the right.
        /// </summary>
        /// 
        /// <param name="array">
        /// The array that will be partitioned.
        /// </param>
        /// <param name="low">
        /// The starting index of the array range.
        /// </param>
        /// <param name="high">
        /// The ending index of the array range, which is also the pivot index.
        /// </param>
        /// 
        /// <returns>
        /// The index position of the pivot after partitioning.
        /// </returns>
        private int Partition(int[] array, int low, int high)
        {
            int pivot = array[high];
            int lowIndex = low - 1;

            for (int i = low; i < high; i++)
            {
                if (array[i] <= pivot)
                {
                    lowIndex++;
                    
                    int tempVal0 = array[lowIndex];
                    array[lowIndex] = array[i];
                    array[i] = tempVal0;
                }
            }
            
            int tempVal1 = array[lowIndex + 1];
            array[lowIndex + 1] = array[high];
            array[high] = tempVal1;
            
            return lowIndex + 1;
        }

        /// <summary>
        /// Performs the ascending recursive quick sort algorithm on the given array within the specified range.
        /// </summary>
        /// 
        /// <param name="array">
        /// The array to be sorted.
        /// </param>
        /// <param name="low">
        /// The starting index of the array's range.
        /// </param>
        /// <param name="high">
        /// The ending index of the array's range.
        /// </param>
        public void QuickSort(int[] array, int low, int high)
        {
            if (array == null || array.Length == 0) return;
            if (low >= high) return;

            int pivot = Partition(array, low, high);
            QuickSort(array, low, pivot - 1);
            QuickSort(array, pivot + 1, high);
        }
    }
}