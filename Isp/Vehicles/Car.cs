using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isp.Vehicles
{
    class Car : IVehicleCar
    {
        private string Color;
        private int Year;
        private double Engine;
        private int Seats;
        private int Doors;


        public Car(string color, int year, double engine, int seats, int doors)
        {
            Color = color;
            Year = year;
            Engine = engine;
            Seats = seats;
            Doors = doors;

            ConfigureCar(color, year, engine, seats, doors);

        }
        public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        {
            Color = color;
            Year = year;
            Engine = engine;
            Seats = seats;
            Doors = doors;

            Console.WriteLine($"Criando carro do ano {year}, cor {color}, motor {engine}, {seats} acentos, e {doors} portas");

        }

        //Obrigação de implementar mesmo sem usar
        //public void ConfigureMotorcycle(string color, int year, double engine)
        //{
        //
        //}

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores...");
        }
    }
}
