using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment8.Models;

namespace Assignment8.Repository
{
    interface IFlightData
    {
        bool SaveFlight(Flight flight);
        DataSet GetAllFlights();
        bool DeleteFlight(int id);
        DataSet SearchFlight(int id);
        bool EditFlight(Flight flight);
    }
}
