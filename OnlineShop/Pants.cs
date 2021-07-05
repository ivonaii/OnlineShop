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
        public Pants(int index, string gender, string fabric, string color, string waist, double price)
        {
            Index = index;
            Gender = gender;
            Fabric = fabric;
            Color = color;
            Waist = waist;
            Price = price;
        }
        public Pants() {}
    }
}
