using System;
using System.Collections.Generic;

namespace BankAccountData
{
    class BankAccountData
    {
        static void Main()
        {
            Console.Write("First name: ");
            string firstName = Console.ReadLine();
            Console.Write("Middle name: ");
            string middleName = Console.ReadLine();
            Console.Write("Last name: ");
            string lastName = Console.ReadLine();
            Console.Write("Balance: ");
            decimal balance = decimal.Parse(Console.ReadLine());
            Console.Write("Bank name: ");
            string bankName = Console.ReadLine();
            Console.Write("IBAN code: ");
            string iban = Console.ReadLine();
            List<string> creditCards = new List<string>();
            for (int i = 1; i <= 3; i++)
            {
                Console.Write("Credit card ({0}) number: ",i);
                creditCards.Add(Console.ReadLine());
            }

        }
    }
}
