using Isp.Vehicles;
using System;

namespace Isp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Car car = new Car("azul", 2022, 4.0, 2, 2);
           Motorcycle motorcycle = new Motorcycle("azul", 2022, 4.0);
        }
    }
}
