namespace _5.StringMethodAndProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String PhoneNumber = "+989223334444";
            String PhoneNumberWithSpace = "   +98   922   333   4444   ";
            // String PhoneNumber = Console.ReadLine();
            String First3 = PhoneNumber.Substring(0,3);
            Console.WriteLine(First3);
            //Remove space from start and end ,not from the middle
            String TrimString = PhoneNumberWithSpace.Trim(); 
            Console.WriteLine(TrimString);
            //F12 to see methods
            


        }
    }
}