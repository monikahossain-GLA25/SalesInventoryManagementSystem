using System;
using System.Collections.Generic;
using System.Text;

namespace SalesInventoryManagementSystem.Models
{
    public class SalesPerson : User
    {
        public int EmployeeCode { get; set; }

        public SalesPerson(int id, string name, string email) : base(id, name, email)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
        }
        public void CreateOrder()
        {
            Console.WriteLine("The Order is Created.");
        }
        //Use the inherited protected helper to display the common user information.
        public void PrintSalesDetails()
        {
            UserDetails("Nabil" , 2 , "nabilmkt093au@gmail.com");
        }
    }
}
