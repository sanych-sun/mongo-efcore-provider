using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestUtilities;

namespace MongoDB.EntityFrameworkCore.TestSuite.Query
{
    public class NorthwindSelectQueryTests : NorthwindSelectQueryTestBase<NorthwindQueryMongoDbFixture<NoopModelCustomizer>>
    {
        public NorthwindSelectQueryTests(NorthwindQueryMongoDbFixture<NoopModelCustomizer> fixture) : base(fixture)
        {
        }
    }
}
