namespace StockAnalyser
{
    public class Search
    {
        /// <summary>
        /// Binary search algorithm.
        /// </summary>
        /// 
        /// <param name="array">
        /// Sorted array of integers that is passed down into the method.
        /// </param>
        /// 
        /// <param name="value">
        /// This is the searched value of the variable in the set.
        /// </param>
        /// 
        /// <returns>
        /// Returns index of 'value' if it's present in the 'array'.
        /// </returns>
        ///
        /// <remarks>
        /// We are defining 'low' and 'high' first in here, in order to define the searched range of values.
        ///
        /// While loop is entered, if pointers don't meet.
        /// Midpoint is found first using the value of low + mean.
        ///
        /// We check for the presence of 'value' in the mean of the array.
        /// Then, using the second 'if', if 'value' is greater than midpoint, we ignore left branch,
        /// hence pointer is moved by 1.
        /// Otherwise, if we overshoot to the right, we ignore the right branch and decrease the pointer by 1.
        ///
        /// Then value of -1 is returned, if there is no actual value present.
        /// </remarks>
        public int BinarySearch(int[] array, int value)
        {
            int low = 0, high = array.Length - 1;
            
            while (low <= high)
            {
                int mid = low + (high - low) / 2;

                if (array[mid] == value)
                    return mid;

                if (array[mid] < value)
                {
                    low = mid + 1;
                } else {
                    high = mid - 1;
                }
            }

            return -1;
        }

    }
}