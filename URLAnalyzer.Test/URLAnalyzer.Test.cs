using Microsoft.AspNetCore.Mvc;
using URLAnalyzer.Controllers;
using URLAnalyzer.Models;
using URLAnalyzer.Services;
using Xunit;

namespace URLAnalyzer.Test
{
    public class FakeURLAnalyzerService : IURLAnalyzerService
    {
        public LoadUrlModel GetUrlModel(string url)
        {
            LoadUrlModel model = new LoadUrlModel
            {
                WordCount = 10
            };
            return model;
        }
    }

    public class URLAnalyzerTest
    {
        [Fact]
        public void TestInvalidModel()
        {
            // Arrange
            FakeURLAnalyzerService service = new FakeURLAnalyzerService();
            HomeController homeController = new HomeController(service);
            homeController.ModelState.AddModelError("MockValidator", "MockMessage.");
            IndexModel iModel = new IndexModel();

            // Act
            var actionResult = homeController.LoadUrl(iModel);

            // Assert
            Assert.IsType<BadRequestObjectResult>(actionResult);
        }

        [Fact]
        public void TestValidModel()
        {
            // Arrange
            FakeURLAnalyzerService service = new FakeURLAnalyzerService();
            HomeController homeController = new HomeController(service);
            IndexModel iModel = new IndexModel();

            // Act
            var actionResult = homeController.LoadUrl(iModel);

            // Assert
            var tst = Assert.IsType<ViewResult>(actionResult);
            var tst2 = Assert.IsAssignableFrom<LoadUrlModel>(tst.ViewData.Model);
            Assert.Equal(10, tst2.WordCount);
        }

        [Fact]
        public void ValidationAttributeTestSuccess()
        {
            // Arrange
            var attrib = new URLAnalyzer.CustomValidators.CustomUrlValidator();

            // Act
            var result = attrib.IsValid("http://www.google.com");

            // Assert
            Assert.True(result);
        }

        [Fact]
        public void ValidationAttributeTestFailure()
        {
            // Arrange
            var attrib = new URLAnalyzer.CustomValidators.CustomUrlValidator();

            // Act
            var result = attrib.IsValid("http://www.sdfo2lsdf8.co");

            // Assert
            Assert.False(result);
        }

        // TO DO - add some service testing.
    }
}
