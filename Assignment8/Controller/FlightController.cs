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
    public class FlightController : IFlightController
    {
        IFlightData data;

        public FlightController()
        {
            data = new FlightData();
        }

        public bool DeleteFlight(int id)
        {
            return data.DeleteFlight(id);
        }

        public bool EditFlight(Flight flight)
        {
            return data.EditFlight(flight);
        }

        public bool RegisterFlight(Flight flight)
        {
            return data.SaveFlight(flight);
        }

        public DataSet SearchFlight(int id)
        {
            return data.SearchFlight(id);
        }

        public DataSet ShowAllFlights()
        {
            return data.GetAllFlights();
        }
    }
}
