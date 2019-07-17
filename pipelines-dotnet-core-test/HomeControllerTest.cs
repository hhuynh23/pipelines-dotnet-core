using Microsoft.VisualStudio.TestTools.UnitTesting;
using pipelines_dotnet_core.Controllers;

namespace pipelines_dotnet_core_test
{
    [TestClass]
    public class HomeControllerTest
    {
        readonly HomeController controller = new HomeController();
        [TestMethod]
        public void Index_Test()
        {
            controller.Index();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Privacy_Test()
        {
            controller.Privacy();
            Assert.IsTrue(true);
        }
    }
}
