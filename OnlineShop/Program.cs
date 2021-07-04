using System;
using System.Collections.Generic;

namespace OnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n                     IVIKO");
            Console.ResetColor();
            Console.WriteLine("\nWelcome to the #1 Clothes Shop in Bulgaria!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n! Use code SMROFF for 20 % off your whole purchase !\n");
            Console.ResetColor();
            Console.WriteLine("\"OK\" to continue / \"Exit\" to leave.");
            Console.Write("Your choice: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string choice = Console.ReadLine();
            if (choice == "OK" || choice == "ok" || choice == "k")
            {
                Console.ResetColor();
                Console.WriteLine("_____________________________________________________");
                Console.WriteLine("\nWe stand by: ");
                //Objects printing overriden abstract method
                Underwear myUnderwear = new Underwear();
                myUnderwear.PrintInfo();
                Jackets myJacket = new Jackets();
                myJacket.PrintInfo();
                Top myTop = new Top();
                myTop.PrintInfo();
                Pants myPants = new Pants();
                myPants.PrintInfo();

                Console.WriteLine("_____________________________________________________");

                //List for underwear
                var underwear = new List<Clothes>();
                underwear.Add(new Underwear("men", "boxers", "black", "M", 15.59));
                underwear.Add(new Underwear("women", "boxers", "blue", "S", 9.99));
                underwear.Add(new Underwear("men", "briefs", "grey", "M", 19.99));

                Console.WriteLine("\nChosen underwear:\n");
                Console.WriteLine("\tGender: Type:  Color:   Size: Price(lv):");
                foreach (var Underwear in underwear)
                {
                    Console.Write("\t{0}", Underwear.Gender);
                    Console.Write("\t{0}", Underwear.Type);
                    Console.Write("\t{0}", Underwear.Color);
                    Console.Write("\t{0}", Underwear.Size);
                    Console.Write("\t{0}\n", Underwear.Price);
                }

                //List for jackets
                var jacket = new List<Clothes>();
                jacket.Add(new Jackets("women", "winter", "leather", "M", 75.59));
                jacket.Add(new Jackets("men", "autumn", "denim", "S", 45.99));

                Console.WriteLine("\nChosen jackets:\n");
                Console.WriteLine("\tGender: Season: Fabric: Size: Price(lv):");
                foreach (var Jackets in jacket)
                {
                    Console.Write("\t{0}", Jackets.Gender);
                    Console.Write("\t{0}", Jackets.Season);
                    Console.Write("\t{0}", Jackets.Fabric);
                    Console.Write("\t{0}", Jackets.Size);
                    Console.Write("\t{0}\n", Jackets.Price);
                }

                //List for tops
                var top = new List<Clothes>();
                top.Add(new Top("men", "t-shirt", "yes", "L", 19.99));
                top.Add(new Top("men", "shirt", "no", "L", 25.59));
                top.Add(new Top("men", "sweater", "yes", "M", 35.99));
                top.Add(new Top("women", "blouse", "no", "XS", 15.99));

                Console.WriteLine("\nChosen tops:\n");
                Console.WriteLine("\tGender: Type:   Collar: Size: Price(lv):");
                foreach (var Top in top)
                {
                    Console.Write("\t{0}", Top.Gender);
                    Console.Write("\t{0}", Top.Type);
                    Console.Write("\t{0}", Top.Collar);
                    Console.Write("\t{0}", Top.Size);
                    Console.Write("\t{0}\n", Top.Price);
                }

                //List for pants
                var pants = new List<Clothes>()
                {
                    new Pants("women", "cotton", "brown", "32", 15.59),
                    new Pants("men", "denim", "black", "40", 20.99),
                    new Pants("women", "satin", "nude", "32", 55.95),
                    new Pants("women", "leather", "black", "29", 30.99)

                };


                Console.WriteLine("\nChosen pants:\n");
                Console.WriteLine("\tGender: Fabric: Color:  Waist:  Price(lv):");
                foreach (var Pants in pants)
                {
                    Console.Write("\t{0}", Pants.Gender);
                    Console.Write("\t{0}", Pants.Fabric);
                    Console.Write("\t{0}", Pants.Color);
                    Console.Write("\t{0}", Pants.Waist);
                    Console.Write("\t{0}\n", Pants.Price);
                }

                //List gathering price values from the other lists
                var price = new List<IPrice>();
                price.AddRange(pants);
                price.AddRange(underwear);
                price.AddRange(jacket);
                price.AddRange(top);

                //adding price values together
                double totalPrice = 0;
                foreach (var Price in price)
                {
                    totalPrice += Price.Price;
                }
                //Cut to the second number after the dot
                totalPrice = Convert.ToDouble(String.Format("{0:0.00}", totalPrice));
                Console.WriteLine("\n_____________________________________________________");
                Console.Write("\nDo you want to use current discount code (Y/N): ");
                Console.ForegroundColor = ConsoleColor.Blue;
                string discountCodeChoice = Console.ReadLine();
                Console.ResetColor();
                if (discountCodeChoice == "Yes" || discountCodeChoice == "yes" || discountCodeChoice == "Y" || discountCodeChoice == "y")
                {
                    Console.Write("\nEnter code: ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    string discountCode = Console.ReadLine();
                    Console.ResetColor();
                    if (discountCode == "SMROFF")
                    {
                        double discount = totalPrice * 0.2;
                        discount = Convert.ToDouble(String.Format("{0:0.00}", discount));
                        double afterDiscount = totalPrice - discount;
                        afterDiscount = Convert.ToDouble(String.Format("{0:0.00}", afterDiscount));
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("_____________________________________________________\n");
                        Console.WriteLine("                                        {0} lv.", totalPrice);
                        Console.WriteLine("                                      -  {0} lv.", discount);
                        Console.WriteLine("                           Total price: {0} lv.", afterDiscount);
                        Console.WriteLine("_____________________________________________________");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect code.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("_____________________________________________________\n");
                        Console.WriteLine("                           Total price: {0} lv.", totalPrice);
                        Console.WriteLine("_____________________________________________________");
                        Console.ResetColor();
                    }
                }
                else
                {
                    totalPrice = Convert.ToDouble(String.Format("{0:0.00}", totalPrice));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("_____________________________________________________\n");
                    Console.WriteLine("                           Total price: {0} lv.", totalPrice);
                    Console.WriteLine("_____________________________________________________");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nThank you for visiting.");  
                Console.ResetColor();
                Environment.Exit(0);
            }

            Bye();

        }
        private static void Bye()
        {
            Console.WriteLine("\nBYE! :) Have a nice day!");
        }
        
    }
}
