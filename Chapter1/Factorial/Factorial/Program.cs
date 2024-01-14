namespace Factoria
{
    internal class Program
    {
        public static int Factorial(int i)
        {
            if (i == 1 || i == 0)
            {
                return 1;
            }
            return i * Factorial(i - 1);
        }

        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            int result = Factorial(number);

            Console.WriteLine($"The factorial of {number} is: {result}");
        }
    }
}
