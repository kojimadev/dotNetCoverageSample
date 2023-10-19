using dotNetStdLib;

namespace LibTest
{
    [TestClass]
    public class SampleClassTest
    {
        [TestMethod]
        public void GetHelloTest()
        {
            var sample = new SampleClass();
            Assert.AreEqual("Hello", sample.GetHello());
        }
    }
}