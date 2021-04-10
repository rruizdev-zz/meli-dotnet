using MercadoLibre.Backend.Application.Services;
using MercadoLibre.Backend.Application.Services.Interfaces;
using Moq;
using NUnit.Framework;
using System.Net.Http;
using System.Threading.Tasks;

namespace MercadoLibre.Backend.Application.Tests.Services
{
    [TestFixture]
    public class ItemServiceTest
    {
        private Mock<HttpClient> client;

        private IItemsService service;

        [SetUp]
        public void SetUp()
        {
            client = new Mock<HttpClient>();

            service = new ItemsService(client.Object);
        }

        [Ignore("Wrong mock")]
        public async Task SearchShouldBeSuccessful()
        {
            // Arrange

            var response = @"{""author"":{""name"":""Roberto"",""lastname"":""Ruiz""},""categories"":[
                            ""Celulares y Smartphones"",""Celulares y Teléfonos"",""Celulares y Smartphones""],
                            ""items"":[{""id"":""MLA770473306"",""title"":""iPhone Xr Apple 64gb Liberado Sellado Factura Y Garantia"",
                            ""price"":{""currency"":""ARS"",""amount"":59199,""decimals"":0},""picture"":
                            ""http://mla-s1-p.mlstatic.com/615691-MLA31135676120_062019-I.jpg"",""condition"":""new"",
                            ""free_shipping"":true,""location"":""Capital Federal""},{""id"":""MLA760880829"",""title"":
                            ""Apple iPhone Xr 128gb 3gb Ram 6.1' 4g 12mp A12 New Coral"",""price"":{""currency"":""ARS"",
                            ""amount"":67999.99,""decimals"":99},""picture"":""http://mla-s2-p.mlstatic.com/645860-MLA31603580850_072019-I.jpg"",
                            ""condition"":""new"",""free_shipping"":true,""location"":""Capital Federal""}]}";

            client.Setup(c => c.GetStringAsync(It.IsAny<string>())).Returns(Task.FromResult(response));
            
            // Action

            var result = await service.Search(It.IsAny<string>(), It.IsAny<string>());
        }
    }
}
