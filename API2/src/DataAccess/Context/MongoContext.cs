using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class MongoContext : MongoClient
    {
        private const string _localDb = "local";

        public MongoContext() : base(ConfigurationManager.ConnectionStrings["MongoServer"].ConnectionString)
        {

        }

        public IMongoDatabase GetDatabase()
        {
            return this.GetDatabase(_localDb);
        }
    }
}
