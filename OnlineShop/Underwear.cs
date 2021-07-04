using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    class Underwear : Clothes
    {
		public override void PrintInfo()
		{
			Console.WriteLine("\nSoftest breatheable underwear on the market.");
		}
		public Underwear(string gender, string type, string color, string size, double price)
		{
			Gender = gender;
			Type = type;
			Color = color;
			Size = size;
			Price = price;
		}

        public Underwear()
        {
        }
    }
}
