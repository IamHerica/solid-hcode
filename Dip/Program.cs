using Dip.Payments;
using System;

namespace Dip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PaymentProcess pay = new PaymentProcess();
            pay.Pay("abc123");

        }
    }
}
