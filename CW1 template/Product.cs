using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CW1_template
{
    class Product
    {
        private int ID;
        private string Name;
        private double Price;
        private int Quantity;
        private static int Count;

        public int id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string name
        {
            get { return Name; }
            set { Name = value; }
        }
        public double price
        {
            get { return Price; }
            set { Price = value; }
        }
        public int quantity
        {
            get { return Quantity; }
            set { Quantity = value; }
        }
        public Product(int ProductId, string ProductName, double ProductPrice, int ProductQuantity)
        {
            this.ID = ProductId;
            this.Name = ProductName;
            this.Price = ProductPrice;
            this.Quantity = ProductQuantity;
            Count++;
        }
        public void DisplayProductInfo()
        {
            Console.WriteLine($"Product ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Price: {Price}");
            Console.WriteLine($"Quantity: {Quantity}");
            Console.WriteLine($"Count: {Count}");
            Console.WriteLine();
        }
        public void CheapestProduct()
        {
            double p1 = 712.50;
            double p2 = 1300.50;
            if (p1 < p2)
            {
                Console.WriteLine("The cheapest product is the Smartphone");
            }
            else
            {
                Console.WriteLine("The cheapest product is the Tablet");
               
            }
        }
    }
}

        
