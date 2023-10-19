using dotNetStdLib;

namespace LibTest
{
    [TestClass]
    public class SampleClassTest
    {
        /// <summary>
        /// test
        /// </summary>
        [TestMethod]
        public void GetHelloTest()
        {
            var sample = new SampleClass();
            Assert.AreEqual("Hello", sample.GetHello());
        }
    }
}