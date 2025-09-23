using Tyuiu.VariiMN.Sprint1.Task3.V8.Lib;

namespace Tyuiu.VariiMN.Sprint1.Task3.V8.Test
{
    public class Tests
    {
        [Test]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double startAmount = 2500;
            double percent = 20;
            double timeDays = 30;
            double wait = 41.10;
            var res = ds.IncomeAmount(startAmount, percent, timeDays);
            Assert.AreEqual(wait, res);

        }
    }
}