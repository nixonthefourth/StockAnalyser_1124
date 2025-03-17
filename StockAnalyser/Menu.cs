namespace StockAnalyser
{
    public class Menu
    {
        private bool _arraySizeFlag;
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

            Visuals.DisplayMessage("\n Welcome to the stock analyser!");
                
            Visuals.DisplayMessage("\n \n Actions:");
            Visuals.DisplayMessage("\n 1 | Select Stock Data To Analyse");
            Visuals.DisplayMessage("\n 2 | Exit");

            while (true)
            {
                Visuals.DisplayMessage("\n Please enter the desired action from the list: ");
                int menuAction = int.Parse(Console.ReadLine());

                if (menuAction == 1)
                {
                    ProgramMenuArraySize();
                    break;
                } else if (menuAction == 2) {
                    Environment.Exit(0);
                } else {
                    Visuals.DisplayMessage("\n Invalid action. Please try again.");
                }
            }
        }
            
        /*
         * TODO – Create stock index (1 'till 3 for borh 256 and 2048) selection
         * TODO – Create display method
         * TODO – Create unique path selector method
         * TODO – Create method to merge files
         * TODO – Build in the merge method into the menu code
        */
            
        /// <summary>
        /// Getting the array sizes of the stock files in the selectors.
        /// </summary>
        ///
        /// <remarks>
        /// Messages are entered first.
        /// If '1' is selected, the flag is set to true (hence array size is 256).
        /// If '2' is selected, the flag is set to true (hence array size is 2048).
        /// Back is the option '3', which simply breaks the loop.
        ///
        /// Otherwise, enter the data again, since we don't want to bother with the wrong input.
        /// </remarks>
        private void ProgramMenuArraySize()
        {
            Console.Clear();
                
            Visuals.DisplayMessage("\n \n Actions:");
            Visuals.DisplayMessage("\n 1 | 256 Data Points");
            Visuals.DisplayMessage("\n 2 | 2048 Data Points");
            Visuals.DisplayMessage("\n 3 | Back");

            while (true)
            {
                Visuals.DisplayMessage("\n Please enter the desired action from the list: ");
                int menuAction = int.Parse(Console.ReadLine());

                if (menuAction == 1)
                {
                    _arraySizeFlag = true;
                    break;
                } else if (menuAction == 2) {
                    _arraySizeFlag = false;
                    break;
                } else if (menuAction == 3) {
                    break;
                } else {
                    Visuals.DisplayMessage("\n Invalid action. Please try again.");
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
            Visuals.DisplayMessage("\n 1 | Insertion Sort");
            Visuals.DisplayMessage("\n 2 | Quick Sort");
            Visuals.DisplayMessage("\n 3 | Bubble Sort");
            Visuals.DisplayMessage("\n 4 | Back");
                
            while (true)
            {
                Visuals.DisplayMessage("\n Please enter the desired action from the list: ");
                int menuAction = int.Parse(Console.ReadLine());

                if (menuAction == 1)
                {
                    if (ProgramMenuAsc())
                    {
                        Sort.InsertionSortAsc(array);
                    } else if (!ProgramMenuAsc()) {
                        Sort.InsertionSortDesc(array);
                    }
                        
                    Console.WriteLine();
                    Visuals.DisplayMessage(string.Join(" | ", array));
                    Console.WriteLine();
                        
                    System.Threading.Thread.Sleep(3000);
                        
                    Console.Clear();
                        
                    break;
                } else if (menuAction == 2) {
                    if (ProgramMenuAsc())
                    {
                        Sort.QuickSortAsc(array, 0, array.Length - 1);
                    } else if (!ProgramMenuAsc()) {
                        Sort.QuickSortDesc(array, 0, array.Length - 1);
                    }
                        
                    Console.WriteLine();
                    Visuals.DisplayMessage(string.Join(" | ", array));
                    Console.WriteLine();
                        
                    System.Threading.Thread.Sleep(3000);
                        
                    Console.Clear();
                        
                    break;
                } else if (menuAction == 3) {
                    if (ProgramMenuAsc())
                    {
                        Sort.BubbleSortAsc(array);
                    } else if (!ProgramMenuAsc()) {
                        Sort.BubbleSortDesc(array);
                    }
                        
                    Console.WriteLine();
                    Visuals.DisplayMessage(string.Join(" | ", array));
                    Console.WriteLine();
                        
                    System.Threading.Thread.Sleep(3000);
                        
                    Console.Clear();
                        
                    break;
                } else if (menuAction == 4) {
                    break;
                } else {
                    Visuals.DisplayMessage("\n Invalid action. Please try again.");
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
            Visuals.DisplayMessage("\n 1 | Ascending");
            Visuals.DisplayMessage("\n 2 | Descending");

            while (true)
            {
                Visuals.DisplayMessage("\n Please enter the desired order from the list: ");
                int menuAction = int.Parse(Console.ReadLine());

                if (menuAction == 1)
                {
                    return true;
                    break;
                } else if (menuAction == 2) {
                    return false;
                    break;
                } else {
                    Visuals.DisplayMessage("\n Invalid action. Please try again.");
                }
            }
        }
    }
}

