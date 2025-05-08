using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstClass
{
    internal class Product
    {
        private string name;
        private double price;
        private int quantity;

        public Product(string name, double price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        public void PrintProduct()
        {
            Console.WriteLine($"{name}: price {price:C}: {quantity} pcs");
        }
    }
}
