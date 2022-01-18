using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Vehicles
{
    public class Vehicle : IVehicle
    {
        protected string Color;
        protected int Year;
        protected double Engine;

        public Vehicle(string color, int year, double engine)
        {
            Color = color;
            Year = year;
            Engine = engine;
        }
        public void StartVehicle()
        {
            Console.WriteLine("Ligando o veiculo");
        }
    }


}
