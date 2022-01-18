using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lsp.Payments
{
    abstract class ItauCard : IPaymentInstrument
    {
        public void CollectPayment()
        {
            Console.WriteLine("Pagamento realizado");        }

        public virtual void Validate()
        {
            //Validação do cartão de debito ou crédito
        }
    }
}
