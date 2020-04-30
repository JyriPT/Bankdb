using BankDB.Services;
using BankDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Views
{
    class BankView : IBankView
    {
        private readonly IBankService _bankService = new BankService();

        public void CreateBank()
        {
            Bank newBank = new Bank();
            string input = string.Empty;

            while (input == string.Empty)
            {
                Console.WriteLine("Enter name of new bank:");
                input = Console.ReadLine();
            }

            newBank.Name = input;
            input = String.Empty;

            while (input == string.Empty)
            {
                Console.WriteLine("Enter BIC of new bank:");
                input = Console.ReadLine();
            }

            newBank.Bic = input;

            var createdPerson = _bankService.Create(newBank);
            Console.WriteLine(newBank.Name);
        }

        public void DeleteBank()
        {
            Console.Write("Enter the id of bank to be deleted:");
            var userInput = Console.ReadLine();

            int id = int.Parse(userInput);

            _bankService.Delete(id);
        }

        public void UpdateBank()
        {
            Console.Write("Enter id of bank to be updated:");
            var userInput = Console.ReadLine();

            int id = int.Parse(userInput);

            var bank = _bankService.Read(id);

            if (bank != null)
            {
                Console.WriteLine("Give new name for bank:");
                userInput = Console.ReadLine();

                bank.Name = userInput;
                var updatedBank = _bankService.Update(id, bank);

                PrintBankData(updatedBank);
            } else
            {
                Console.WriteLine("Bank not found, check id.");
            }
            
        }

        private void PrintBankData(Bank bank)
        {
            Console.WriteLine("ID\tNimi\tBIC");
            Console.WriteLine($"{bank.Id}\t{bank.Name}\t{bank.Bic}");
        }
    }
}
