using Tyuiu.AytuvorovTK.Sprint2.Task7.V14.Lib;
namespace Tyuiu.AytuvorovTK.Sprint2.Task7.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            double x = 0.1;
            double y = 0;

            bool res = ds.CheckDotInShadedArea(x, y);
            bool wait = false;

            Assert.AreEqual(wait, res);
        }
    }
}
