using Tyuiu.NedelkinFA.Sprint1.Task1.V22.Lib;

namespace Tyuiu.NedelkinFA.Sprint1.Task1.V22.Test
{
    [TestClass]
    public class DataServiceTEst
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-1, res);
        }
    }
}