using Tyuiu.VariiMN.Sprint1.Task5.V6.Lib;

namespace Tyuiu.VariiMN.Sprint1.Task5.V6
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Варий М. Н. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема:  Преобразование типов и класс Convert                            *");
            Console.WriteLine("* Задание #5                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу:                   *");
            Console.WriteLine("* Пусть k – целое от 1 до 365. Присвоить целой переменной n              *");
            Console.WriteLine("* значение 1,2,...,7 в зависимости от того, на какой день                *");
            Console.WriteLine("* недели (понедельник, вторник,..., воскресенье) приходится k-й день     *");
            Console.WriteLine("* невисокосного года, в котором 1 января – понедельник.                  *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");

            int k;


            Console.WriteLine("Введите положительное целое число k от 1 до 365:");
            k = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            try
            {
                int res = Convert.ToInt32(ds.Calculate(k));
                Console.WriteLine($"День недели для {k}-го дня: {res}");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: k должно быть от 1 до 365.");
            }

            Console.ReadKey();
        }
    }
}