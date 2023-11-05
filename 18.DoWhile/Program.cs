namespace _18.DoWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);


            if (i == 5)
                i++;
            else
                i--;


        }
    }
}