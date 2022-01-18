using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp.Vehicles
{
    class Motorcycle : Vehicle
    {
        public Motorcycle(string color, int year, double engine) : base(color, year, engine)
        {

        }

        public void ConfigureMotorcycle()
        {
            Console.WriteLine($"Criando uma moto {Color}, ano {Year}, com cilindrada {Engine}.");
        }
    }
}
