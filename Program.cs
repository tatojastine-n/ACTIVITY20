using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordPolicyValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your password: ");
                string password = Console.ReadLine();

                if (password.ToLower() == "quit")
                {
                    Console.WriteLine("Goodbye!");
                    break;
                }

                ValidatePassword(password);
            }
        }
        static void ValidatePassword(string password)
        {
            bool hasMinLength = password.Length >= 8;
            bool hasNumber = password.Any(char.IsDigit);
            bool hasCapital = password.Any(char.IsUpper);

            if (hasMinLength && hasNumber && hasCapital)
            {
                Console.WriteLine("Valid password");
            }
            else
            {
                Console.WriteLine("Invalid password. Missing requirements:");

                if (!hasMinLength)
                    Console.WriteLine("- At least 8 characters");
                if (!hasNumber)
                    Console.WriteLine("- At least one number");
                if (!hasCapital)
                    Console.WriteLine("- At least one capital letter");
            }
            Console.WriteLine();  // Add blank line for readability
        }
    }
}
