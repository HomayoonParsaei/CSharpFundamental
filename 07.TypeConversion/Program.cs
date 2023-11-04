using Microsoft.VisualBasic;

namespace _07.TypeConversion
{
    //Type Casting
    internal class Program
    {
        static void Main(string[] args)
        {
            //Implicit Type Conversions
            //Explicit Type Conversions

            //string strAge = Console.ReadLine();
            //int age = int.Parse(strAge);
            //long y;
            //age=(int) y; ????

            Console.WriteLine("Please Enter your age");
            string strAge = Console.ReadLine();
            if (!string.IsNullOrEmpty(strAge))
            {
                int Age = int.Parse(strAge);
                Console.WriteLine($"your age is: {Age}\n");
                var AgeDataType = Age.GetType();
                Console.WriteLine($"Data type is: {AgeDataType}");

            }
            else
            {
                Console.WriteLine("Please enter the phone number");
            }


        }
    }
}