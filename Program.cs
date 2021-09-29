using System;
using VirtualAbstractKeyword.Concrete;

namespace VirtualAbstractKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Delete();
            Console.WriteLine(customerManager.Save()); 
        }
    }
}
