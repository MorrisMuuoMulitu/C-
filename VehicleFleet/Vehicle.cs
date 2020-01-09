using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleFleet
{
    abstract class Vehicle
    {
        //In Abstract class no instantiation
        //properties
        public string Id { get; private set; }
        public string RegistrationNumber { get; set; }
        public int ManufacturingYear { get; private set; }
        public double FuelConsumption { get; set; }

        public double TravelledKM { get; private set; }
        public int CurrentCost { get; private set; }
        public bool IsFree { get; private set; }

        public static int CurrentYear { get;  set; }
        public static int BaseFee { get; set; }
        public static double  ProfitMargin { get; set; }

        //constructor
        public Vehicle(string id,string registrationNumber,int manufacturingYear,double fuelConsumption)
        {
            this.Id = id;
            this.FuelConsumption = fuelConsumption;
            this.ManufacturingYear = manufacturingYear;
            this.RegistrationNumber = registrationNumber;
            this.IsFree = true;
        }
        //methods
        //Calculates the age of the vehicle
        public int Age()
        {
            return CurrentYear - ManufacturingYear;
        }
        /**
         * Increase the number of travelled km with the current distance.
         * Calculate the price of current transport
         * Set that the vehicle is not free
         * Get information about the success of the transport
         */
         public bool Transports(double currentDistance,int fuelPrice)
        {
            if (IsFree)
            {
                TravelledKM += currentDistance;
                CurrentCost = (int)(fuelPrice * currentDistance * FuelConsumption / 100);
                IsFree = false;
                return true;
            }
            return false;
        }
        //Calculate the base rent fee
        public virtual int RentFee()
        {
            return (int)(BaseFee + CurrentCost + CurrentCost * ProfitMargin / 100);
        }
        //Finishing the transport. The vehicle will be free.
        public void TransportEnd()
        {
            IsFree = true;
        }
        public override string ToString()
        {
            return "\nThe id of " + this.GetType().Name.ToLower() + ": " + Id + 
             "\nthe registration number: " + RegistrationNumber + "\ntage: " +Age() + " year" +
             "\n\tfuel-consumption: " + FuelConsumption + " litre/100 km" +
             "\n\t speedometer: " + TravelledKM + "km";
        }
    }
}
