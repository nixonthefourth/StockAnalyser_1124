namespace StockAnalyser
{
    public class Solution
    {
        // Data Sorting
        Sort _sortAlgorithms = new Sort();

        public void ProgramLoop()
        {
            // Tryout Array
            int[] testArray = new int[] { 3, 1, 12, 90, 56, 21 };
            
            // Ascending Order Sort
            _sortAlgorithms.InsertionSortAsc(testArray);
        }
    }
}