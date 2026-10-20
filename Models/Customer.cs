using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace SalesInventoryManagementSystem.Models
{
    public class Customer : User
    {
       
//        public int ID { get; set; }

//private string _name;
//        public string Name
//        {
//            get
//            {
//                return _name;
//            }
//            set
//            {
//                if (string.IsNullOrWhiteSpace(value))
//                {
//                    throw new ArgumentException("Name cannot be empty.");
//                }
//                _name = value;
//            }
//        }

//        public string Email { get; set; }

        public string Phone { get; set; }

        //private readonly DateTime CreateDate;


        public DateTime RegisteredDate { get;}

   

        public Customer(int Id, string name, string email) : base(Id,name,email)
        {
            ID = Id;
            Name = name;
            Email = email;
          
        }
        
    }
}
