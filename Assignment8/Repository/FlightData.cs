using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment8.Models;

namespace Assignment8.Repository
{
    public class FlightData : IFlightData
    {
        public bool DeleteFlight(int id)
        {
            try
            {
                string query = String.Format("DELETE FROM Flight WHERE Id = {0}",
                    id);
                DbConnection db = DbConnection.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool EditFlight(Flight flight)
        {
            try
            {
                string query = String.Format("UPDATE Flight SET Airline = '{0}', Origin = '{1}', " +
                    "Destination = '{2}', Date ='{3}' WHERE Id = {4}",
                    flight.Airline, flight.Origin, flight.Destination, flight.Date, flight.Id);
                DbConnection db = DbConnection.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet GetAllFlights()
        {
            try
            {
                DbConnection db = DbConnection.createConnection();
                string query = "select * from Flight";

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }

        public bool SaveFlight(Flight flight)
        {
            try
            {
                string query = String.Format("INSERT INTO Flight(Airline, Origin, Destination, Date) VALUES('{0}','{1}', '{2}', '{3}')",
                    flight.Airline, flight.Origin,flight.Destination, flight.Date);
                DbConnection db = DbConnection.createConnection();
                return db.createQuery(query);
            }
            catch (Exception)
            {
                return false;
            }
        }

        public DataSet SearchFlight(int id)
        {
            try
            {
                DbConnection db = DbConnection.createConnection();
                string query = 
                    String.Format("SELECT Customer.Id, Customer.Name, Flight.Airline, " +
                    "Flight.Origin, Flight.Destination,Flight.Date  FROM Customer" +
                    " JOIN Flight ON Customer.FlightId = Flight.Id WHERE Flight.Id = {0}", id);

                return db.ExecuteQuery(query);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
