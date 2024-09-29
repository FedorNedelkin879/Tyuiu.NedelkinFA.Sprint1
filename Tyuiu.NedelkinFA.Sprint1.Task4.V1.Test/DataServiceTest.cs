using Tyuiu.NedelkinFA.Sprint1.Task4.V1.Lib;

namespace Tyuiu.NedelkinFA.Sprint1.Task4.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpress()
        {
            DataService ds = new DataService();
            double x = 3;
            double wait = 0.04;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);

        }
    }
}