namespace StockAnalyser
{
    public class Visuals
    {
        /// <summary>
        /// Typewriter Visual
        /// </summary>
        /// 
        /// <param name="message">
        /// Message that needs to be displayed
        /// </param>
        ///
        /// <remarks>
        /// Displays the string using for look and core threading, where each value is shown with a delay.
        /// </remarks>
        public static void DisplayMessage(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i].ToString().ToUpper());
                System.Threading.Thread.Sleep(15);
            }
        }

        public static void DisplayStock(bool stockSizeFlag, int[] stock)
        {
            if (stockSizeFlag)
            {
                int step = 10;
                for (int i = step - 1; i < stock.Length; i+= step)
                {
                    DisplayMessage(stock[i].ToString() + "\n");
                }
            } else if (!stockSizeFlag) {
                int step = 50;
                for (int i = step - 1; i < stock.Length; i+= step)
                {
                    DisplayMessage(stock[i].ToString() + "\n");
                } 
            }
        }
    }
}