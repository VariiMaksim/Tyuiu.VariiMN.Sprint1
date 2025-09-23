using Tyuiu.VariiMN.Sprint1.Task1.V9.Lib;

namespace Tyuiu.VariiMN.Sprint1.Task1.V9.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(0.5, res);

        }
    }
}