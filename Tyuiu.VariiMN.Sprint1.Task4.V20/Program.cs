using Tyuiu.VariiMN.Sprint1.Task4.V20.Lib;

namespace Tyuiu.VariiMN.Sprint1.Task4.V20
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Варий М. Н. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Class Math                                                       *");
            Console.WriteLine("* Задание #4                                                             *");
            Console.WriteLine("* Вариант #20                                                            *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич  | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные *");
            Console.WriteLine("* вычисляет результат по формуле и печатает его на экране.               *");
            Console.WriteLine("* 1 + x / |x - √2 + y|                                                   *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* 1 + x / |x - √2 + y|                                                   *");



            int x, y;

            Console.WriteLine("Введите значение x:");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите значение y:");
            y = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("1 + x / |x - √2 + y| = " + ds.Calculate(x, y));
            Console.ReadKey();


        }
    }
}