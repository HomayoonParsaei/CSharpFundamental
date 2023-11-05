using System;

namespace _19.ExceptionsTryCatch
{
    internal class Program
    {


        static void checkAge(int age)
        {
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

        //The throw keyword
        //The throw statement allows you to create a custom error.

        //The throw statement is used together with an exception class.
        //There are many exception classes available in C#:
        //ArithmeticException, FileNotFoundException, IndexOutOfRangeException, TimeOutException, etc:

        static void Main(string[] args)
        {
            //Console.WriteLine("Please enter your age");
            //int ageInNumber = int.Parse(Console.ReadLine());
            //checkAge(ageInNumber);

            try
            {
               int[] myNumbers = { 1, 2, 3 };
                Console.WriteLine(myNumbers[10]);
            }
            catch (Exception e)
            {
                Console.WriteLine("Something went wrong.");
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }
    }
}

