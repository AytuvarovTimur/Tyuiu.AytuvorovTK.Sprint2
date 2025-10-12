using Tyuiu.AytuvorovTK.Sprint2.Task3.V30.Lib;
namespace Tyuiu.AytuvorovTK.Sprint2.Task3.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double x = 5;
            double res = ds.Calculate(x);
            double wait = 12.594;
            Assert.AreEqual(wait, res);

        }
        [TestMethod]
        public void TestMethod2()
        {

        }
        [TestMethod]
        public void TestMethod3()
        {

        }
        [TestMethod]
        public void TestMethod4()
        {
        }
    }
}
