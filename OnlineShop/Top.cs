using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    class Top : Clothes
    {
        public override void PrintInfo()
        {
            Console.WriteLine("Highest quality tops in the country.");
        }
        public Top(int index, string gender, string type, string collar, string size, double price)
        {
            Index = index;
            Gender = gender;
            Type = type;
            Collar = collar;
            Size = size;
            Price = price;
        }

        public Top()
        {
        }
    }
}
