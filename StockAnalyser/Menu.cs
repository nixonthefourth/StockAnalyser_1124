namespace StockAnalyser
{
    public class Menu
    {
        private bool _arraySizeFlag;
        private bool _sortOrderFlag;
        private int[] _array;
        
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
        public void ProgramMenuMain()
        {
            Console.Clear();

            Visuals.DisplayMessage("\n Welcome to the stock analyser!");
                
            Visuals.DisplayMessage("\n \n Actions:");
            Visuals.DisplayMessage("\n 1 | Select Stock Data To Analyse");
            Visuals.DisplayMessage("\n 2 | Exit");
            
            while (true)
            {
                try
                {
                    Visuals.DisplayMessage("\n Please enter the desired action from the list: ");
                    int menuActionLocal = int.Parse(Console.ReadLine());
                    
                    if (menuActionLocal == 1)
                    {
                        ProgramMenuArraySize();
                        
                        break;
                    } else if (menuActionLocal == 2) {
                        Environment.Exit(0);
                    } else {
                        Visuals.DisplayMessage("\n Invalid action. Please try again.");
                    }
                } catch (Exception e) {
                    Visuals.DisplayMessage("\n Only ints are allowed!");
                }
            }
        }
            
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
            
            while (true)
            {
                try
                {
                    Visuals.DisplayMessage("\n Please enter the desired action from the list: ");
                    int menuAction = int.Parse(Console.ReadLine());

                    if (menuAction == 1)
                    {
                        _arraySizeFlag = true;
                        
                        ProgramMenuStockSelect();
                        ProgramMenuSort(_array);

                        break;
                    } else if (menuAction == 2) {
                        _arraySizeFlag = false;
                        
                        ProgramMenuStockSelect();
                        ProgramMenuSort(_array);

                        break;
                    } else {
                        Visuals.DisplayMessage("\n Invalid action. Please try again.");
                    }
                } catch (Exception e) {
                    Visuals.DisplayMessage("\n Only ints are allowed!");
                }
            }
        }

        /// <summary>
        /// Selectes requires stocks.
        /// </summary>
        ///
        /// <remarks>
        /// First 3 options give us the stock options depending on the previously selected stock numbres and array sizes.
        /// Number 4 though is a very peculiar case, where arrays need to be merged.
        /// Hence, arrays are called first into temp arrays and then merged using 'foreach' loops.
        /// This is applied in order to merge two arrays into a global one.
        /// </remarks>
        private void ProgramMenuStockSelect()
        {
            Console.Clear();
            
            Visuals.DisplayMessage("\n \n Actions:");
            Visuals.DisplayMessage("\n 1 | Stock 1");
            Visuals.DisplayMessage("\n 2 | Stock 2");
            Visuals.DisplayMessage("\n 3 | Stock 3");
            Visuals.DisplayMessage("\n 4 | Merged Stock");
            
            while (true)
            {
                try
                {
                    Visuals.DisplayMessage("\n Please enter the desired action from the list: ");
                    int menuAction = int.Parse(Console.ReadLine());

                    if (menuAction == 1 && _arraySizeFlag)
                    {
                        _array = Solution.FileGet(
                            "Share_1_256.txt");

                        break;
                    } else if (menuAction == 2 && _arraySizeFlag) {
                        _array = Solution.FileGet(
                            "Share_2_256.txt");

                        break;
                    } else if (menuAction == 3 && _arraySizeFlag) {
                        _array = Solution.FileGet(
                            "Share_3_256.txt");

                        break;
                    } else if (menuAction == 4 && _arraySizeFlag) {
                        int[] leftTemp = Solution.FileGet(
                            "Share_1_256.txt");
                        
                        int[] rightTemp = Solution.FileGet(
                            "Share_3_256.txt");
                        
                        _array = new int[leftTemp.Length + rightTemp.Length];

                        int i = 0;
                        foreach (int num in leftTemp) _array[i++] = num;
                        foreach (int num in rightTemp) _array[i++] = num;
                        
                        break;
                    } else if (menuAction == 1 && !_arraySizeFlag) {
                        _array = Solution.FileGet(
                            "Share_1_2048.txt");

                        break;
                    } else if (menuAction == 2 && !_arraySizeFlag) {
                        _array = Solution.FileGet(
                            "Share_2_2048.txt");

                        break;
                    } else if (menuAction == 3 && !_arraySizeFlag) {
                        _array = Solution.FileGet(
                            "Share_3_2048.txt");

                        break;
                    } else if (menuAction == 4 && !_arraySizeFlag) {
                        int[] leftTemp = Solution.FileGet(
                            "Share_1_2048.txt");
                        
                        int[] rightTemp = Solution.FileGet(
                            "Share_3_2048.txt");
                        
                        _array = new int[leftTemp.Length + rightTemp.Length];

                        int i = 0;
                        foreach (int num in leftTemp) _array[i++] = num;
                        foreach (int num in rightTemp) _array[i++] = num;
                        
                        break;
                    } else {
                        Visuals.DisplayMessage("\n Invalid action. Please try again.");
                    }
                } catch (Exception e) {
                    Visuals.DisplayMessage("\n Only ints are allowed!");
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
            Visuals.DisplayMessage("\n 4 | Merge Sort");
                
            while (true)
            {
                try
                {
                    Visuals.DisplayMessage("\n Please enter the desired action from the list: ");
                    int menuAction = int.Parse(Console.ReadLine());

                    if (menuAction == 1)
                    {
                        ProgramMenuAsc();
                        
                        if (_sortOrderFlag)
                        {
                            Sort.InsertionSortAsc(array);
                        } else if (!_sortOrderFlag) {
                            Sort.InsertionSortDesc(array);
                        }

                        Console.WriteLine();
                        Visuals.DisplayStock(_arraySizeFlag, array);
                        Console.WriteLine();

                        ConfirmationMessage();
                        
                        ProgramMenuSearch();

                        break;
                    } else if (menuAction == 2) {
                        ProgramMenuAsc();

                        if (_sortOrderFlag)
                        {
                            Sort.QuickSortAsc(array, 0, array.Length - 1);
                        } else if (!_sortOrderFlag) {
                            Sort.QuickSortDesc(array, 0, array.Length - 1);
                        }

                        Console.WriteLine();
                        Visuals.DisplayStock(_arraySizeFlag, array);
                        Console.WriteLine();

                        ConfirmationMessage();
                        
                        ProgramMenuSearch();

                        break;
                    } else if (menuAction == 3) {
                        ProgramMenuAsc();

                        if (_sortOrderFlag)
                        {
                            Sort.BubbleSortAsc(array);
                        } else if (!_sortOrderFlag) {
                            Sort.BubbleSortDesc(array);
                        }

                        Console.WriteLine();
                        Visuals.DisplayStock(_arraySizeFlag, array);
                        Console.WriteLine();

                        ConfirmationMessage();
                        
                        ProgramMenuSearch();

                        break;
                    } else if (menuAction == 4) {
                        ProgramMenuAsc();

                        if (_sortOrderFlag)
                        {
                            Sort.MergeSortAsc(array, 0, array.Length - 1);
                        } else if (!_sortOrderFlag) {
                            Sort.MergeSortDesc(array, 0, array.Length - 1);
                        }

                        Console.WriteLine();
                        Visuals.DisplayStock(_arraySizeFlag, array);
                        Console.WriteLine();

                        ConfirmationMessage();
                        
                        ProgramMenuSearch();

                        break;
                    } else {
                        Visuals.DisplayMessage("\n Invalid action. Please try again.");
                    }
                } catch (Exception e) {
                    Visuals.DisplayMessage("\n Only ints are allowed!");
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
        private void ProgramMenuAsc()
        {
            Console.Clear();

            Visuals.DisplayMessage("\n \n Orders:");
            Visuals.DisplayMessage("\n 1 | Ascending");
            Visuals.DisplayMessage("\n 2 | Descending");

            while (true)
            {
                try
                {
                    Visuals.DisplayMessage("\n Please enter the desired order from the list: ");
                    int menuAction = int.Parse(Console.ReadLine());

                    if (menuAction == 1)
                    {
                        _sortOrderFlag = true;
                        break;
                    } else if (menuAction == 2) {
                        _sortOrderFlag = false;
                        break;
                    } else {
                        Visuals.DisplayMessage("\n Invalid action. Please try again.");
                    }
                } catch (Exception e) {
                    Visuals.DisplayMessage("\n Only ints are allowed!");
                }
            }
        }

        /// <summary>
        /// Search menu
        /// </summary>
        private void ProgramMenuSearch()
        {
            Console.Clear();
            
            Visuals.DisplayMessage("\n \n Actions:");
            Visuals.DisplayMessage("\n 1 | Linear Search");
            Visuals.DisplayMessage("\n 2 | Binary Search");

            while (true)
            {
                try
                {
                    Visuals.DisplayMessage("\n Please enter the desired search algorithm from the list: ");
                    int menuAction = int.Parse(Console.ReadLine());

                    if (menuAction == 1)
                    {
                        try
                        {
                            int userValue = User.GetValue();
                            
                            int linearResult = Search.LinearSearch(_array, userValue);
                            
                            if (linearResult != -1)
                            {
                                Visuals.DisplayMessage("\n Value was found here: " + linearResult);
                                User.ShowAllFound(_array, userValue);
                            } else if (linearResult == -1) {
                                int nearestValue = User.FindNearest(_array, userValue);
                                Visuals.DisplayMessage($"\n Value doesn't exist. Nearest value is: {nearestValue}");
                                User.ShowAllFound(_array, nearestValue);
                            }
                            
                        } catch (Exception e) {
                            Visuals.DisplayMessage("\n Only ints are allowed!");
                        }
                        
                        ConfirmationMessage();
                        
                        break;
                    } else if (menuAction == 2) {
                        try
                        {
                            int userValue = User.GetValue();
                            
                            int binaryResult = Search.BinarySearch(_array, userValue);

                            if (binaryResult != -1)
                            {
                                Visuals.DisplayMessage("\n Value was found here: " + binaryResult);
                                User.ShowAllFound(_array, binaryResult);
                            } else if (binaryResult == -1) {
                                int nearestValue = User.FindNearest(_array, userValue);
                                Visuals.DisplayMessage($"\n Value doesn't exist. Nearest value is: {nearestValue}");
                                User.ShowAllFound(_array, nearestValue);
                            }
                            
                            ConfirmationMessage();
                        } catch (Exception e) {
                            Visuals.DisplayMessage("\n Only ints are allowed!");
                        }
                        
                        break;
                    } else {
                        Visuals.DisplayMessage("\n Invalid action. Please try again.");
                    }
                } catch (Exception e) {
                    Visuals.DisplayMessage("\n Only ints are allowed!");
                }
            }
        }
        
        /// <summary>
        /// Confirmation sequence (Press Enter to continue)
        /// </summary>
        private void ConfirmationMessage()
        {
            Visuals.DisplayMessage("\n \n Press Enter to continue...");
            Console.ReadLine();
            
            Console.Clear();
        }
    }
}

