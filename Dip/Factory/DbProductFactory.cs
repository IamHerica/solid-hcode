using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Dip.Payments;
using Dip.Model;

namespace Dip.Factory
{
    class DbProductFactory
    {
        public static IDbProduct Create()
        {
            if(ConfigurationManager.AppSettings["DB"] == "SQLSERVER")
            {
                return new SQLServerProduct();
            } else
            {
                return new MongoDbProduct();
            }
        }
    }
}
