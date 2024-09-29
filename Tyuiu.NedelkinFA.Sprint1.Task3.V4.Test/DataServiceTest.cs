using Tyuiu.NedelkinFA.Sprint1.Task3.V4.Lib; 

namespace Tyuiu.NedelkinFA.Sprint1.Task3.V4.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2.75;
            double y = 0.5;
            int wait = 7;
            var res = ds.PurchaseAmount(x, y, wait);
            Assert.AreEqual(22.75, res);
        }
    }
}