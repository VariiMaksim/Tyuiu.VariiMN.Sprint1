using Tyuiu.VariiMN.Sprint1.Task0.V19.Lib;
namespace Tyuiu.VariiMN.Sprint1.Task0.V19.Test
{
    public class DataServiceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(10, res);
        }
    }
}