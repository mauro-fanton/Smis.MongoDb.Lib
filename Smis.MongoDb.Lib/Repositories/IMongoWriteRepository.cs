using MongoDB.Driver;

namespace Smis.MongoDb.Lib.Repositories
{
	public interface IMongoWriteRepository<TDocument> where TDocument : class
    {
        Task<ReplaceOneResult> Save(TDocument application);
    }
}

