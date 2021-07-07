using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    class Error
    {
        public static void ErrorIntFormat()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou entered string format!" +
                "\nPress \"Enter\" to continue and enter int format.");
            Console.ReadLine();
            Console.ResetColor();
        }

        public static void ErrorFunction()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nYou did something wrong!" +
                "\nPress \"Enter\" to continue.");
            Console.ReadLine();
            Console.ResetColor();
        }
    }
}
