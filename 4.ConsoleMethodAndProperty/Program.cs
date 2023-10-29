using System;
namespace _4.ConsoleMethodAndProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.SetBufferSize(500, 500);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.Title = "My Console!";
            Console.SetCursorPosition(0, 3);
            Console.WriteLine($"Changing the Console attributes\nForground: Black\nBackground: White\nTitle: My Console\nCursorPosition: 0,3");
            Console.WriteLine("Write");
        }
    }
}