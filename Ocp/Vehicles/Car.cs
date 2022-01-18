using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Vehicles
{
    class Car : Vehicle
    {
        private int Seats;
        private int Doors;

        public Car(string color, int year, double engine, int seats, int doors) : base(color, year, engine)
        {
            Seats = seats;
            Doors = doors;
        }

        public void ConfigureCar()
        {
            Console.WriteLine($"Criando um carro {Color}, ano {Year}, com motot {Engine}, com {Seats} acentos e {Doors} portas.");
        }
    }
}
