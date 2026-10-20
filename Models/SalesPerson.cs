using System;
using System.Collections.Generic;
using System.Text;

namespace SalesInventoryManagementSystem.Models
{
    public class SalesPerson : User
    {
        public int EmployeeCode { get; set; }

        public SalesPerson(int id, string name, string email, int employeeCode)
     : base(id, name, email)
        {
            EmployeeCode = employeeCode;
        }
        public void CreateOrder()
        {
            Console.WriteLine("The Order is Created.");
        }
        //Use the inherited protected helper to display the common user information.
        public void PrintSalesDetails()
        {
            GetBasicDetails();
        }
    }
}
