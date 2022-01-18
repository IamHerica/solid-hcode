using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Payments
{
    class ItauRewards : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado com sucesso!");  
            
        }

        public void Validate()
        {
            Console.WriteLine("Limite ok, rewards ok!");
        }
    }
}
