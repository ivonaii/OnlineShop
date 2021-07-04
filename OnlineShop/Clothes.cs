using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    abstract class Clothes : IPrice
    {
        public string Color { get; set; }
        public string Size { get; set; }
        public string Gender { get; set; }
        public string Type { get; set; }
        public string Season { get; set; }
        public string Fabric { get; set; }
        public string Collar { get; set; }
        public string Waist { get; set; }
        public double Price { get; set; }
        public string Country { get; set; }

        public abstract void PrintInfo();
    }
}
