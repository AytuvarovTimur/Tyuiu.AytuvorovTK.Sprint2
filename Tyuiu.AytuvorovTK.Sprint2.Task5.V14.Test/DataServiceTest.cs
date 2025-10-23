using Tyuiu.AytuvorovTK.Sprint2.Task5.V14.Lib;
namespace Tyuiu.AytuvorovTK.Sprint2.Task5.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();


            Assert.AreEqual("понедельник", ds.FindDayName(1, 8));
            Assert.AreEqual("вторник", ds.FindDayName(2, 1));
            Assert.AreEqual("воскресенье", ds.FindDayName(7, 1));  
            Assert.AreEqual("понедельник", ds.FindDayName(8, 1));  
            Assert.AreEqual("понедельник", ds.FindDayName(1, 1));  
            Assert.AreEqual("вторник", ds.FindDayName(2, 1));      
            Assert.AreEqual("воскресенье", ds.FindDayName(7, 1));

        }
    }
}
