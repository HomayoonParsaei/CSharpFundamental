namespace _2.ReadUserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read first name
            Console.WriteLine("What is your first name ?");
            String FirstName = Console.ReadLine();
            //Read first name
            Console.WriteLine("What is your last name ?");
            String LastName = Console.ReadLine();
            //Read Age
            Console.WriteLine("How old are you ?");
            String  Age = Console.ReadLine();
            //Read phone number
            Console.WriteLine("What is your phone number?");
            String PhoneNUmber = Console.ReadLine();
            //Read ID number
            Console.WriteLine("What is your ID number?");
            String IDNumber = Console.ReadLine();
            //Output
            Console.WriteLine($"Your name is {FirstName} {LastName} and you are {Age} years old.");
            Console.WriteLine($"Your phone number is: {PhoneNUmber} and your ID number is: {IDNumber}.");
        }
    }
}