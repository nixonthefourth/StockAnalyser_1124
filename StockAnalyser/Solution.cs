namespace StockAnalyser
{
    public class Solution
    {
        // Create Objects
        Sort _sortAlgorithms = new Sort();

        // Main Loop
        public void ProgramLoop()
        {
            // Display Sorted Share Data
            
            // Sort 256 Shares
            // Share 1
            Visuals.DisplayMessage("First 256 Blue Chip Share \n");
            _sortAlgorithms.InsertionSortAsc(FileGet("/Users/nick/Documents/Code/Uni/BSc Level 4/Semester B/A&C/Assignments/Assignment 1/StockAnalyser/StockAnalyser/Stocks/Share_1_256.txt"));
            Console.WriteLine("\n \n");
            
            // Share 2
            Visuals.DisplayMessage("Second 256 Blue Chip Share \n");
            _sortAlgorithms.InsertionSortAsc(FileGet("/Users/nick/Documents/Code/Uni/BSc Level 4/Semester B/A&C/Assignments/Assignment 1/StockAnalyser/StockAnalyser/Stocks/Share_2_256.txt"));
            Console.WriteLine("\n \n");

            // Share 3
            Visuals.DisplayMessage("Third 256 Blue Chip Share \n");
            _sortAlgorithms.InsertionSortAsc(FileGet("/Users/nick/Documents/Code/Uni/BSc Level 4/Semester B/A&C/Assignments/Assignment 1/StockAnalyser/StockAnalyser/Stocks/Share_3_256.txt"));
            Console.WriteLine("\n \n");

        }
        
        // .txt File Retrieval
        private int[] FileGet(string path)
        {
            // Retrieve File From A Path
            string[] lines = System.IO.File.ReadAllLines(path);
            int[] array = new int[lines.Length];

            // Append Integer Array
            for (int i = 0; i < lines.Length; i++)
            {
                // Converts String Into Int
                // Also Allocates The File Location
                array[i] = int.Parse(lines[i]);
            }
            
            // Returns The Integer Array
            return array;
        }
    }
}