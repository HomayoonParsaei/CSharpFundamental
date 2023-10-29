namespace _6.ConditionsAndIfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             # AND              &&
             # OR               ||
             # Equal to         ==
             # Not Equal to     !=
             # empty ""
             # null     
            */
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
            /*
            if (condition) 
                {
                // block of code to be executed if the condition is True
                }
                else if(condition2)
                {
                 // block of code to be executed if the condition is True
                }
                else
                {
                 // // block of code to be executed if both conditions are False
                }
            */
            //+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++

            /* Console.WriteLine("Please enter your mobile number");
             String MobileNumber = Console.ReadLine();
             if (string.IsNullOrEmpty(MobileNumber))
             {
                 Console.Write("Plese enter the mobile number");
                 return;
             }
            */
            Console.WriteLine("Please enter your mobile number:(+98000000000)");
            String MobileNumber = Console.ReadLine();

            if (!string.IsNullOrEmpty(MobileNumber))
            {
                String TrimedPhoneNumber = MobileNumber.Trim();
                String FirstThreeCharecters = TrimedPhoneNumber.Substring(0, 3);

                if (FirstThreeCharecters == "+98")
                { 
                    Console.Write($"Your country code is {FirstThreeCharecters} .\n");
                }
                else
                {
                    Console.WriteLine("Counrty code is not valid");
                }
            }
            else
            {
                Console.WriteLine("Enter valid phone number");
                return;
            }


            //string ReplacedFirstThreeCharecters = FirstThreeCharecters.Replace("+98", "0098");
            //Console.WriteLine(ReplacedFirstThreeCharecters);




        }
    }
}