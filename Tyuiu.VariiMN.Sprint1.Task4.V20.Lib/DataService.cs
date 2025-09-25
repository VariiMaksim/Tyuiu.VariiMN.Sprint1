using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VariiMN.Sprint1.Task4.V20.Lib
{
    public class DataService : ISprint1Task4V20
    {
        public double Calculate(double x, double y)
        {
            double num1 = 1 + x;
            double num2 = Math.Abs(x - Math.Sqrt(2 + y));
            double res = num1 / num2;

            return Math.Round(res, 3);
        }
    }
}
