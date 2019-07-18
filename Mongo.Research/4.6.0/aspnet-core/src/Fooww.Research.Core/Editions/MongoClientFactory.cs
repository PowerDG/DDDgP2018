using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace Fooww.Research.Editions
{
    public class MongoClientFactory : IMongoClientFactory
    {
        private readonly IAuditingMongoDbConfiguration _mongoDbConfiguration;

        public MongoClientFactory(IAuditingMongoDbConfiguration mongoDbConfiguration)
        {
            _mongoDbConfiguration = mongoDbConfiguration;
        }

        public IMongoClient Create()
        {
            return new MongoClient(_mongoDbConfiguration.ConnectionString);
        }
    }
}
