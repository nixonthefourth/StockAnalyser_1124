namespace StockAnalyser
{
    public class Visuals
    {
        // Typewriter Visual
        public static void DisplayMessage(string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i].ToString().ToUpper());
                System.Threading.Thread.Sleep(20);
            }
        }
    }
}