using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    class Jackets : Clothes
    {
		
		public override void PrintInfo()
		{
			Console.WriteLine("Unique jackets for every season.");
		}
		public void PrintCountry(string country)
		{
			Country = country;
			Console.WriteLine("Made in: {0}", Country);
		}
		public Jackets(int index, string gender, string season, string fabric, string size, double price)
		{
			Index = index;
			Gender = gender;
			Season = season;
			Fabric = fabric;
			Size = size;
			Price = price;
		}

        public Jackets()
        {
        }
    }
}
