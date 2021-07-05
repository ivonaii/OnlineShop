using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineShop
{
    interface IPrice
    {
        public int Index { get; set; }
        public double Price { get; set; }
    }
}
