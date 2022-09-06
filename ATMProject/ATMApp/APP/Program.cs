using ATMApp.UI;
using System;

namespace ATMApp.APP
{
    public class Program
    {
        static void Main(string[] args)
        {
                AppScreen.Welcome();
                Atmapp atmApp = new Atmapp();
                atmApp.InitializeData();
                atmApp.CheckUserCardNumAndPassword();
                atmApp.Welcome();
        }
    }
}
