using Tyuiu.VariiMN.Sprint1.Task2.V15.Lib;

namespace Tyuiu.VariiMN.Sprint1.Task2.V15.Test
{
    public class Tests
    {
        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            int x = 2;
            var res = ds.CalculateCubeVolume(x);
            Assert.AreEqual(8, res);
        }
    }
}