using System;
using System.Collections.Generic;
using System.Text;

namespace BankDB.Views
{
    public interface IBankView
    {
        void CreateBank();
        void UpdateBank();
        void DeleteBank();
    }
}
