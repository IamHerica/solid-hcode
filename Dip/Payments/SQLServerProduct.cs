using Dip.Model;

namespace Dip.Payments
{

    //Classe de baixo nivel 
    class SQLServerProduct : IDbProduct
    {
        public string GetProductById(string id)
        {
            return $"SQLServer: exibindo dados do produto {id}.";
        }
    }
}