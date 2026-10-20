using System;

namespace SalesInventoryManagementSystem.Models
{
    public class User
    {
        public int Id { get; set; }

        private string _name = string.Empty;

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
                    throw new ArgumentException(
                        "Name cannot be empty.");
                }

                _name = value;
            }
        }

        public string Email { get; set; } = string.Empty;

        public User(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
        }

       
        protected string GetBasicDetails()
        {
            return $"User ID: {Id}\n" +
                   $"Name: {Name}\n" +
                   $"Email: {Email}";
        }
    }
}