using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFleet
{
    class Truck:Vehicle
    {
        public double CarryingCapacity { get; private set; }
        public static double Multiplier { get; set; }

        //constructors
        public Truck(string id,string registrationNumber,int manufacturingYear,double fuelConsumption,double carryingCapacity) : base(id, registrationNumber, manufacturingYear, fuelConsumption)
        {
            this.CarryingCapacity = carryingCapacity;
        }
        //methods
        //calculates the rent fee of the truck
        public override int RentFee()
        {
            return (int)(base.RentFee()+CarryingCapacity*Multiplier);
        }
        public override string ToString()
        {
            return base.ToString() + "\n\tcarrying capacity:" + CarryingCapacity + "ton";
        }
    }
}
