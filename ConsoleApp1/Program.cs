using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Interface1 emp = new Employee();
            emp.setdata();
            emp.getdata();
            Interface1 pro = new Product();
            pro.setdata();
            pro.getdata();


        }
    }
}
