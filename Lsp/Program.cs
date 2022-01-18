using Lsp.Payments;
using System;

namespace Lsp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CreditCard card = new CreditCard();
            //DebitCard debit = new DebitCard();

            //Entrada o LSP, respeitando a interface, assim não quebrando a aplicação 
            //Programacao orientada a interface
            ItauRewards itauRewards = new ItauRewards();

            itauRewards.Validate();
            itauRewards.CollectPayment();
        }
    }
}
