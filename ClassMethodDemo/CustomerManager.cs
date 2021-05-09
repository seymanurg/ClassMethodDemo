using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {

        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli müşteri eklendi...");
            Console.WriteLine("---------------------------------------------");
        }
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.Name + " isimli müşteri silindi...");
            Console.WriteLine("---------------------------------------------");
        }
        public void ListCustomer(Customer[] customers)
        {
            foreach (var cus in customers)
            {
                Console.WriteLine("Müşteri Bilgileri:");
                Console.WriteLine("TC Kimlik No: " + cus.NationalId);
                Console.WriteLine("Ad: " + cus.Name);
                Console.WriteLine("Soyadı: " +  cus.Surname);
                Console.WriteLine("---------------------------------------------");
            }
        }
    }
}
