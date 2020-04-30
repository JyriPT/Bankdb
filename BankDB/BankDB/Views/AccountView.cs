using BankDB.Models;
using BankDB.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Views
{
    class AccountView : IAccountView
    {
        private readonly IAccountService _accountService = new AccountService();

        public void CreateAccount(Customer customer)
        {
            Account newAccount = new Account();
            string input = String.Empty;

            newAccount.BankId = customer.BankId;
            newAccount.CustomerId = customer.Id;

            do
            {
                Console.WriteLine("Enter a name for the account:");
                input = Console.ReadLine();
            } while (input == String.Empty);
            newAccount.Name = input;
            input = String.Empty;

            do
            {
                Console.WriteLine("Enter IBAN code for the account:");
                input = Console.ReadLine();
            } while (input == String.Empty);
            newAccount.Iban = input;
            input = String.Empty;

            do
            {
                Console.WriteLine("Enter starting account balance:");
                input = Console.ReadLine();

                if (int.TryParse(input, out int balance) == true && input != String.Empty)
                {
                    newAccount.Balance = balance;
                }
            } while (input == String.Empty);

            var createdAccount = _accountService.Create(newAccount);

            if (createdAccount != null)
            {
                Console.WriteLine("Account creation successful.");
            } else
            {
                Console.WriteLine("Account creation failed.");
            }
        }
    }
}
