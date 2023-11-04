namespace _10.Function
{
    internal class Program
    {
        public static int Add(int FirstNumber, int SecondNumbers)
        {
            return FirstNumber + SecondNumbers;
        }
        public static int Add(int number1, int number2, int number3)
        {
            return number1 + number2 + number3;
        }
        public static int Multi(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }

        static void ShowMessage(string msg)
        {
            Console.WriteLine(msg);
        }
        //Devider ???
        static void ShowDevider()
        {
            Console.WriteLine("************Devider***********");
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
            Console.WriteLine(Add(1, 2, 3));
            Console.WriteLine(Multi(3, 5, 7));


            Console.WriteLine("Enter first number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter second number");
            int secondNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter third number");
            int thirdNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(Multi(firstNumber, secondNumber, thirdNumber));
        }
    }
}

//Method Overload
//Method Signutre
//Public static