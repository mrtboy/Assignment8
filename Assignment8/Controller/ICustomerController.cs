using Assignment8.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.Controller
{
    public interface ICustomerController
    {
        bool RegisterCustomer(Customer customer);
        DataSet ShowAllCustomers();
        bool DeleteCustomer(int id);
        DataSet SearchCustomer(int id);
        bool EditCustomer(Customer customer);
    }
}
