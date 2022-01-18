using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Payments
{
    internal class DebitCard : ItauCard
    {
        public override void Validate()
        {
            Console.WriteLine("Verificando saldo da conta");
            Console.WriteLine("Saldo Ok");
        }
    }
}
