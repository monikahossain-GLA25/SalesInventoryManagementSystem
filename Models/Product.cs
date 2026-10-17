using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SalesInventoryManagementSystem.Models
{
    internal class Product
    {
        private decimal _price;
        public decimal price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
                _price = value;
            }
        }
        public int Id { get; set; }

        public string Name { get; set; }

        public int Code { get; set; }

        const decimal VATRate = 0.15m;

        private int _stock;
        public int Stock
        {
            get
            {
                return _stock;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Stock cannot be negative.");
                }
                _stock = value;
            }
        }

        private readonly DateTime CreateDate;

        public Product()
        {
            
        }
        public Product(string name, decimal price)

        {
            this.Name = name;
            this.price = price;

            Console.WriteLine("The product is " + name + "Whoose price is " + price);
        }

        public Product(int id, string name, int code, decimal price, int stock)
        {
            this.Id = id;
            this.Name = name;
            this.Code = code;
            this.price = price;
            this.Stock = stock;
        }

         public int AddStock(int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentException("Quantity cannot be negative.");
            }
            Stock += quantity;
            return Stock;
        }

        public int RemoveStock(int quantity)
        {
            if (quantity < 0)
            {
                throw new ArgumentException("Quantity cannot be negative.");
            }
            if (quantity > Stock)
            {
                throw new InvalidOperationException("Not enough stock available.");
            }
            Stock -= quantity;
            return Stock;
        }
        public decimal CalculatePriceWithVat()
        {
            return price + (price * VATRate);
        }

        public void DisplayProduct()
        {
            Console.WriteLine($"Product ID: {Id}");
            Console.WriteLine($"Product Name: {Name}");
            Console.WriteLine($"Product Code: {Code}");
            Console.WriteLine($"Product Price: {price:C}");
            Console.WriteLine($"Product Stock: {Stock}");
            Console.WriteLine($"Price with VAT: {CalculatePriceWithVat():C}");
        }
    }
}
