using System;
using Microsoft.EntityFrameworkCore.TestUtilities;
using Microsoft.Extensions.DependencyInjection;

namespace MongoDB.EntityFrameworkCore.TestSuite.Utilities;

public class MongoDbTestStoreFactory : ITestStoreFactory
{
    public static MongoDbTestStoreFactory Instance { get; } = new();

    public TestStore Create(string storeName)
        => MongoDbTestStore.Create(storeName);

    public TestStore GetOrCreate(string storeName)
        // TODO: should we implement shared concurrent store?
        => MongoDbTestStore.Create(storeName);

    public IServiceCollection AddProviderServices(IServiceCollection serviceCollection)
        => serviceCollection.AddEntityFrameworkMongoDB();

    public ListLoggerFactory CreateListLoggerFactory(Func<string, bool> shouldLogCategory)
        => new ListLoggerFactory(shouldLogCategory);
}
