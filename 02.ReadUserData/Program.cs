namespace _02.ReadUserData
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Read first name
            Console.WriteLine("What is your first name ?");
            string FirstName = Console.ReadLine();
            //Read last name
            Console.WriteLine("What is your last name ?");
            string LastName = Console.ReadLine();
            //Read age
            Console.WriteLine("How old are you ?");
            string Age = Console.ReadLine();
            //Read phone number
            Console.WriteLine("What is your phone number?");
            string PhoneNUmber = Console.ReadLine();
            //Read ID number
            Console.WriteLine("What is your ID number?");
            string IDNumber = Console.ReadLine();
            //Output
            Console.WriteLine($"Your name is {FirstName} {LastName} and you are {Age} years old.\nYour phone number is: {PhoneNUmber} and your ID number is: {IDNumber}.");

        }
    }
}