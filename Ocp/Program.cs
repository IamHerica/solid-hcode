using Ocp.Vehicles;
using System;

namespace Ocp
{
    public class Program
    {
        static void Main(string[] args)
        {
            TypeVehicle type = TypeVehicle.MOTORCYCLE;


            //Errado, não respeita o SRP
            //if (type == TypeVehicle.CAR)
            //{
            //    Vehicle car = new Vehicle("yellow", 2022, 2.0, 5, 4);
            //    car.Car();
            //}
            //else
            //{
            //    Vehicle motorcycle = new Vehicle("blue", 2022, 250, 1, 0);
            //    motorcycle.Motorcycle();
            //}

            if(type == TypeVehicle.CAR)
            {
                Car car = new Car("Yellow", 2002, 2.0, 5, 4);
                car.ConfigureCar();
            } else
            {
                Motorcycle motorcycle = new Motorcycle("Blue", 2002, 250);
                motorcycle.ConfigureMotorcycle();
            }


        }
    }
}
