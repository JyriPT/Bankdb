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
            throw new NotImplementedException();
        }

        public void DeleteBank()
        {
            throw new NotImplementedException();
        }

        public void UpdateBank()
        {
            throw new NotImplementedException();
        }
    }
}
