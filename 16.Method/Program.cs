namespace _16.Method
{
    internal class Program
    {

        static void MyMethod()
        {
            Console.WriteLine("I just got executed!");
        }

        static void MyMethod2(string fname, int age)
        {
            Console.WriteLine(fname + " is " + age);
        }

        static void Main(string[] args)
        {
            MyMethod();
            MyMethod2("Liam", 5);
        }



      

    }
}