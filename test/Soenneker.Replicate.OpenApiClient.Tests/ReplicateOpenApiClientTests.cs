using Soenneker.Tests.HostedUnit;

namespace Soenneker.Replicate.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class ReplicateOpenApiClientTests : HostedUnitTest
{
    public ReplicateOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
