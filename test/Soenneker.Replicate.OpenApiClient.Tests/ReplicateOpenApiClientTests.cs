using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Replicate.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class ReplicateOpenApiClientTests : FixturedUnitTest
{
    public ReplicateOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
