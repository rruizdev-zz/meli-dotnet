using System.Threading.Tasks;
using AutoMapper;
using MercadoLibre.Backend.Application;
using MercadoLibre.Backend.Application.Services.Interfaces;
using MercadoLibre.Backend.Domain.Models.Items;
using MercadoLibre.Backend.Domain.Responses.Items;
using MercadoLibre.Backend.WebApi.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Moq;
using NUnit.Framework;

namespace MercadoLibre.Backend.WebApi.Tests.Controllers
{
    [TestFixture]
    public class ItemsControllerTest
    {
        private ItemsController controller;

        private Mock<IItemsService> service;

        private Mock<IMapper> mapper;

        private Mock<IOptions<ApplicationSettings>> settings;

        [SetUp]
        public void SetUp()
        {
            service = new Mock<IItemsService>();

            mapper = new Mock<IMapper>();

            settings = new Mock<IOptions<ApplicationSettings>>();

            controller = new ItemsController(service.Object, mapper.Object, settings.Object);
        }

        [Test]
        public async Task SearchShouldBeSuccessful()
        {
            // Arrange

            service.Setup(s => s.Search(It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(new Search()));

            settings.Setup(s => s.Value).Returns(new ApplicationSettings()
            {
                UrlItemSearch = "http://www.localhost.com/items?q={0}"
            });

            mapper.Setup(m => m.Map<SearchResponse>(It.IsAny<Search>())).Returns(new SearchResponse());

            // Action

            var result = await controller.Search("iPhone XR");

            // Assert

            Assert.IsInstanceOf<OkObjectResult>(result);

            Assert.IsNotNull(((OkObjectResult) result).Value);

            Assert.IsNotNull(((SearchResponse)((OkObjectResult) result).Value).Author);
        }
        
        [Test]
        public async Task DetailShouldBeSuccessful()
        {
            // Arrange

            service.Setup(s => s.DetailWithDescription(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>())).Returns(Task.FromResult(new Detail()));

            settings.Setup(s => s.Value).Returns(new ApplicationSettings()
            {
                UrlItemDetail = "http://www.localhost.com/items/{0}",
                UrlItemDescription = "http://www.localhost.com/items/{0}/description"
            });

            mapper.Setup(m => m.Map<DetailResponse>(It.IsAny<Detail>())).Returns(new DetailResponse());

            // Action

            var result = await controller.Detail("MLA123456789");

            // Assert

            Assert.IsInstanceOf<OkObjectResult>(result);

            Assert.IsNotNull(((OkObjectResult) result).Value);

            Assert.IsNotNull(((DetailResponse)((OkObjectResult) result).Value).Author);
        }
    }
}
