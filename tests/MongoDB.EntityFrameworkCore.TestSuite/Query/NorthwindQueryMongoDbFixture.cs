using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestUtilities;
using MongoDB.EntityFrameworkCore.TestSuite.Utilities;

namespace MongoDB.EntityFrameworkCore.TestSuite.Query;

public class NorthwindQueryMongoDbFixture<TModelCustomizer> : NorthwindQueryFixtureBase<TModelCustomizer>
    where TModelCustomizer : IModelCustomizer, new()
{
    protected override ITestStoreFactory TestStoreFactory => MongoDbTestStoreFactory.Instance;
    protected override Type ContextType => typeof(NorthwindMongoDbContext);
}
