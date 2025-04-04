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
        public static int[] InsertionSortAsc(int[] array)
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
        public static int[] InsertionSortDesc(int[] array)
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
        private static int PartitionAsc(int[] array, int low, int high)
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
        public static void QuickSortAsc(int[] array, int low, int high)
        {
            if (array == null || array.Length == 0) return;
            if (low >= high) return;

            int pivot = PartitionAsc(array, low, high);
            QuickSortAsc(array, low, pivot - 1);
            QuickSortAsc(array, pivot + 1, high);
        }
        
        /// <summary>
        /// Partitions the array into two halves based on a pivot element.
        /// Elements greater than or equal to the pivot are placed on the left,
        /// and elements less than the pivot are placed on the right.
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
        private static int PartitionDesc(int[] array, int low, int high)
        {
            int pivot = array[high];
            int lowIndex = low - 1;

            for (int i = low; i < high; i++)
            {
                if (array[i] >= pivot)
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
        /// Performs the descending recursive quick sort algorithm on the given array within the specified range.
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
        public static void QuickSortDesc(int[] array, int low, int high)
        {
            if (array == null || array.Length == 0) return;
            if (low >= high) return;

            int pivot = PartitionDesc(array, low, high);
            QuickSortDesc(array, low, pivot - 1);
            QuickSortDesc(array, pivot + 1, high);
        }

        /// <summary>
        /// Ascending Bubble Sort algorithm, that swaps the elements in the O(n^2) complexity.
        /// </summary>
        /// 
        /// <param name="array">
        /// Array to be sorted.
        /// </param>
        ///
        /// <remarks>
        /// Initialises variables for two loops that sort through the array as well as the flag.
        ///
        /// First loop is initialised in order to track the swapped elements.
        /// If the two elements aren't swapped, we call it quits.
        ///
        /// Second loop is actually responsible for swapping.
        /// If element 'a' is greater than 'a+1',
        /// we store the current element in a temporary variable,
        /// then assign current element to the '+ 1' position,
        /// and then we assign temporarly variable to the '+ 1' position.
        /// Flag is set to true.
        ///
        /// Loop is repeated until we break in the first loop, pretty much.
        /// Nested loops make up the n^2 squared complexity.
        /// </remarks>
        public static void BubbleSortAsc(int[] array)
        {
            int i, j, temp;
            bool swapped;
            
            for (i = 0; i < array.Length - 1; i++)
            {
                swapped = false;
                for (j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                
                if (swapped == false)
                    break;
            }
        }
        
        /// <summary>
        /// Descending Bubble Sort algorithm, that swaps the elements in the O(n^2) complexity.
        /// </summary>
        /// 
        /// <param name="array">
        /// Array to be sorted.
        /// </param>
        ///
        /// <remarks>
        /// Initialises variables for two loops that sort through the array as well as the flag.
        ///
        /// First loop is initialised in order to track the swapped elements.
        /// If the two elements aren't swapped, we call it quits.
        ///
        /// Second loop is actually responsible for swapping.
        /// If element 'a' is less than 'a+1',
        /// we store the current element in a temporary variable,
        /// then assign current element to the '+ 1' position,
        /// and then we assign temporarly variable to the '+ 1' position.
        /// Flag is set to true.
        ///
        /// Loop is repeated until we break in the first loop, pretty much.
        /// Nested loops make up the n^2 squared complexity.
        /// </remarks>
        public static void BubbleSortDesc(int[] array)
        {
            int i, j, temp;
            bool swapped;
            
            for (i = 0; i < array.Length - 1; i++)
            {
                swapped = false;
                for (j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                
                if (swapped == false)
                    break;
            }
        }
        
        /// <summary>
        /// Creates ascending merge sort algorithm, which will be used in the main function later.
        /// </summary>
        /// 
        /// <param name="array">
        /// Array to be sorted.
        /// </param>
        /// 
        /// <param name="left">
        /// Left pointer of the array (set with 0).
        /// </param>
        /// 
        /// <param name="mid">
        /// Midpoint of the main array.
        /// </param>
        /// 
        /// <param name="right">
        /// Right-hand pointer of the array.
        /// </param>
        ///
        /// <remarks>
        /// This method merges two subarrays of 'array'.
        ///
        /// First, sizes of these arrays are defined using pointers.
        /// n1 – Stores the left-most subarray
        /// n2 – Stores the right-most subarray
        ///
        /// Temp arrays are created later on for right and left-hand arrays of sizes n1 and n2 respectively.
        /// Data is copied then into the temp-arrays later.
        ///
        /// Then, these arrays need to be merged. Indeces 'i' and 'j' are redefined later.
        /// Via while loop we add the pieces of data in the array until pointers are met with the arrays lengths.
        ///
        /// If any elements are still left in the temp arrays, they are copied back to the main array.
        /// </remarks>
        private static void MergeAsc(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftTemp = new int[n1];
            int[] rightTemp = new int[n2];
            
            int i, j;

            for (i = 0; i < n1; ++i)
            {
                leftTemp[i] = array[left + i];
            }

            for (j = 0; j < n2; ++j)
            {
                rightTemp[j] = array[mid + 1 + j];
            }

            i = 0;
            j = 0;
            
            int k = left;
            
            while (i < n1 && j < n2)
            {
                if (leftTemp[i] <= rightTemp[j])
                {
                    array[k] = leftTemp[i];
                    
                    i++;
                } else {
                    array[k] = rightTemp[j];
                    
                    j++;
                }
                
                k++;
            }

            while (i < n1)
            {
                array[k] = leftTemp[i];
                
                i++;
                k++;
            }
            
            while (j < n2)
            {
                array[k] = rightTemp[j];
                
                j++;
                k++;
            }
        }

        /// <summary>
        /// Main sorting function that recursively calls the ascending merging method.
        /// </summary>
        /// 
        /// <param name="array">
        /// An array to be sorted.
        /// </param>
        /// 
        /// <param name="left">
        /// Left-hand pointer of the array.
        /// </param>
        /// 
        /// <param name="right">
        /// Right-hand pointer of the array.
        /// </param>
        ///
        /// <remarks>
        /// Recursively calls the main function as well as the sorting function.
        /// There are two recursive calls, since we need to separate the arrays into two halves,
        /// which allows us to sort the array.
        /// </remarks>
        public static void MergeSortAsc(int[] array, int left, int right)
        {
            if (left < right)
            {

                int mid = left + (right - left) / 2;

                MergeSortAsc(array, left, mid);
                MergeSortAsc(array, mid + 1, right);

                MergeAsc(array, left, mid, right);
            }
        }
        
        /// <summary>
        /// Creates descending merge sort algorithm, which will be used in the main function later.
        /// </summary>
        /// 
        /// <param name="array">
        /// Array to be sorted.
        /// </param>
        /// 
        /// <param name="left">
        /// Left pointer of the array (set with 0).
        /// </param>
        /// 
        /// <param name="mid">
        /// Midpoint of the main array.
        /// </param>
        /// 
        /// <param name="right">
        /// Right-hand pointer of the array.
        /// </param>
        ///
        /// <remarks>
        /// This method merges two subarrays of 'array'.
        ///
        /// First, sizes of these arrays are defined using pointers.
        /// n1 – Stores the left-most subarray
        /// n2 – Stores the right-most subarray
        ///
        /// Temp arrays are created later on for right and left-hand arrays of sizes n1 and n2 respectively.
        /// Data is copied then into the temp-arrays later.
        ///
        /// Then, these arrays need to be merged. Indeces 'i' and 'j' are redefined later.
        /// Via while loop we add the pieces of data in the array until pointers are met with the arrays lengths.
        ///
        /// If any elements are still left in the temp arrays, they are copied back to the main array.
        /// </remarks>
        private static void MergeDesc(int[] array, int left, int mid, int right)
        {
            int n1 = mid - left + 1;
            int n2 = right - mid;

            int[] leftTemp = new int[n1];
            int[] rightTemp = new int[n2];
            int i, j;

            for (i = 0; i < n1; ++i)
            {
                leftTemp[i] = array[left + i];
            }

            for (j = 0; j < n2; ++j)
            {
                rightTemp[j] = array[mid + 1 + j];
            }

            i = 0;
            j = 0;

            int k = left;
            while (i < n1 && j < n2)
            {
                if (leftTemp[i] >= rightTemp[j])
                {
                    array[k] = leftTemp[i];
                    
                    i++;
                } else {
                    array[k] = rightTemp[j];
                    
                    j++;
                }
                
                k++;
            }

            while (i < n1)
            {
                array[k] = leftTemp[i];
                
                i++;
                k++;
            }

            while (j < n2)
            {
                array[k] = rightTemp[j];
                
                j++;
                k++;
            }
        }

        /// <summary>
        /// Main sorting function that recursively calls the descending merging method.
        /// </summary>
        /// 
        /// <param name="array">
        /// An array to be sorted.
        /// </param>
        /// 
        /// <param name="left">
        /// Left-hand pointer of the array.
        /// </param>
        /// 
        /// <param name="right">
        /// Right-hand pointer of the array.
        /// </param>
        ///
        /// <remarks>
        /// Recursively calls the main function as well as the sorting function.
        /// There are two recursive calls, since we need to separate the arrays into two halves,
        /// which allows us to sort the array.
        /// </remarks>
        public static void MergeSortDesc(int[] array, int left, int right)
        {
            if (left < right)
            {

                int mid = left + (right - left) / 2;

                MergeSortDesc(array, left, mid);
                MergeSortDesc(array, mid + 1, right);

                MergeDesc(array, left, mid, right);
            }
        }
    }
}