﻿using BankDB.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Views
{
    public interface IAccountView
    {
        void CreateAccount(Customer customer);
        void ReadAll(Bank bank);
    }
}
