namespace StockAnalyser
{
    public class User
    {
        /// <summary>
        /// Gets value of the user's search
        /// </summary>
        /// 
        /// <returns>
        /// Searched value is returned into an integer in order to be found later with a search value.
        /// </returns>
        ///
        /// <remarks>
        /// Enters the loop, where the entry message is displayed.
        /// Then value is read.
        /// If value doesn't correspond to the parameters of an integer (or empty),
        /// user is asked to enter the value again.
        /// If everything is ok, value is returned as an integer.
        /// </remarks>
        public static int GetValue()
        {
            while (true)
            {
                Visuals.DisplayMessage("\n Enter the searched number: ");
            
                string value = Console.ReadLine();
                
                if (value.Length == 0 || value == " " || int.TryParse(value, out int result) == false)
                {
                    Visuals.DisplayMessage("\n Wrong Input | Please enter a valid integer: ".ToUpper());
                } else {
                    return int.Parse(value);
                    
                    break;
                }
            }
        }

        /// <summary>
        /// Finds the nearest value of the searched result.
        /// </summary>
        /// 
        /// <param name="array">
        /// Array, where we are looking for the values.
        /// </param>
        /// 
        /// <param name="value">
        /// Searched value.
        /// </param>
        /// 
        /// <returns>
        /// Returns the value of the closest value.
        /// </returns>
        public static int FindNearest(int[] array, int value)
        {
            int closest = array[0];
            int minDiff = Math.Abs(array[0] - value);

            foreach (int num in array)
            {
                int diff = Math.Abs(num - value);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    closest = num;
                }
            }
            
            return closest;
        }

        public static void ShowAllFound(int[] array, int value)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    Visuals.DisplayMessage($"\n Value {value} found in: {i}");
                }
            }
        }
    }
}