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
        public int GetValue()
        {
            while (true)
            {
                Visuals.DisplayMessage("\nEnter the searched number: ".ToUpper());
            
                string value = Console.ReadLine();
                
                if (value.Length == 0 || value == " " || int.TryParse(value, out int result) == false)
                {
                    Visuals.DisplayMessage("\nWrong Input | Please enter a valid integer: ".ToUpper());
                } else {
                    return int.Parse(value);
                    
                    break;
                }
            }
        }
    }
}