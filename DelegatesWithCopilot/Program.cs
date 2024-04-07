namespace DelegatesWithCopilot
{
    // Delegate is a type that represents references to methods with a particular parameter list and return type.
    // When you instantiate a delegate, you can associate its instance with any method with a compatible signature and return type.
    // You can invoke (or call) the method through the delegate instance.
    
    public class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the delegate
            Action<int> printDelegate = PrintNumber;

            // Call the delegate
            printDelegate(100000);
            printDelegate(200);

            // Instantiate the delegate with a different method
            printDelegate = PrintMoney;

            // Call the delegate
            printDelegate(10000);
            printDelegate(200);
        }

        // Method that takes an integer and prints to the console
        public static void PrintNumber(int num)
        {
            Console.WriteLine("Number: {0}", num);
        }

        // Method that takes an integer and prints to the console as currency
        public static void PrintMoney(int money)
        {
            Console.WriteLine("Money: {0:C}", money);
        }
    }
}