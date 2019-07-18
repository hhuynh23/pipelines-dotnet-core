using Microsoft.VisualStudio.TestTools.UnitTesting;
using pipelines_dotnet_core.Controllers;

namespace pipelines_dotnet_core_test_2
{
    [TestClass]
    public class CoverletControllerTest
    {
        readonly CoverletController controller = new CoverletController();
        [TestMethod]
        public void Index_Test()
        {
            controller.Index();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void List_Test()
        {
            controller.List();
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void Detail_Test()
        {
            controller.Detail();
            Assert.IsTrue(true);
        }
    }
}
