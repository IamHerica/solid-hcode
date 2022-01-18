using Dip.Model;

namespace Dip.Factory
{
    class MongoDbProduct : IDbProduct
    {
        public string GetProductById(string id)
        {
            return $"MongoDb: exibindo dados do produto {id}.";
        }

    }
}