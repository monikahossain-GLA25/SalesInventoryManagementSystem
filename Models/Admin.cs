using System;
using System.Collections.Generic;
using System.Text;

namespace SalesInventoryManagementSystem.Models
{
    public class Admin : User
    {
        public Admin(int id, string name, string email) : base(id, name, email)
        {
        }
        public void ManageProducts()
        {
            Console.WriteLine("The product is managed.");
        }

        protected void AdminDisplay()
        {
            UserDetails("Admin action executed.");
        }
    }
}
