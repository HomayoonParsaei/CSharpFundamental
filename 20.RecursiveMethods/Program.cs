namespace _20.RecursiveMethods
{
    internal class Program
    {

        public static void FibonacciRecursive(int len)
        {
            FibonacciRecursiveTemp(0, 1, 1, len);
        }

        public static void FibonacciRecursiveTemp(int a, int b, int counter, int len)
        {
            if (counter <= len)
            {
                Console.WriteLine(a);
                FibonacciRecursiveTemp(b, a + b, counter + 1, len);
            }

        }


        static void Main(string[] args)
        {
            Console.WriteLine("**********************");
            FibonacciRecursive(10);
            Console.WriteLine("**********************");
        }
    }
}