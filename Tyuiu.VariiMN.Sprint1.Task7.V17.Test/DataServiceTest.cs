using Tyuiu.VariiMN.Sprint1.Task7.V17.Lib;

namespace Tyuiu.VariiMN.Sprint1.Task7.V17.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            double wait = 4.871;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}