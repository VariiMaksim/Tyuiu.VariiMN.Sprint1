using Tyuiu.VariiMN.Sprint1.Task6.V6.Lib;

namespace Tyuiu.VariiMN.Sprint1.Task6.V6
{

    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();


            Console.Title = "Спринт #1 | Выполнил: Варий М. Н. | ИСПб-25-1";
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* Спринт #1                                                              *");
            Console.WriteLine("* Тема: Работа со строками класс String                                  *");
            Console.WriteLine("* Задание #6                                                             *");
            Console.WriteLine("* Вариант #6                                                             *");
            Console.WriteLine("* Выполнил: Варий Максим Николаевич  | ИСПб-25-1                         *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                               *");
            Console.WriteLine("* Написать программу: пользователь вводит текст.                         *");
            Console.WriteLine("* Напечатать все слова, удалив из них первую букву.                      *");
            Console.WriteLine("*                                                                        *");
            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                       *");
            Console.WriteLine("**************************************************************************");




            Console.WriteLine("Введите текст:");
            string strTest = Console.ReadLine();

            Console.WriteLine("**************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                             *");
            Console.WriteLine("**************************************************************************");
            string res = ds.DeleteFirstLetter(strTest);
            Console.WriteLine(res);
            Console.ReadKey();


        }
    }
}