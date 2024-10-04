using Tyuiu.NedelkinFA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.NedelkinFA.Sprint1.Task5.V3.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpress()
        {
            int x = 130985;
            DataService ds = new DataService();
            double res = ds.Calculate(x);

            int result = Convert.ToInt32(res);

            int wait = 9;
            Assert.AreEqual(wait, result);
        }
    }
}