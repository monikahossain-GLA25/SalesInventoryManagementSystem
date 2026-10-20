using System;
using System.Collections.Generic;
using System.Text;

namespace SalesInventoryManagementSystem.Models
{
    public class User
    {

        public int ID { get; set; }

        public string Name { get; set; }

        public string Email { get; set; }

        public User(int id , string name , string email)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
        }

        protected void UserDetails(string message)
        {
            Console.WriteLine($"User Name: {Name}");
        }
    }
}
