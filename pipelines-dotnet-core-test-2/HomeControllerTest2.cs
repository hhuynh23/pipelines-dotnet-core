using Microsoft.VisualStudio.TestTools.UnitTesting;
using pipelines_dotnet_core.Controllers;

namespace pipelines_dotnet_core_test_2
{
    [TestClass]
    public class HomeControllerTest2
    {
        readonly HomeController controller = new HomeController();
        [TestMethod]
        public void Index_Test()
        {
            controller.Index();
            Assert.IsTrue(true);
        }
    }
}
