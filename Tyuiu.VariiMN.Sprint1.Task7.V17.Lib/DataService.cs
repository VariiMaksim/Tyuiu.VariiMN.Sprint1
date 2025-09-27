using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.VariiMN.Sprint1.Task7.V17.Lib
{
    public class DataService : ISprint1Task7V17
    {
        public double Calculate(double x, double y)
        {
            double num1 = 1 + Math.Sin(Math.Sqrt(Math.Pow(x, 2) + 1));
            double num2 = Math.Cos(12 * y - 4);
            double res = num1 / num2;
            return Math.Round(res, 3);
        }
    }
}
