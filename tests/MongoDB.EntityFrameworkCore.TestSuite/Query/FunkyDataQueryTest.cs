using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestUtilities;
using MongoDB.EntityFrameworkCore.TestSuite.Utilities;

namespace MongoDB.EntityFrameworkCore.TestSuite.Query;

public class FunkyDataQueryTest : FunkyDataQueryTestBase<FunkyDataQueryTest.FunkyDataQueryMongoFixture>
{
    public FunkyDataQueryTest(FunkyDataQueryMongoFixture fixture) : base(fixture)
    {
    }

    public class FunkyDataQueryMongoFixture : FunkyDataQueryFixtureBase
    {
        protected override ITestStoreFactory TestStoreFactory => MongoDbTestStoreFactory.Instance;
    }
}
