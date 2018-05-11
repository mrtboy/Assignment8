using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment8.Models;

namespace Assignment8.Repository
{
    public class CustomerData : ICustomerData
    {
        public bool DeleteCustomer(int id)
        {
            try
            {
                string query = String.Format("DELETE FROM Customer WHERE Id = {0}",
                    id);
                DbConnection db = DbConnection.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditCustomer(Customer customer)
        {
            try
            {
                string query = String.Format("UPDATE Customer SET Name = '{0}',FlightId = {1}  Where Id = {2}",
                    customer.Name, customer.FlightId, customer.Id);
                DbConnection db = DbConnection.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet GetAllCustomers()
        {
            try
            {
                DbConnection db = DbConnection.createConnection();
                string query = "select * from Customer";

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool SaveCustomer(Customer customer)
        {
            try
            {
                string query = String.Format("INSERT INTO Customer(Name, FlightId) VALUES('{0}',{1})",
                    customer.Name, customer.FlightId);
                DbConnection db = DbConnection.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet SearchCustomer(int id)
        {
            try
            {
                DbConnection db = DbConnection.createConnection();
                string query =
                    String.Format("SELECT Customer.Name, Flight.Airline, Flight.Origin, Flight.Destination," +
                    " Flight.Date,Customer.Id FROM Customer JOIN Flight ON Customer.FlightId = Flight.Id WHERE Customer.Id = {0}", id);

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
