using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MileStone3_FlightBookingSystem
{
    internal class Passenger
    {

        public int PassengerId { get; set; }
        public string Name { get; set; }

        public Passenger(int passengerId, string name)
        {
            PassengerId = passengerId;
            Name = name;
        }
    }
}
