namespace StockAnalyser
{
    public class Solution
    {
        Sort _sort = new Sort();
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
        
        /// <summary>
        /// Application menu that allows to navigate through the actions.
        /// </summary>
        ///
        /// <remarks>
        /// This is a multi-level operation, hence at the 'Main' level we just enter the app.
        /// Welcome message is displayed, actions are listed ('Data Selection' and 'Exit').
        ///
        /// While loop is entered in order to ensure correct input has been created.
        /// Option 1 leads us to the method, where the array of the desired size is selected.
        /// Option 2 allows to close the environment (aka quit).
        /// Another 'else' statement simply validates the action by the logical rules of implication.
        /// </remarks>
        private void ProgramMenuMain()
        {
            Console.Clear();

            Visuals.DisplayMessage("\n Welcome to the stock analyser!".ToUpper());
            
            Visuals.DisplayMessage("\n \n Actions:".ToUpper());
            Visuals.DisplayMessage("\n 1 | Select Stock Data".ToUpper());
            Visuals.DisplayMessage("\n 2 | Exit".ToUpper());

            while (true)
            {
                Visuals.DisplayMessage("\n Please enter the desired action from the list: ".ToUpper());
                int menuAction = int.Parse(Console.ReadLine());

                if (menuAction == 1)
                {
                    
                    break;
                } else if (menuAction == 2) {
                    Environment.Exit(0);
                } else {
                    Visuals.DisplayMessage("\n Invalid action. Please try again.".ToUpper());
                }
            }
        }

        /// <summary>
        /// After user has selected the desired array to be sorted, we can actually select which array to sort.
        /// </summary>
        /// 
        /// <param name="array">
        /// An array to be sorted.
        /// </param>
        /// 
        /// <remarks>
        /// Previous 'page' is cleared and new messages w/ sorting algorithms are entered.
        /// Each option (apart from 'Back') calls a method, which selects the order of the array we are sorting in.
        /// If the selection is true, we are sorting an array using the selected sorting algorithm in ascention.
        /// Otherwise, algorithm is descending.
        ///
        /// Array is displayed later and console is cleared then.
        /// For now I have applied 'Sleep' as the way to display stuff, but I really want to apply 'Press Enter...'.
        /// I also want to update the action to match with the assignment requirements.
        /// </remarks>
        private void ProgramMenuSort(int[] array)
        {
            Console.Clear();
            
            Visuals.DisplayMessage("\n \n Actions:");
            Visuals.DisplayMessage("\n 1 | Insertion Sort".ToUpper());
            Visuals.DisplayMessage("\n 2 | Quick Sort".ToUpper());
            Visuals.DisplayMessage("\n 3 | Bubble Sort".ToUpper());
            Visuals.DisplayMessage("\n 4 | Back".ToUpper());
            
            while (true)
            {
                Visuals.DisplayMessage("\n Please enter the desired action from the list: ".ToUpper());
                int menuAction = int.Parse(Console.ReadLine());

                if (menuAction == 1)
                {
                    if (ProgramMenuAsc())
                    {
                        _sort.InsertionSortAsc(array);
                    } else if (!ProgramMenuAsc()) {
                        _sort.InsertionSortDesc(array);
                    }
                    
                    Console.WriteLine();
                    Visuals.DisplayMessage(string.Join(" | ", array));
                    Console.WriteLine();
                    
                    System.Threading.Thread.Sleep(3000);
                    
                    Console.Clear();
                } else if (menuAction == 2) {
                    if (ProgramMenuAsc())
                    {
                        _sort.QuickSortAsc(array, 0, array.Length - 1);
                    } else if (!ProgramMenuAsc()) {
                        _sort.QuickSortDesc(array, 0, array.Length - 1);
                    }
                    
                    Console.WriteLine();
                    Visuals.DisplayMessage(string.Join(" | ", array));
                    Console.WriteLine();
                    
                    System.Threading.Thread.Sleep(3000);
                    
                    Console.Clear();
                } else if (menuAction == 3) {
                    if (ProgramMenuAsc())
                    {
                        _sort.BubbleSortAsc(array);
                    } else if (!ProgramMenuAsc()) {
                        _sort.BubbleSortDesc(array);
                    }
                    
                    Console.WriteLine();
                    Visuals.DisplayMessage(string.Join(" | ", array));
                    Console.WriteLine();
                    
                    System.Threading.Thread.Sleep(3000);
                    
                    Console.Clear();
                } else if (menuAction == 4) {
                    break;
                } else {
                    Visuals.DisplayMessage("\n Invalid action. Please try again.".ToUpper());
                }
            }
        }

        /// <summary>
        /// Selects whether the array will be sorted in descending or ascending orders.
        /// </summary>
        /// 
        /// <returns>
        /// Returns the value of the selected order. Since it's a binary system, I have applied boolean data type.
        /// </returns>
        ///
        /// <remarks>
        /// Messages are displayed.
        /// If ascending order is selected, 'true' is returned and loop is broken.
        /// It's a protective style of coding, which ensures that we won't be stuck forever in the loop,
        /// even if the selection is successful.
        ///
        /// Otherwise, descending order is selected. There is no third option, since it will break the user journey
        /// to the desired action.
        ///
        /// In case none of the actions correspond with the selection, we just throw an 'else' statement,
        /// where data needs to be re-entered.
        /// </remarks>
        private bool ProgramMenuAsc()
        {
            Console.Clear();

            Visuals.DisplayMessage("\n \n Orders:");
            Visuals.DisplayMessage("\n 1 | Ascending".ToUpper());
            Visuals.DisplayMessage("\n 2 | Descending".ToUpper());

            while (true)
            {
                Visuals.DisplayMessage("\n Please enter the desired order from the list: ".ToUpper());
                int menuAction = int.Parse(Console.ReadLine());

                if (menuAction == 1)
                {
                    return true;
                    break;
                } else if (menuAction == 2) {
                    return false;
                    break;
                } else {
                    Visuals.DisplayMessage("\n Invalid action. Please try again.".ToUpper());
                }
            }
        }
    }
}