using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DependencyInjection
{
    class Program
    {
        class Car : IVehicle
        {
            public string Accelerate()
            {
                return "Driving a car";
            }

            public void Break()
            {
            }

            public void leftSignal()
            {
            }

            public void rightSignal()
            {
            }

            public void Shift()
            {
            }
        }

        class Bus : IVehicle
        {
            public string Accelerate()
            {
                return "Driving a Bus";
            }

            public void Break()
            {
            }

            public void leftSignal()
            {
            }

            public void rightSignal()
            {
            }

            public void Shift()
            {
            }

       
        }

        class MotorCycle : IVehicle
        {
            public string Accelerate()
            {
                return "Driving a Motor Cycle like crazy..";
            }

            public void Break()
            {
            }

            public void leftSignal()
            {
            }

            public void rightSignal()
            {
            }

            public void Shift()
            {
            }
  
        }

        class Vehicle
        {
            IVehicle _vehicle;
            public Vehicle(IVehicle vehicle)
            {
                _vehicle = vehicle;
            }

            public string Drive()
            {
                string result = null;
                result = _vehicle.Accelerate();
                _vehicle.Break();
                _vehicle.leftSignal();
                _vehicle.rightSignal();
                _vehicle.Shift();

                return result;
            }
        }

        static void Main(string[] args)
        {
            string result;
            Vehicle vehicleCar = new Vehicle(new Car());
            result = vehicleCar.Drive();
            Console.WriteLine(result);

            Vehicle vehicleBus = new Vehicle(new Bus());
            result = vehicleBus.Drive();
            Console.WriteLine(result);

            Vehicle vehicleMotorCycle = new Vehicle(new MotorCycle());
            result = vehicleMotorCycle.Drive();
            Console.WriteLine(result);

            Console.ReadKey();

        }
    }
}
