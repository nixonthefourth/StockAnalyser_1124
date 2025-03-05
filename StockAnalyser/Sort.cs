namespace StockAnalyser
{
    public class Sort
    {
        /*
         * INSERTION SORT
         * INSERTION SORT
         * INSERTION SORT
         */
        
        // Ascending Order
        public void InsertionSortAsc(int[] array)
        {
            if (array.Length != 0)
            {
                for (int i = 1; i < array.Length; i++)
                {
                    // Creates The Key & Index
                    int key = array[i];
                    int index = i - 1;
                
                    // Moves The Elements Of The Array That Are Greater Than The 'key' To One Position Ahead
                    // Also Ensures That The Array Isn't Empty
                    while (index >= 0 && array[index] > key)
                    {
                        // Moves The Position Forward
                        array[index + 1] = array[index];
                    
                        // Decrement Of The Index
                        index--;
                    }
                
                    // Move Key To A New Position
                    array[index + 1] = key;
                }
            
                // Display The Sorted Array
                Visuals.DisplayMessage(string.Join(", ", array));
            }
        }
    }
}