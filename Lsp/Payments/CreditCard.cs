﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Payments
{
    class CreditCard : ItauCard
    {
        public override void Validate()
        {
            Console.WriteLine("Validando limite");
            Console.WriteLine("Limite Ok");
        }
    }
}
