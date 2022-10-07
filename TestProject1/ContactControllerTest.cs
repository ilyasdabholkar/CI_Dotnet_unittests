using Microsoft.AspNetCore.Mvc;
using Session8.Controllers;
using Session8.Interfaces;
using Session8.Models;

namespace TestProject1
{
    public class ContactControllerTest
    {
        private readonly ContactController _controller;
        private readonly IContactService _service;

        public ContactControllerTest()
        {
            _service = new ContactFakeService();
            _controller = new ContactController(_service);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsOkResult()
        {
            // Act
            var okResult = _controller.AllContacts();

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.AllContacts() as OkObjectResult;

            // Assert
            var items = Assert.IsType<List<Contact>>(okResult.Value);
            Assert.Equal(3, items.Count);
        }

        [Fact]
        public void GetById_UnknownGuidPassed_ReturnsNotFoundResult()
        {
            // Act
            var notFoundResult = _controller.GetContact(Guid.NewGuid());

            // Assert
            Assert.IsType<NotFoundResult>(notFoundResult);
        }

        [Fact]
        public void GetById_ExistingGuidPassed_ReturnsOkResult()
        {
            // Arrange
            var testGuid = new Guid("33704c4a-5b87-464c-bfb6-51971b4d18ad");

            // Act
            var okResult = _controller.GetContact(testGuid);

            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

    }
}