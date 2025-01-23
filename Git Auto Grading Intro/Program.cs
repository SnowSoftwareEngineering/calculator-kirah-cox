namespace StudentProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Welcome to the calculator project, complete the methods

            // Call the methods here ex.

            int a = 10;
            int b = 5;

            int addResult = Add(a, b);
            Console.WriteLine($"The result of adding these two numbers is: {addResult}.");
        }

        // Methods Here
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Subtract(int a, int b)
        {
            return a - b;
        }
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
        public static decimal Divide(int a, int b)
        {
            return a / b;
        }
    }
}
