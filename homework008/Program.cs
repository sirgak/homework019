using System;

namespace homework008
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = "exit";
            string userInput;
            int trying = 1;
            while ( trying>0 )
            {
                Console.Write("password: ");
                userInput = Console.ReadLine();
                if (password == userInput)
                {
                    Console.WriteLine("woohoo");
                    break;
                }
                else { }
            }
        }       
    }
}