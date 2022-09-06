using ATMApp.Model;
using ATMApp.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace ATMApp.APP
{
    public class Atmapp
    {
        private List<UserAccount> userAccountList;
        private UserAccount selectedAccount;

        public void InitializeData()
        {
            userAccountList = new List<UserAccount>
            {
                new UserAccount{Id=1, FullName = "Naresh", AccountNumber=123456,CardNumber =111111, CardPin=222222,AccountBalance=50000.00m,IsLocked=false},
                new UserAccount{Id=2, FullName = "Hari", AccountNumber=456789,CardNumber =212121, CardPin=333333,AccountBalance=4000.00m,IsLocked=false},
                new UserAccount{Id=3, FullName = "Akshay", AccountNumber=098765,CardNumber =121212, CardPin=444444,AccountBalance=2000.00m,IsLocked=true},
                new UserAccount{Id=4, FullName = "pinky", AccountNumber=123789,CardNumber =131313, CardPin=555555,AccountBalance=3000.00m,IsLocked=true},

            };
        }

        public void CheckUserCardNumAndPassword()
        {
            bool isCorrectLogin = false;
            while (isCorrectLogin == false)
            {
                UserAccount inputAccount = AppScreen.UserLoginForm();
                
                foreach (UserAccount account in userAccountList)
                {
                    selectedAccount = account;
                    if (inputAccount.CardNumber.Equals(selectedAccount.CardNumber))
                    {
                        selectedAccount.TotalLogin++;

                        if (inputAccount.CardPin.Equals(selectedAccount.CardPin))
                        {
                            selectedAccount = account;

                            if (selectedAccount.IsLocked || selectedAccount.TotalLogin > 3)
                            {
                                Console.WriteLine("greater than 3 times wrong password lead to card block");
                            }
                            else
                            {
                                selectedAccount.TotalLogin = 0;
                                isCorrectLogin = true;
                                break;
                            }
                        }
                    }
                    if (isCorrectLogin == false)
                    {
                        selectedAccount.IsLocked = selectedAccount.TotalLogin == 3;
                        if (selectedAccount.IsLocked)
                        {
                            Console.WriteLine("locked");
                        }
                    }
                    Console.Clear();
                }
            }

        }

        public void Welcome()
        {
            Console.WriteLine($"Welcome back, {selectedAccount.FullName}");
            Utility.PressEnterToContinue();
        }

    }
}
