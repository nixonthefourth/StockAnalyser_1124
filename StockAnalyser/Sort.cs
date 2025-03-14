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
    }
}