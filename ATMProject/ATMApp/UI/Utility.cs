using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ATMApp.UI
{
    public class Utility
    {
        public static void PressEnterToContinue()
        {
            Console.WriteLine("\n\nPress Enter to continue...\n");
            Console.ReadLine();
        }
    }
}
