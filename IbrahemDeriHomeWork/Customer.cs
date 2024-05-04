using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IbrahemDeriHomeWork
{
    internal class Customer
    {
        public static int id = 1;
        public int number { get; }
        public String name;
        public Customer(string name)
        {
            this.number = id;
            id++;
            this.name = name;
        }
        public void addCustomer(Customer customer)
        {
            int check = -1;
            foreach(Customer item in DB.Customer)
            {
                if(item.number == customer.number)
                {
                    check++;
                     new Exception("Error this number is exist before ");
                    
                }
            }
            if (check == -1)
            {
                DB.Customer.Add(customer);
            }
           
        }
        public List<Customer> getCustomerS()
        {
            return DB.Customer;

        }
        public Customer getCustomerById(int number)
        {
           
            foreach (Customer item in DB.Customer)
            {
                if (item.number == number)
                {
                    return item;
                    
                }
            }
            throw new Exception("not found this id ");

        }
        public void deletCustomerBy(int number)
        {

            foreach (Customer item in DB.Customer)
            {
                if (item.number == number)
                {
                   DB.Customer.Remove(item);

                }
            }
            throw new Exception("not found this id ");

        }
        public void updateCustomerBy(List<Customer> customers)
        {

           DB.Customer = customers;

        }

    }
}
