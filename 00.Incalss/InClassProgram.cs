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


    //In class test


    internal class InClassProgram
    {
        static void Main(string[] args)
        {

            try
            {
                    Console.WriteLine("Enter your gender Male(M)/Female(F) please :");
                    string genderStr = Console.ReadLine();

                    Console.WriteLine("How old are you?");
                    int age = int.Parse(Console.ReadLine());


                    //genderIsMale = (!string.IsNullOrEmpty(genderStr) && (genderStr== "Male" || genderStr == "male" || genderStr == "M" || genderStr == "m")) ?true: false;
                    bool genderIsMale = (!string.IsNullOrEmpty(genderStr) && (genderStr.ToLower() == "male" || genderStr.ToLower() == "m")) ? true : false;

                    if (genderIsMale)
                        Console.WriteLine($"your gender is Male(M) and you are {age} years old.");
                    else
                        Console.WriteLine("your gender is not Male(M).");
                
            }
            catch (Exception ex)
            {
                //Log to DB
                //Log to File
                //Notify Admin
                Console.WriteLine($"Error: {ex.Message}");
                throw;

            }
        }
    }
}