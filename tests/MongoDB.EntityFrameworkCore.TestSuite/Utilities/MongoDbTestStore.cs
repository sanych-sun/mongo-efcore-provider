using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.TestUtilities;
using MongoDB.Driver;

namespace MongoDB.EntityFrameworkCore.TestSuite.Utilities;

public class MongoDbTestStore : TestStore
{
    private const string MongoServer = "localhost";

    private static readonly MongoClientSettings __mongoClientSettings = new() {Server = MongoServerAddress.Parse(MongoServer)};
    private static readonly MongoClient __mongoClient = new(__mongoClientSettings);

    public MongoDbTestStore(string name, bool shared)
        : base(name, shared)
    {
    }

    public override DbContextOptionsBuilder AddProviderOptions(DbContextOptionsBuilder builder)
        => builder.UseMongoDB(__mongoClient, Name);

    public override void Clean(DbContext context)
    {
        __mongoClient.DropDatabase(this.Name);
    }

    public static MongoDbTestStore Create(string storeName)
        => new MongoDbTestStore(storeName, true);
}
