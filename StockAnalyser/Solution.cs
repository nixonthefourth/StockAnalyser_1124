namespace StockAnalyser
{
    public class Solution
    {
        /// <summary>
        /// Creating objects in order to access the methods and related data.
        /// </summary>
        Sort _sortAlgorithms = new Sort();
        Search _searchAlgorithms = new Search();

        public void ProgramLoop()
        {
            
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
        private int[] FileGet(string path)
        {
            string[] lines = System.IO.File.ReadAllLines(path);
            int[] array = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                array[i] = int.Parse(lines[i]);
            }
            
            return array;
        }
    }
}