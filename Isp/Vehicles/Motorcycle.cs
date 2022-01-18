using System;

namespace Isp.Vehicles
{
    class Motorcycle : IVehicle, IVehicleMotorcycle
    {
        private string Color;
        private int Year;
        private double Engine;

        public Motorcycle(string color, int year, double engine)
        {
            Color = color;
            Year = year;
            Engine = engine;

            ConfigureMotorcycle(color, year, engine);

        }

        //Obrigação de implementar mesmo sem usar
        //public void ConfigureCar(string color, int year, double engine, int seats, int doors)
        //{
        //
        //}

        public void ConfigureMotorcycle(string color, int year, double engine)
        {
            Color = color;
            Year = year;
            Engine = engine;

            Console.WriteLine($"Criando moto do ano {year}, cor {color}, {engine} cilindradas.");
            StartVehicle();
        }

        public void StartVehicle()
        {
            Console.WriteLine("Ligando os motores...");
        }
    }
}
