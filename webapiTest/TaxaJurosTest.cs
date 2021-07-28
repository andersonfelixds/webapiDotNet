using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;


namespace webapiTest
{
    public class TaxaJurosTest<TStartup> : WebApplicationFactory<TStartup> where TStartup: class
    {
      //  private readonly TestServer _server;
        private readonly HttpClient _client;

        public TaxaJurosTest()
        {
            // Arrange 
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<TStartup>());
            _client = server.CreateClient();
        }

        [Theory]
        [InlineData("GET")]
        public async Task TaxaJurosTestAsync(string method)
        {
            // Arrange
            var request = new HttpRequestMessage(new HttpMethod(method), "/TaxaJuros");

            // Act
            var response = await _client.SendAsync(request);

            // Assert
            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
