using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace TestPlayWright.Pages;

public class Index_Tests : TestPlayWrightWebTestBase
{
    [Fact]
    public async Task Welcome_Page()
    {
        var response = await GetResponseAsStringAsync("/");
        response.ShouldNotBeNull();
    }
}
