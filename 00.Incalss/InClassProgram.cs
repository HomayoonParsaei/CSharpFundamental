//07.TypeConversion



using Microsoft.VisualBasic;
using System.ComponentModel.Design;
using System.Globalization;

namespace _00.Incalss
{
  

    //In class test
    internal class InClassProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your gender Male(M)/Female(F) please :");
            string genderStr = Console.ReadLine();
            bool genderIsMale;
            genderIsMale = (!string.IsNullOrEmpty(genderStr) && (genderStr=="Male" || genderStr == "male" || genderStr == "M" || genderStr == "m")) ?true: false;
            if (genderIsMale)
                Console.WriteLine("your gender is Male(M).");
            else
                Console.WriteLine("your gender is not Male(M).");
        }
    }
}