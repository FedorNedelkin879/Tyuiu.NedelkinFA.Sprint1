using Tyuiu.NedelkinFA.Sprint1.Task0.V28.Lib;

namespace Tyuiu.NedelkinFA.Sprint1.Task0.V28.Test
{
    [TestClass]
    public class DataServiceTEst
    {
        [TestMethod]
        public void VoidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}