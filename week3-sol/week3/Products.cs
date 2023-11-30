using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week3
{
    internal class Products
    {
        public static int id;
        private int Pro_id;

        public const double discountCosnt = 0.15;
        public string name;
        public string description;
        public double price;
        public int quantity;
        
        public Products() { }
        public Products(string name,string description , double price, int quantity,bool discount) 
        {
            id += 1;
            this.Pro_id = id;
            this.name = name;
            this.description = description;
            this.price = (discount? price * (1 + discountCosnt):price) ;
            this.quantity = quantity;
        }
        public void displayInformation()
        {
            Console.WriteLine($"product ID: {this.Pro_id}");
            Console.WriteLine($"Product Name: {this.name}\n" +
                $"description of The Produt: {this.description}\n" +
                $"Product`s price: {this.price} \n" +
                $"product Quantity: {this.quantity}\n");
        }
    }
}
