
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Employee:Interface1
    {
        int id;
        string name;
        string Department;

        public void getdata()
        {
            Console.WriteLine("Employee Id = " + id);
            Console.WriteLine("Employee Name = " + name);
            Console.WriteLine("Employee Department = " + Department);
        }

        public void setdata()
        {
            Console.WriteLine("Enter Employee Id");
            id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Employee Name");
            name = Console.ReadLine();
            Console.WriteLine("Enter Employee Department");
            Department = Console.ReadLine();
        }

        public void storedata()
        {
            
        }
    }
}
