using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Fabrikam.Module1.Uc1.Services.WebApi;
using Fabrikam.Module1.Uc1.Services.WebApi.Controllers;

namespace Fabrikam.Module1.Uc1.Services.WebApi.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("Home Page", result.ViewBag.Title);
        }
    }
}
