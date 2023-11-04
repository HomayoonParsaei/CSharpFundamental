namespace _13.BreakAndContinue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cellPhone = null;
            while(true)
            {
                Console.WriteLine("Please enter valid cellphone:");
                    cellPhone=Console.ReadLine();
                if (!string.IsNullOrEmpty (cellPhone))
                {
                    break;
                }
                    
                        
            }
            Console.WriteLine("Hello, World!");
        }
    }
}