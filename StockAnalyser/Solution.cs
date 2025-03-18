namespace StockAnalyser
{
    public class Solution
    {
        public static void ProgramLoop()
        {
            Menu programMenu = new Menu();
            programMenu.ProgramMenuMain();
        }
        
        /// <summary>
        /// Retrieves the data from the .txt files.
        /// </summary>
        /// 
        /// <param name="path">
        /// Stores the path to the file in a string.
        /// </param>
        /// 
        /// <returns>
        /// Returns the array with the values from the .txt files.
        /// </returns>
        /// 
        /// <remarks>
        /// First, the program passes string path to the required file.
        /// Then, ReadAllLines()path reads all of the data in the file into an array of strings.
        /// Another array of integers is created based on the length of the string array.
        /// For loop is applied in order to parse each value
        /// from an array of strings into  unsorted the array of integers.
        /// </remarks>
        public static int[] FileGet(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            int[] array = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                array[i] = int.Parse(lines[i]);
            }
            
            return array;
        }
        
        /*
         * TODO – Create unique path selection method
         * TODO – Create method to merge files
         */
    }
}