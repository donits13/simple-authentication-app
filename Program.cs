using System;

namespace SimpleAuthenticationApp
{
    class Program
    {
        static void Main(string[] args) 
        {
            // Dummy Constants
            string dbEmailAddress = "donitaroseriparip@gmail.com";
            string dbPassword = "password123";

            // Flow
            // 1. Set initial values for user inputs (email address, password)
            // 2. Create a loop where the program will evaluate the user input
            // to the user credentials from database
            // 3. If the user input is not the same as the user credentials
            // from the database, show "Invalid credentials and show again the input,
            // otherwise clear the screen and show "Account successfully logged in."

            string emailAddress = "";
            string password = "";

            while (dbEmailAddress != emailAddress && dbPassword != password)
            {
                Console.Write("Enter email address: ");
                emailAddress = Console.ReadLine();
                Console.Write("Enter password: ");
                password = Console.ReadLine();
                Console.Clear();
                if (dbEmailAddress != emailAddress && dbPassword != password) 
                {
                    Console.WriteLine("Invalid credentials.");
                }
                
            }

            if (dbEmailAddress == emailAddress && dbPassword == password)
            {
                Console.WriteLine("Account successfully logged in.");
            }
        }
    }
}