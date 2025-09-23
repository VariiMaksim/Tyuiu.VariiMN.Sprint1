using Tyuiu.VariiMN.Sprint1.Task3.V8.Lib;
// Написать программу вычисления величины дохода по вкладу. Процентная ставка (% годовых) и время хранения (дней) задаются во время работы программы.
// Ответ округлите до 3 знаков после запятой.
//Величина вклада(руб.) -> 2500
//Срок вклада(дней) -> 30
//Процентная ставка(годовых) -> 20
//Доход: 41.10 руб.
//Сумма по окончании срока вклада: 2541.10 руб.
namespace Tyuiu.VariiMN.Sprint1.Task3.V8
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Варий М. Н. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Организация ввода и вывода в консольных приложениях              *");
            Console.WriteLine("* Задание #3                                                             *");
            Console.WriteLine("* Вариант #8                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич. | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу вычисления величины дохода по вкладу. Процентная    *");
            Console.WriteLine("* ставка (% годовых) и время хранения (дней) задаются во время           *");
            Console.WriteLine("* работы программы. Ответ округлите до 3 знаков после запятой.           *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");
            int startAmount;

            Console.WriteLine("Величина вклада (руб.) ->");
            startAmount = Convert.ToInt32(Console.ReadLine());
            int timeDays;

            Console.WriteLine("Срок вклада (дней) ->");
            timeDays = Convert.ToInt32(Console.ReadLine());
            int percent;

            Console.WriteLine("Процентная ставка (годовых) ->");
            percent = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");

            Console.WriteLine("Доход:" + ds.IncomeAmount(startAmount, percent, timeDays));
            Console.ReadLine();


        }
    }
}