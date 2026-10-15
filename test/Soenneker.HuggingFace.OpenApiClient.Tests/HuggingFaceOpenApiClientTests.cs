using Soenneker.Tests.HostedUnit;

namespace Soenneker.HuggingFace.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class HuggingFaceOpenApiClientTests : HostedUnitTest
{
    public HuggingFaceOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
