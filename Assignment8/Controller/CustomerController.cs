using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment8.Models;
using Assignment8.Repository;

namespace Assignment8.Controller
{
    public class CustomerController : ICustomerController
    {
        ICustomerData data;
        public CustomerController()
        {
            data = new CustomerData();
        }

        public bool DeleteCustomer(int id)
        {
            return data.DeleteCustomer(id);
        }

        public bool EditCustomer(Customer customer)
        {
            return data.EditCustomer(customer);
        }

        public bool RegisterCustomer(Customer customer)
        {
            return data.SaveCustomer(customer);
        }

        public DataSet SearchCustomer(int id)
        {
            return data.SearchCustomer(id);
        }

        public DataSet ShowAllCustomers()
        {
            return data.GetAllCustomers();
        }
    }
}
