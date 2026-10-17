using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SalesInventoryManagementSystem.Models
{
    internal class Order
    {
    
        public int Id { get; set; }
   
        public string Name { get; set; }
  
        public string Email { get; set; }
      
        public string Phone { get; set; }
        
        public DateTime RegisteredDate { get; set; }

        public const decimal VATRate = 0.15m;

        public decimal CalculateSubTotal(int quantity, int unitPrice)
        {
            var subttotal = quantity * unitPrice;
            return subttotal;
        }
        public decimal CalculateVat(decimal subTotal, decimal vatRate)
        {
            var totalVat = subTotal * vatRate;
            return totalVat;
        }

        public decimal CalculateGrandTotal(decimal subTotal, decimal vat)
        {
            var GrandTotal = subTotal + vat;
            return GrandTotal;
        }
        public void DisplayOrder()
        {
            Console.WriteLine($"Order ID: {Id}");
            Console.WriteLine($"Customer Name: {Name}");
            Console.WriteLine($"Customer Email: {Email}");
            Console.WriteLine($"Customer Phone: {Phone}");
            Console.WriteLine($"Registered Date: {RegisteredDate}");
        }
    }
}
