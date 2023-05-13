using DominosRemake.Web;

using Xunit;

namespace DominosRemake.Tests;

public sealed class GreetingServiceTests
{
    [Fact]
    public void GetGreetingMessage_ReturnsValidMessage()
    {
        var actual = new GreetingService().GetGreetingMessage();

        Assert.Equal(GreetingService.Message, actual);
    }
}
