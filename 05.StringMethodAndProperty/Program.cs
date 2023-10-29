namespace _05.StringMethodAndProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PhoneNumber = "+989223334444";
            string PhoneNumberWithSpace = "   +98   922   333   4444   ";
            // String PhoneNumber = Console.ReadLine();
            string First3 = PhoneNumber.Substring(0, 3);
            Console.WriteLine(First3);
            //Remove space from start and end ,not from the middle
            string TrimString = PhoneNumberWithSpace.Trim();
            Console.WriteLine(TrimString);
            //F12 to see methods



        }
    }
}