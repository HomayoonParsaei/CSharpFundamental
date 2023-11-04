using Microsoft.VisualBasic;

namespace _15.IsNumber
{
    internal class Program
    {
        static void Main(String[] args)
        {
           //int n;
            //bool isNumeric = int.TryParse("123", out n);
           // Update As of C# 7:

            var isNumeric = int.TryParse("123", out int n);
            Console.WriteLine($"{isNumeric}\n{n}");


            //#or if you don't need the number you can discard the out parameter

            //var isNumeric = int.TryParse("123", out _);
        }
    }
}