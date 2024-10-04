using Tyuiu.NedelkinFA.Sprint1.Task7.V17.Lib;
namespace Tyuiu.NedelkinFA.Sprint1.Task7.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 3;
            double y = 2;
            double wait = 0.75;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}