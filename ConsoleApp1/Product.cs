using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Product : Interface1
    {
        int id;
        string productName;
        int productPrice;

        public void getdata()
        {
            Console.WriteLine("Product Id = " + id);
            Console.WriteLine("Product Name = " + productName);
            Console.WriteLine("Product Price = " + productPrice);
        }

        public void setdata()
        {
            Console.WriteLine("Enter Product Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Product Name");
            productName = Console.ReadLine();
            Console.WriteLine("Enter Product Price");
            productPrice = int.Parse(Console.ReadLine());
        }

        public void storedata()
        {
           
        }
    }


}
