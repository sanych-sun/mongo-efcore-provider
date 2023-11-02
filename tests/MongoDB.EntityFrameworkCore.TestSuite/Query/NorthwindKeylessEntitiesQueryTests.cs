using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestUtilities;

namespace MongoDB.EntityFrameworkCore.TestSuite.Query
{
    public class NorthwindKeylessEntitiesQueryTests : NorthwindKeylessEntitiesQueryTestBase<NorthwindQueryMongoDbFixture<NoopModelCustomizer>>
    {
        public NorthwindKeylessEntitiesQueryTests(NorthwindQueryMongoDbFixture<NoopModelCustomizer> fixture) : base(fixture)
        {
        }
    }
}
