using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment8.Models
{
    public class Flight
    {
        public int Id { get; set; }
        public string Airline { get; set; }
        public string Origin { get; set; }
        public string Destination { get; set; }
        public DateTime Date { get; set; }

        public Flight()
        {
        }

        public Flight(int id, string airline, string origin, string destination, DateTime date)
        {
            Id = id;
            Airline = airline;
            Origin = origin;
            Destination = destination;
            Date = date;
        }

        public Flight(string airline, string origin, string destination, DateTime date)
        {
            Airline = airline;
            Origin = origin;
            Destination = destination;
            Date = date;
        }
    }
}
