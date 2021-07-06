using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    class Error
    {
        public static void ErrorFunction()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou entered incorrect format!" +
                "\nPlease enter again!");
            Console.ReadKey();
            Console.ResetColor();
        }
    }
}
