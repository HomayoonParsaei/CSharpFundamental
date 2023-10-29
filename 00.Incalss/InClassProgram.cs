﻿using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Globalization;

namespace _00.Incalss
{
    public class Person
    {
        public int Age { get; set; }
    }



    internal class InClassProgram
    {
        public bool CheckMobileIsValid(string mobile)
        {
            if (!string.IsNullOrEmpty(mobile) && mobile.Length == 11)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public static int Add(int FirstNumber, int SecondNumbers)
        {
            return FirstNumber + SecondNumbers;
        }

        //Method Overload
        //Method Signutre
        //Public static
        public static int Add(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }
        public static int Multi(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
       //Devider
       static void ShowDevider()
        {
            Console.WriteLine("************Devider***********");
        }

        static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Main(string[] args)
        {
            ShowMessage("Hi");
           // Console.WriteLine(Add(1, 2));
           // Console.WriteLine(Add(1, 2, 3));
           // Console.WriteLine(Multi(3, 5, 7));

            //Read and converte number
            Console.WriteLine("Enter first number");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number");
            int secondNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number");
            int thirdNumber = int.Parse(Console.ReadLine());
            //Resualt
            Console.WriteLine(Multi(firstNumber, secondNumber, thirdNumber));
        }
    }
}