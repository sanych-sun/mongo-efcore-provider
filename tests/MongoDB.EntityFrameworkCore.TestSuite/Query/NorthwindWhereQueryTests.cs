using Microsoft.EntityFrameworkCore.Query;
using Microsoft.EntityFrameworkCore.TestUtilities;

namespace MongoDB.EntityFrameworkCore.TestSuite.Query;

public class NorthwindWhereQueryTests : NorthwindWhereQueryTestBase<NorthwindQueryMongoDbFixture<NoopModelCustomizer>>
{
    public NorthwindWhereQueryTests(NorthwindQueryMongoDbFixture<NoopModelCustomizer> fixture)
        : base(fixture)
    {
    }
}
