using System;
using System.Collections.Generic;

namespace OnlineShop
{
    class Program
    {
        static void Main(string[] args)
        {
            Slogan();

            Console.Write("Your choice: ");
            Console.ForegroundColor = ConsoleColor.Blue;
            string choice = Console.ReadLine();

            Underwear myUnderwear = new Underwear();
            Jackets myJacket = new Jackets();
            Pants myPants = new Pants();
            Top myTop = new Top();

            List<Clothes> basket = new List<Clothes>();

            if (choice.ToLower() == "ok" || choice == "k")
            {
                Console.ResetColor();
                Console.WriteLine("_________________________________________________________");
                Console.WriteLine("\nWe stand by: ");

                //Objects printing overriden abstract method
                
                myUnderwear.PrintInfo();             
                myJacket.PrintInfo();                
                myTop.PrintInfo();            
                myPants.PrintInfo();
                
                

                Console.WriteLine("_________________________________________________________");

                //List for underwear
                var underwear = new List<Clothes>()
                {
                    new Underwear(0, "men", "boxers", "black", "M", 15.55),
                    new Underwear(1, "women", "boxers", "blue", "S", 9.99),
                    new Underwear(2, "men", "briefs", "grey", "M", 19.25),
                    new Underwear(3, "women", "bikini", "pink", "XS", 12.89),
                    new Underwear(4, "men", "briefs", "black", "XL", 7.95),
                    new Underwear(5, "women", "brazil", "purple", "S", 10.49)
                };

                Console.WriteLine("\n\t\tProducts in stock");
                Console.WriteLine("\nUnderwear:\n");
                Console.WriteLine("\tNumber: Gender: Type:   Color:  Size:  Price(lv):");
                foreach (var Underwear in underwear)
                {
                    Console.Write("\t{0}", Underwear.Index);
                    Console.Write("\t{0}", Underwear.Gender);
                    Console.Write("\t{0}", Underwear.Type);
                    Console.Write("\t{0}", Underwear.Color);
                    Console.Write("\t{0}", Underwear.Size);
                    Console.Write("\t{0}\n", Underwear.Price);
                }

                
                                                                               
                //List for jackets
                var jacket = new List<Clothes>()
                {
                    new Jackets(0, "women", "winter", "leather", "M", 75.59),
                    new Jackets(1, "men", "autumn", "denim", "S", 45.99),
                    new Jackets(2, "women", "autumn", "denim", "L", 65.99),
                    new Jackets(3, "women", "summer", "polyes.", "XS", 35.95),
                    new Jackets(4, "men", "spring", "cotton", "M", 89.75),
                    new Jackets(5, "men", "summer", "elast.", "XL", 56.45)
                };

                Console.WriteLine("\nJackets:\n");
                Console.WriteLine("\tNumber: Gender: Season: Fabric: Size:   Price(lv):");
                foreach (var Jackets in jacket)
                {
                    Console.Write("\t{0}", Jackets.Index);
                    Console.Write("\t{0}", Jackets.Gender);
                    Console.Write("\t{0}", Jackets.Season);
                    Console.Write("\t{0}", Jackets.Fabric);
                    Console.Write("\t{0}", Jackets.Size); 
                    Console.Write("\t{0}\n", Jackets.Price);
                }

                //List for tops
                var top = new List<Clothes>()
                {
                    new Top(0, "men", "t-shirt", "yes", "L", 19.99),
                    new Top(1, "men", "shirt", "no", "L", 25.55),
                    new Top(2, "men", "sweater", "yes", "M", 35.99),
                    new Top(3, "women", "blouse", "no", "XS", 15.35),
                    new Top(4, "women", "linen", "no", "XL", 25.79),
                    new Top(5, "women", "knit", "yes", "S", 45.45)
                };

                Console.WriteLine("\nTops:\n");
                Console.WriteLine("\tNumber: Gender: Type:   Collar: Size:   Price(lv):");
                foreach (var Top in top)
                {
                    Console.Write("\t{0}", Top.Index);
                    Console.Write("\t{0}", Top.Gender);
                    Console.Write("\t{0}", Top.Type);
                    Console.Write("\t{0}", Top.Collar);
                    Console.Write("\t{0}", Top.Size);
                    Console.Write("\t{0}\n", Top.Price);
                }

                //List for pants
                var pants = new List<Clothes>()
                {
                    new Pants(0, "women", "cotton", "brown", "32", 15.59),
                    new Pants(1, "men", "denim", "black", "40", 20.99),
                    new Pants(2, "women", "satin", "nude", "32", 55.95),
                    new Pants(3, "women", "leather", "black", "29", 30.99),
                    new Pants(4, "men", "denim", "blue", "42", 25.49),
                    new Pants(5, "women", "polyes.", "white", "28", 60.65)
                };

                Console.WriteLine("\nPants:\n");
                Console.WriteLine("\tNumber: Gender: Fabric: Color:  Waist:  Price(lv):");
                foreach (var Pants in pants)
                {
                    Console.Write("\t{0}", Pants.Index);
                    Console.Write("\t{0}", Pants.Gender);
                    Console.Write("\t{0}", Pants.Fabric);
                    Console.Write("\t{0}", Pants.Color);
                    Console.Write("\t{0}", Pants.Waist);
                    Console.Write("\t{0}\n", Pants.Price);
                }

                Console.WriteLine("\n__________________________________________________________");
                Console.WriteLine("\n\t\tChoose your style");

                string command = " ";
                while (command != "End")
                {
                    
                    Console.Write("\nEnter category: ");
                    string items = Console.ReadLine();
                    Console.WriteLine("Enter product number (type -1 when you are done with a category): ");

                    if (items.ToLower() == "underwear")
                    {
                        int index = 0;
                        while (true)
                        {
                            index = int.Parse(Console.ReadLine());

                            if (index < 0)
                            {
                                break;
                            }

                            basket.Add(underwear[index]);
                        }
                    }
                    else if (items.ToLower() == "jackets")
                    {
                        int index = 0;
                        while (true)
                        {
                            index = int.Parse(Console.ReadLine());

                            if (index < 0)
                            {
                                break;
                            }

                            basket.Add(jacket[index]);
                        }
                    }
                    else if (items.ToLower() == "tops")
                    {
                        int index = 0;
                        while (true)
                        {
                            index = int.Parse(Console.ReadLine());

                            if (index < 0)
                            {
                                break;
                            }

                            basket.Add(top[index]);
                        }
                    }
                    else if (items.ToLower() == "pants")
                    {
                        int index = 0;
                        while (true)
                        {
                            index = int.Parse(Console.ReadLine());
                            if (index < 0)
                            {
                                break;
                            }

                            basket.Add(pants[index]);
                        }
                    }

                    Console.Write("\nIf you want to continue shopping press \"Enter\"." +
                        "\nIf you want to finish shopping enter \"End\".\n");
                    Console.Write("\nEnter command: ");
                    command = Console.ReadLine();
                }

                Console.WriteLine("\nChosen items: ");

                double totalPrice = 0;
                foreach (var Basket in basket)
                {
                    Console.WriteLine($"\t{Basket.Gender}  \t{Basket.Price}");
                    totalPrice += Basket.Price;
                }

                Console.WriteLine("\t__________________\n");
                Console.WriteLine("\t\t{0:0.00} lv.",totalPrice);

                /*
                //List gathering price values from the other lists
                var price = new List<IPrice>();
                price.AddRange(pants);
                price.AddRange(underwear);
                price.AddRange(jacket);
                price.AddRange(top);

                //adding price values together
                
                foreach (var Price in price)
                {
                    totalPrice += Price.Price;
                }*/

                //Cut to the second number after the dot
                totalPrice = Convert.ToDouble(String.Format("{0:0.00}", totalPrice));

                Console.WriteLine("\n_________________________________________________________");
                Console.Write("\nDo you want to use current discount code (Y/N): ");
                Console.ForegroundColor = ConsoleColor.Blue;

                string discountCodeChoice = Console.ReadLine();
                Console.ResetColor();

                if (discountCodeChoice.ToLower() == "yes" || discountCodeChoice.ToLower() == "y")
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
                        Console.WriteLine("_________________________________________________________\n");
                        Console.WriteLine("                                            {0} lv.", totalPrice);
                        Console.WriteLine("                                           - {0} lv.", discount);
                        Console.WriteLine("                               Total price: {0} lv.", afterDiscount);
                        Console.WriteLine("_________________________________________________________");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.WriteLine("Incorrect code.");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("_________________________________________________________\n");
                        Console.WriteLine("                               Total price: {0} lv.", totalPrice);
                        Console.WriteLine("_________________________________________________________");
                        Console.ResetColor();
                    }
                }
                else
                {
                    totalPrice = Convert.ToDouble(String.Format("{0:0.00}", totalPrice));
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("_________________________________________________________\n");
                    Console.WriteLine("                               Total price: {0} lv.", totalPrice);
                    Console.WriteLine("_________________________________________________________");
                    Console.ResetColor();
                }
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\nThank you for visiting.");  
                Console.ResetColor();
                Copyright myCopyright = new Copyright();
                myCopyright.PrintCopyright();
                Environment.Exit(0);
            }
            Bye();
        }

        private static void Slogan()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n                     IVIKO");
            Console.ResetColor();
            Console.WriteLine("\nWelcome to the #1 Clothes Shop in Bulgaria!");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n! Use code SMROFF for 20 % off your whole purchase !\n");
            Console.ResetColor();
            Console.WriteLine("\"OK\" to continue / \"Exit\" to leave.");
        }

        private static void Bye()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("\n                     Have a nice day!");
            Console.ResetColor();
            Copyright myCopyright = new Copyright();
            myCopyright.PrintCopyright();
        }
    }
}
