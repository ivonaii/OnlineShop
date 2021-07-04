using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    class Pants : Clothes
    {
        public override void PrintInfo()
        {
            Console.WriteLine("P-riceless. A-wesome. N-ew. T-rendy. S-leek. = PANTS");

        }
        public Pants(string gender, string fabric, string color, string waist, double price)
        {
            Gender = gender;
            Fabric = fabric;
            Color = color;
            Waist = waist;
            Price = price;
        }
        public Pants() {}
    }
}
