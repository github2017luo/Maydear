using Maydear;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MaydearUnitTest
{
    [TestClass]
    public class PageUnitTest
    {
        [TestMethod]
        public void OffsetTestMethod()
        {
            var page = new Page()
            {
                PageIndex = 2,
                PageSize = 100
            };

            Assert.AreEqual(page.Offset, 100);
        }

        [TestMethod]
        public void StartOffsetTestMethod()
        {
            var page = new Page()
            {
                PageIndex = 1,
                PageSize = 100
            };

            Assert.AreEqual(page.Offset, 0);
        }
    }
}
