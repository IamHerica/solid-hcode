using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ocp
{
    public class Vehicle
    {
        //Errado, pois ao alterar alguma coisa entre os veículos, é necessário mudar todo o codigo. Alem de desrespeitar o SRP
        //private string Color;
        //private int Year;
        //private double Engine;
        //private int Seats;
        //private int Doors;

        //public Vehicle(string color, int year, double engine, int seats, int doors)
        //{
        //    Color = color;
        //    Year = year;
        //    Engine = engine;
        //    Seats = seats;
        //    Doors = doors;
        //}

        //public static void Car(string color, int year, double engine, int seats, int doors)
        //{
        //    Console.WriteLine($"Criando um carro {color}, ano {year}, com motot {engine}, com {seats} acentos e {doors} portas.");
        //}

        //public static void Motorcycle(string color, int year, double engine)
        //{
        //    Console.WriteLine($"Criando uma moto {Color}, ano {Year}, com cilindrada {Engine}.");
        //}
        //public void StartVehicle()
        //{
        //    Console.WriteLine("Ligando o veiculo");
        //}
    }
}
