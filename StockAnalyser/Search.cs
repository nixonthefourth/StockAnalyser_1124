namespace StockAnalyser
{
    public class Search
    {
        /*
         * BINARY SEARCH
         * BINARY SEARCH
         * BINARY SEARCH
         */
        
        // Recursive Binary Search Implementation
        public int BinarySearch(int[] array, int start, int end, int key)
        {
            // Base Condition That Stops Loop In The End Of The Array
            if (start > end)
            {
                // Displays That Value Isn't Found
                Visuals.DisplayMessage("Value isn't found".ToUpper());
                return -1;
            }
            
            {
                
            }
            
            // Calculate Middle Index
            int mid = start + (end - start) / 2;
            
            // Checks Whether The Middle Index Is Equal To The Target
            if (array[mid] == key)
            {
                Visuals.DisplayMessage($"Item found at {array[mid]}!".ToUpper());
                return mid;
            }
            
            // Otherwise, Carry On With Search
            // Search Right-Hand Data Using Recursion
            if (array[mid] < key && mid + 1 <= end)
            {
                return BinarySearch(array, mid + 1, end, key);
            } else if (array[mid] > key && mid - 1 >= start) {
                // Search The Left-Hand Side using Recursion
                return BinarySearch(array, start, mid - 1, key);
            }
            
            // Value Not Found Safety Case
            return -1;
        }
        
        // Value Input
        public int GetValue()
        {
            while (true)
            {
                // Displays Message To The User
                Visuals.DisplayMessage("Enter the searched number: ".ToUpper());
            
                // Retrieves Value
                string value = Console.ReadLine();
                
                // Idiot Check For Wrong Values
                if (value.Length == 0 || value == " " || int.TryParse(value, out int result) == false)
                {
                    Visuals.DisplayMessage("Wrong Input | Please enter a valid integer: ".ToUpper());
                } else {
                    // In The Case Of Success, Value Is Returned
                    return int.Parse(value);
                    
                    // Breaks The Loop In The Case Of Success
                    break;
                }
            }
        }
    }
}