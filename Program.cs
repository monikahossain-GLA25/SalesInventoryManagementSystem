using SalesInventoryManagementSystem.Models;

namespace SalesInventoryManagementSystem {

   class Program
    {
        public static void Main(string[] args)
        {
            Order objOrder = new Order();
            objOrder.DisplayOrder();

            Customer objCustomer = new Customer("Monika" , "Monikahossain25@gmail.com");

            Product objProduct1 = new Product("Laptop", 42789);
            var ActualPrice =     objProduct1.CalculatePriceWithVat();
            Console.WriteLine(ActualPrice);

            var ActualVat = objProduct1.CalculatePriceWithVat();
            Console.WriteLine(ActualVat);



            Product objProduct2 = new Product("Iphone", 1298304);
          var stock1 =  objProduct2.AddStock(12);
            Console.WriteLine(stock1);

            Product objProduct3 = new Product("OnePlus", 650000);


            Product laptop = new Product("Laptop", 42789);
           var stockLaptop =  laptop.AddStock(12000);
            Console.WriteLine(stockLaptop);


            Product monitor = new Product("Monitor", 20000);
            var removeStock = monitor.RemoveStock(2);
            Console.WriteLine(removeStock);


            Product keyboard = new Product("Keyboard", 1000);
        }
    }


}
