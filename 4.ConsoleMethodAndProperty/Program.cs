using System;
namespace _04.ConsoleMethodAndProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                        //Change some attributes in console
                        Console.SetBufferSize(500, 500);//Size of console
                        Console.BackgroundColor = ConsoleColor.DarkBlue;//Set Background color
                        Console.ForegroundColor = ConsoleColor.DarkRed;//Set Text color
                        Console.Title = "My Console!";//Title
                        Console.SetCursorPosition(0, 3);//Start of cursor

                        Console.Write("Hello!");//To show String in console
                        Console.WriteLine("I am Parham Darvishi!");//To show String in console and go to next line
                        Console.WriteLine("*********************************************");
                        Console.WriteLine("What is your name?");
                        Console.ReadLine();//To get string from user
                        //Console.ReadKey();
                        */


            Console.SetBufferSize(500, 500);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Title = "My Console!";
            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"Changing the Console attributes\nForground: Black\nBackground: White\nTitle: My Console\nCursorPosition: 0,3");
            Console.ReadLine();//Title is not changing without this command
        }
    }
}