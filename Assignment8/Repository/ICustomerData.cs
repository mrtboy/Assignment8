using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment8.Models;
namespace Assignment8.Repository
{
    interface ICustomerData
    {
        bool SaveCustomer(Customer customer);
        DataSet GetAllCustomers();
        bool DeleteCustomer(int id);
        DataSet SearchCustomer(int id);
        bool EditCustomer(Customer customer);
    }
}
