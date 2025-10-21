using CrudMongo.Entities;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;

namespace CrudMongo.Service;

public class MongoDbService
{
    private readonly IMongoCollection<User> _userCollection;

    public MongoDbService(IOptions<MongoDbSettings> mongoDbSettings)
    {
        MongoClient client = new MongoClient(mongoDbSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDbSettings.Value.DatabaseName);
        _userCollection = database.GetCollection<User>(mongoDbSettings.Value.CollectionName);

    }
    public async Task<List<User>> GetAllAsync()
    {
        var ussers = await _userCollection.Find(new BsonDocument()).ToListAsync();
        return ussers;
    }
    public async Task CreateAsync(User user)
    {
        try
        {
            await _userCollection.InsertOneAsync(user);
            return;
        }
        catch (Exception ex)
        {

            throw;
        }

    }
    public async Task DeleteAsync(string id)
    {
        FilterDefinition<User> filter = Builders<User>.Filter.Eq("Id", id);
        await _userCollection.DeleteOneAsync(filter);
    }

    public async Task UpdateAsync(string id, User user)
    {
        FilterDefinition<User> filter = Builders<User>.Filter.Eq("Id", id);
        await _userCollection.ReplaceOneAsync(filter, user);
    }
}
