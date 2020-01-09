using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFleet
{
    class Bus:Vehicle
    {
        //properties
        public int Seats { get; private set; }
        public static double Multiplier { get; set; }

        //constructors
        public Bus(string id,string registrationNumber,int manufacturingYear,double fuelConsumption,int seats) : base(id, registrationNumber, manufacturingYear, fuelConsumption)
        {
            this.Seats = seats;
        }
        //METHODS
        //Calculates the rent fee of the bus
        public override int RentFee()
        {
            return (int)(base.RentFee() + Seats * Multiplier);

        }
        public override string ToString()
        {
            return base.ToString() + "\n\tseats: "+ Seats;
        }
    }
}
