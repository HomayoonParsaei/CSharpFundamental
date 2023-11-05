//07.TypeConversion
// #nullable disable
// string?
// nullable ???

using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Globalization;
using System.Linq.Expressions;

namespace _00.Incalss
{




    class InClassProgram
    {

        //In class test
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
            FibonacciRecursive( 10);
            Console.WriteLine("**********************");
            
            int numberInInt=100;
            string numberInString = numberInInt.ToString();

            int numberToInt= int.Parse(numberInString);
            
            

               

        }
    }
}

