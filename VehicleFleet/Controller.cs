using System;
using System.Collections.Generic;
using System.IO;

namespace VehicleFleet
{
    class Controller
    {
        private List<Vehicle> vehicles = new List<Vehicle>();
        private string BUS = "bus";
        private string TRUCK = "truck";

        public void Start()
        {
            StaticValues();
            Input();
            Output("\nThe registered vehicles: \n");
            Travelling();
            Output("\n\nAfter travelling: \n");
            AvreageAge();
            MaxTravelledKm();
            Sorting();

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine("The rent-fee of the vehicle registered with " + vehicle.RegistrationNumber + " is: " + vehicle.RentFee());
            }
        }

        private void StaticValues()
        {
            //setting static values
            Vehicle.CurrentYear = 2016;
            Vehicle.BaseFee = 1000;
            Vehicle.ProfitMargin = 10;

            Bus.Multiplier = 15;
            Truck.Multiplier = 8.5;
        }

        private void Input()
        {
            string type, registrationNr, id;
            int manufacturingYear, seats;
            double consumption;
            double carryingCapacity;
            string dataLine;
            string[] data;

            int idNumber = 1;
            StreamReader streamReader = new StreamReader("vehicles.txt");
            try
            {
                while (!streamReader.EndOfStream)
                {
                    dataLine = streamReader.ReadLine();
                    data = dataLine.Split(';');
                    type = data[0];
                    registrationNr = data[1];
                    manufacturingYear = int.Parse(data[2]);
                    consumption = double.Parse(data[3]);
                    id = type.Substring(0, 1).ToUpper() + idNumber;

                    if (type==BUS)
                    {
                        seats = int.Parse(data[4]);
                        vehicles.Add(new Bus(id, registrationNr, manufacturingYear, consumption, seats));
                    }
                    else if (type==TRUCK)
                    {
                        carryingCapacity = double.Parse(data[4]);
                        vehicles.Add(new Truck(id, registrationNr, manufacturingYear, consumption, carryingCapacity));
                    }
                    idNumber++;
                }
                streamReader.Close();
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex);
            }
        }

        private void Travelling()
        {
            int costSum = 0, feeSum = 0;
            Random rand = new Random();
            int lowerLimitOfFuelPrice = 400, upperLimitOfFuelPrice = 420;
            double maxDistance = 300;
            int operationLimit = 200;
            int vehicleIndex;

            Vehicle vehicle;
            int numberOfTransports = 0;
            Console.WriteLine("\nTravelling simulation\n");

            for (int i = 0; i < (int)rand.Next(operationLimit); i++)
            {
                vehicleIndex = rand.Next(vehicles.Count);
                vehicle = vehicles[vehicleIndex];
                if (vehicle.Transports(rand.NextDouble()*maxDistance,rand.Next(lowerLimitOfFuelPrice,upperLimitOfFuelPrice)))
                {
                    numberOfTransports++;
                    Console.WriteLine("\nThe registration number of the travelling vehicle: " + vehicle.RegistrationNumber +
                        "\n\nCurrent Cost: " + vehicle.CurrentCost + "Ft." + "\nCurrent fee: " + vehicle.RentFee() + " Ft. ");
                    feeSum += vehicle.RentFee();
                    costSum += vehicle.CurrentCost;
                }
                vehicleIndex = rand.Next(vehicles.Count);
                vehicles[vehicleIndex].TransportEnd();
            }
            Console.WriteLine("\n\nTotal cost: " +costSum + "Ft. " + "\n\nTotal fee: " +
                "\n\nProfit: " + (feeSum-costSum) + "Ft." + "\n\nNumber of transports: " + numberOfTransports);


        }

        private void Output(string cim)
        {
            Console.WriteLine(cim);
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine(vehicle);
            }
        }

        private void AvreageAge()
        {
            double ageSum = 0;
            int itemsNumber = 0;
            foreach (Vehicle vehicle in vehicles)
            {
                ageSum += vehicle.Age();
                itemsNumber++;
            }
            if (itemsNumber>0)
            {
                Console.WriteLine("\nThe average of the vehicles' age: " + ageSum / itemsNumber + "years.");
            }
            else
            {
                Console.WriteLine("There are no vehicles.");
            }
        }

        private void MaxTravelledKm()
        {
            double max = vehicles[0].TravelledKM;
            foreach (Vehicle vehicle in vehicles)
            {
                if (vehicle.TravelledKM==max)
                {
                    Console.WriteLine(vehicle.RegistrationNumber);
                }
            }
        }

        private void Sorting()
        {
            Vehicle temp;
            for (int i = 0; (i < vehicles.Count-1); i++)
            {
                for (int j = i+1; (j < vehicles.Count); j++)
                {
                    if (vehicles[i].FuelConsumption > vehicles[j].FuelConsumption)
                    {
                        temp = vehicles[i];
                        vehicles[i] = vehicles[j];
                        vehicles[j] = temp;
                    }
                } 
            }
            Console.WriteLine("\nOrdering by consumption: ");
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine("{0,-10} {1:00.0} liter / 100 km.", vehicle.RegistrationNumber, vehicle.FuelConsumption);
            }
        }
    }
}
