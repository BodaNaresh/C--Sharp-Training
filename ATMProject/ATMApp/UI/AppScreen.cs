using ATMApp.Model;
using System;
using System.Collections.Generic;
using System.Text;


namespace ATMApp.UI
{
    public class AppScreen
    {
        public static void Welcome()
        {
            
            Console.Clear();
           
            Console.Title = "My ATM App";
            Console.ForegroundColor = ConsoleColor.White;

          
            Console.WriteLine("\n\n-----------------Welcome to My ATM App-----------------\n\n");
            
            Console.WriteLine("Please insert your ATM card");
            Console.WriteLine("Note: Actual ATM machine will accept and validate" +
                " a physical ATM card, read the card number and validate it.");
            Utility.PressEnterToContinue();
        }

        public static UserAccount UserLoginForm()
        {
            UserAccount tempUserAccount = new UserAccount();
            Console.WriteLine("Enter ur acc number");
            tempUserAccount.CardNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter ur pin number");
            tempUserAccount.CardPin = int.Parse(Console.ReadLine());
            return tempUserAccount;
        }

      
    }
}
