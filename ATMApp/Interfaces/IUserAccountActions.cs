using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.Interfaces
{
    public interface IUserAccountActions
    {
        void CheckBalance();
        void PlaceDeposit();
        void MakeWithDrawal();
    }
}
