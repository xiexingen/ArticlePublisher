using System.Threading.Tasks;
using Shouldly;
using Xunit;

namespace XXG.ArticlePublisher.Pages
{
    public class Index_Tests : ArticlePublisherWebTestBase
    {
        [Fact]
        public async Task Welcome_Page()
        {
            var response = await GetResponseAsStringAsync("/");
            response.ShouldNotBeNull();
        }
    }
}
