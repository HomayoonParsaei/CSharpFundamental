using System;

namespace _14.Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your age:");

            String age = Console.ReadLine();

            var ageIsNumeric = uint.TryParse(age, out uint ageAsInt);
            if (!string.IsNullOrEmpty(age) && ageIsNumeric)

            {
                if (ageAsInt <= 16)
                {
                    Console.WriteLine($"You are {ageAsInt} years old and identified as child.");
                }
                else if (ageAsInt > 16 && ageAsInt <= 30)
                {
                    Console.WriteLine($"You are {ageAsInt} years old and identified as young adult.");
                }
                else if (ageAsInt > 30 && ageAsInt < 45)
                {
                    Console.WriteLine($"You are {ageAsInt} years old and identified as middle-age adult.");
                }
                else if (ageAsInt > 45 && ageAsInt <= 100)
                {
                    Console.WriteLine($"You are {ageAsInt} years old and identified as old-age adult.");
                }
                else
                {
                    Console.WriteLine($"You are {ageAsInt} years old,you are too old to be alive.");
                }

                Console.WriteLine("\nWith Switch/Case\n");

                switch (ageAsInt)
                {
                    case <= 16:
                        Console.WriteLine($"You are {ageAsInt} years old and identified as child.");
                        break;
                    case > 17 and <= 30 :
                        Console.WriteLine($"You are {ageAsInt} years old and identified as young adult.");
                        break;
                    case > 30 and <= 45:
                        Console.WriteLine($"You are {ageAsInt} years old and identified as middle-age adult.");
                        break;
                    case > 45 and <= 100:
                        Console.WriteLine($"You are {ageAsInt} years old and identified as old-age adult.");
                        break;
                    default:
                        Console.WriteLine($"You are {ageAsInt} years old,you are too old to be alive.");
                        break;
                }
            }

            else
            {
                Console.WriteLine("Entered data is not valid.\n");
            }
        }
    }
}
