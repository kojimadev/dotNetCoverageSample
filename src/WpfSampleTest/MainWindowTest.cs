using WpfSampleApp;

namespace WpfSampleTest
{
    [TestClass]
    public class MainWindowTest
    {
        [TestMethod]
        public void TestMethod()
        {
            Assert.AreEqual(true, MainWindow.GetValue());
        }
    }
}