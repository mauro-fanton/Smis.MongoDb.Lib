using MongoDB.Driver;

namespace Smis.MongoDb.Lib.Connection;

public interface IMongoDbConnection
{
    IMongoCollection<Document> GetCollection<Document>(string collectioName);
}

