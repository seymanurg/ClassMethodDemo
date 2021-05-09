using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.Name = "Keziban";
            customer1.Surname = "Karabaş";
            customer1.NationalId = "44565659865";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.Name = "Kardelen";
            customer2.Surname = "Bağdat";
            customer2.NationalId = "57445455";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.Name = "Elif";
            customer3.Surname = "Ateş";
            customer3.NationalId = "455754542478784";

            Customer customer4 = new Customer();
            customer4.Id = 4;
            customer4.Name = "Sevgi";
            customer4.Surname = "Sancaktutan";
            customer4.NationalId = "754454545";

            Customer customer5 = new Customer();
            customer5.Id = 5;
            customer5.Name = "Ayşegül";
            customer5.Surname = "Deniz";
            customer5.NationalId = "75431846656";

            Customer[] customers = new Customer[] { customer1, customer2, customer3, customer4, customer5 };

            CustomerManager manager = new CustomerManager();
            manager.AddCustomer(customer1);
            manager.AddCustomer(customer2);
            manager.AddCustomer(customer3);
            manager.AddCustomer(customer4);
            manager.AddCustomer(customer5);

            manager.ListCustomer(customers);

            manager.DeleteCustomer(customer4);
        }
    }
}
