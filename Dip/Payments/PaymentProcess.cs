using Dip.Factory;
using Dip.Model;
using System;

namespace Dip.Payments
{
    //Classe de alto nivel
    class PaymentProcess
    {
        public void Pay(string id)
        {
            //Independente da configuração do banco de dados, funcionará. Payment Process não depende de uma classe de baixo nivel
            //e também não depende de uma classe de alto nivel. 
            //Mas sim, depende da abstração da interface    
            IDbProduct product = DbProductFactory.Create();
            string productData = product.GetProductById(id);
            Console.WriteLine(productData);
        }
    }
}
