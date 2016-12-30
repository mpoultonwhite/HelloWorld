using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;

namespace HelloWorldTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MessageContainsHelloWorld()
        {
            Assert.AreEqual(Messages.createMessage(), "Hello World");
        }
    }
}
