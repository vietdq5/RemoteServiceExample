using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace RemoteServiceExample.Pages
{
    public class Index_Tests : RemoteServiceExampleWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
