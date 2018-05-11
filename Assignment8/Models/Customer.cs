using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FlightId { get; set; }

        public Customer()
        {
        }

        public Customer(int id, string name, int flightId)
        {
            Id = id;
            Name = name;
            FlightId = flightId;
        }

        public Customer(string name, int flightId)
        {
            Name = name;
            FlightId = flightId;
        }
    }
}
