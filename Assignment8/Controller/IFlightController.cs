using Assignment8.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.Controller
{
    interface IFlightController
    {
        bool RegisterFlight(Flight flight);
        DataSet ShowAllFlights();
        bool DeleteFlight(int id);
        DataSet SearchFlight(int id);
        bool EditFlight(Flight flight);
    }
}
