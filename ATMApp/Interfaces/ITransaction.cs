using ATMApp.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.Interfaces
{
    public interface ITransaction
    {
        void InsertTransaction(long _UserBankAccountId, TransactionType _tranType, decimal _tranAmount, string _desc);
        void ViewTransaction();
    }
}
