
using MongoDB.Driver;

namespace Smis.MongoDb.Lib.Repositories
{
    public interface IMongoReadRepository<TDocument> where TDocument : class
    {        
        Task<List<TDocument>> GetDocuments(string collectionName);
        Task<TDocument?> GetDocument(string collectionName, FilterDefinition<TDocument> filter);
        Task<TDocument?> GetDocument(string collectionName, string ApplicationNamber);

    }
}

