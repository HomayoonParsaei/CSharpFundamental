namespace _09.VarAndDefaultValue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Default Value
            int x = default;
            Boolean y = default;
            string z = default;

            Console.WriteLine(x + "\n" + y + "\n" + z);

            //Var

            var input = true;
            Console.WriteLine(input.GetType());
        }
    }
}