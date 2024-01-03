using MongoDB.Driver;

namespace Smis.MongoDb.Lib.Connection
{
    public class MongoDbConnection : IMongoDbConnection
    {
        public MongoDbConnection()
        {
        }

        private readonly IMongoClient client;
        private readonly string database;
      

        public MongoDbConnection(string database, IMongoClient client)
        {
            this.client = client;
            this.database = database;

        }      
     
        public IMongoCollection<Document> GetCollection<Document>(string collectioName)
        {
            return client.GetDatabase(database).GetCollection<Document>(collectioName);
        }
    }
}

