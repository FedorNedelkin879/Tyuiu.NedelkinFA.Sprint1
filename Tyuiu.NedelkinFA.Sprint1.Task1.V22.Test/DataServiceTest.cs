using Tyuiu.NedelkinFA.Sprint1.Task1.V22.Lib;
namespace Tyuiu.NedelkinFA.Sprint1.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(3, res);
        }
    }
}