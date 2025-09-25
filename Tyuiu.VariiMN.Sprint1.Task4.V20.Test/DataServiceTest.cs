using Tyuiu.VariiMN.Sprint1.Task4.V20.Lib;


namespace Tyuiu.VariiMN.Sprint1.Task4.V20.Test
{
    public class Tests
    {
        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 2;
            double wait = double.PositiveInfinity;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);

        }
    }
}