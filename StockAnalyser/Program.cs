namespace StockAnalyser
{
    class Program
    {
        /// <summary>
        /// Program name: 'Stock Exchnage Data Analyser'
        /// Author: Nick Khomiakov
        /// Submission date: 27th of March 2025, Thursday
        /// </summary>
        /// 
        /// <remarks>
        /// PROGRAM DESCRIPTION
        /// This program is a console-based application that reads, sorts, and
        /// searches stock exchange volume data from multiple text files. The
        /// program allows users to analyze stock trading activity by implementing
        /// different sorting and searching algorithms.
        ///
        /// PROGRAM FUNCTIONS
        /// Reads stock exchange volume data from multiple text files.
        /// Sorts the data in ascending and descending order.
        /// Displays every 10th (for smaller datasets) or 50th (for larger
        /// datasets) value after sorting.
        /// Searches for a user-defined value and returns its position(s).
        /// If the value is not found, provides the nearest value(s) and their position(s).
        /// Merges and processes datasets for advanced analysis.
        /// Compares different sorting and searching algorithms by counting their execution steps.
        ///
        /// IMPLEMENTED ALGORITHMS
        /// Sort: Bubble, Insertion, Merge and Quick Sorts
        /// Search: Linear and Binary Searches.
        ///
        /// IMPLEMNETED FUNCTIONS
        /// Displayed every 10th and 50th values of the code (depending on the file size).
        /// Collected the file path.
        /// FindNearest and DisplayAll requirements have been implemented.
        /// GetValue from user's input is provded.
        /// Menu for the software operation is created.
        /// </remarks>
        static void Main(string[] args)
        {
            // Connect Solution Class
            Solution.ProgramLoop();
        }
    }
}

