using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SalesInventoryManagementSystem.Models
{
    public class Customer
    {
       
        public int ID { get; set; }

private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty.");
                }
                _name = value;
            }
        }

        public string Email { get; set; }

        public string Phone { get; set; }

        public DateTime RegisteredDate { get;}

        public Customer()
        {
            RegisteredDate = DateTime.Now;
        }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
            RegisteredDate = DateTime.Now;
        }
        public Customer(string name, string email, string phone)
        {
            Name = name;
            Email = email;
            Phone = phone;
            RegisteredDate = DateTime.Now;
        }
    }
}
